using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDBMS
{
    public partial class frmAdmin : Form
    {
        public static frmAdmin f1;//静态成员用于对外调用，否则出现“非静态字段、方法或属性"成员"需要对象引用”错误
        private string id = "无";
        private string id1 = "无";
        private string id2 = "无";
        private string id3 = "无";
        public frmAdmin()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            f1 = this;//初始化，否则出现“未将对象引用设置到对象的实例”错误
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;//不显示最大化按钮
            this.MinimizeBox = false;//不显示最小化按钮
            btnclear.Enabled = false;
            btninsert.Enabled = false;
            btnchange.Enabled = false;
            btnsearch.Enabled = false;
            btndelete.Enabled = false;
            labeltablename.Visible = false;
            keyvalue.Text = "";//查询关键字值默认为空
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = "", item = "";
            switch (labeltablename.Text)
            {
                case "仓库":
                    {
                        name = "STORE";
                        switch (keywords.SelectedItem)
                        {
                            case "ID": { item = "SID"; break; }
                            case "名称": { item = "SNAME"; break; }
                            case "地址": { item = "ADDRESS"; break; }
                            case "Tel": { item = "TEL"; break; }
                            case "物资类型": { item = "KIND"; break; }
                        }
                        break;
                    }
                case "物资":
                    {
                        name = "GOODS";
                        switch (keywords.SelectedItem)
                        {
                            case "ID": { item = "GID"; break; }
                            case "名称": { item = "GNAME"; break; }
                            case "价格": { item = "PRICE"; break; }
                            case "数量": { item = "NUM"; break; }
                            case "日期": { item = "DATE"; break; }
                            case "所属仓库": { item = "SID"; break; }
                            case "物资类型": { item = "KIND"; break; }
                        }
                        break;
                    }
                case "配送员":
                    {
                        name = "WORKER";
                        switch (keywords.SelectedItem)
                        {
                            case "ID": { item = "WID"; break; }
                            case "姓名": { item = "WNAME"; break; }
                            case "Tel": { item = "TEL"; break; }
                            case "健康码": { item = "CODE"; break; }
                            case "所属仓库": { item = "SID"; break; }
                        }
                        break;
                    }
                case "顾客":
                    {
                        name = "CUSTOMER";
                        switch (keywords.SelectedItem)
                        {
                            case "ID": { item = "CID"; break; }
                            case "姓名": { item = "CNAME"; break; }
                            case "地址": { item = "ADDRESS"; break; }
                            case "Tel": { item = "TEL"; break; }
                            case "健康码": { item = "CODE";break; }
                            case "密码": { item = "PWD"; break; }
                        }
                        break;
                    }
                case "配送":
                    {
                        name = "POST";
                        switch (keywords.SelectedItem)
                        {
                            case "顾客ID": { item = "CID"; break; }
                            case "配送员ID": { item = "WID"; break; }
                            case "物资ID": { item = "GID"; break; }
                            case "金额": { item = "MONEY"; break; }
                        }
                        break;
                    }
            }
            string sql = "select * from " + name + " where " + item + "='" + keyvalue.Text + "'";
            switch (labeltablename.Text)
            {
                case "仓库": { tableSTORE.s2.S_Search(sql); break; }
                case "物资": { tableGOODS.g2.G_Search(sql); break; }
                case "配送员": { tableWORKER.w2.W_Search(sql); break; }
                case "顾客": { tableCUSTOMER.c2.C_Search(sql); break; }
                case "配送": { tablePOST.p2.P_Search(sql); break; }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)//删除按钮
        {
            try
            {
                string name = "", item = "";
                switch (labeltablename.Text)
                {
                    case "仓库":
                        {
                            name = "STORE"; item = "SID";
                            id = tableSTORE.s2.S_id();
                            break;
                        }
                    case "物资":
                        {
                            name = "GOODS"; item = "GID";
                            id = tableGOODS.g2.G_id();
                            break;
                        }
                    case "配送员":
                        {
                            name = "WORKER"; item = "WID";
                            id = tableWORKER.w2.W_id();
                            break;
                        }
                    case "顾客":
                        {
                            name = "CUSTOMER"; item = "CID";
                            id = tableCUSTOMER.c2.C_id();
                            break;
                        }
                    case "配送":
                        {
                            name = "POST";
                            string[] id_list = new string[3];
                            id_list = tablePOST.p2.P_id();
                            id1 = id_list[0];
                            id2 = id_list[1];
                            id3 = id_list[2];
                            break;
                        }
                }
                //弹出消息框，并获取消息框的返回值
                DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //如果消息框返回值是Yes，显示新窗体
                if (dr == DialogResult.Yes)
                {
                    DBconnect conn = new DBconnect();//实例化数据库连接
                    string sql;
                    if (labeltablename.Text != "配送")
                    {
                        sql = "delete from " + name + " where " + item + "='" + id + "'";
                    }
                    else
                    {
                        sql = "delete from " + name + " where CID='" + id1 + "'and WID='" + id2 + "'and GID='" + id3 + "'";
                    }
                    conn.Execute(sql);
                    conn.DBclose();
                }
                //如果消息框返回值是No，关闭当前窗体
                switch (labeltablename.Text)//刷新
                {
                    case "仓库": { tableSTORE.s2.S_Show(); break; }
                    case "物资": { tableGOODS.g2.G_Show(); break; }
                    case "配送员": { tableWORKER.w2.W_Show(); break; }
                    case "顾客": { tableCUSTOMER.c2.C_Show(); break; }
                    case "配送": { tablePOST.p2.P_Show(); break; }
                }
            }
            catch
            {
                MessageBox.Show("请先在表格中选中要删除的记录！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)//增添按钮
        {
            bool flag=false;
            switch (labeltablename.Text)//清空相应表
            {
                case "仓库": { flag = S_edit.s1.Addnew(); break; }
                case "物资": { flag = G_edit.g1.Addnew(); break; }
                case "配送员": { flag = W_edit.w1.Addnew(); break; }
                case "顾客": { flag = C_edit.c1.Addnew(); break; }
                case "配送": { flag = P_edit.p1.Addnew(); break; }
            }
            if (flag == true)
            {
                labelopinfo.Text = "操作成功";
                labelopinfo.ForeColor = Color.Green;
                switch (labeltablename.Text)//刷新
                {
                    case "仓库": { tableSTORE.s2.S_Show(); break; }
                    case "物资": { tableGOODS.g2.G_Show(); break; }
                    case "配送员": { tableWORKER.w2.W_Show(); break; }
                    case "顾客": { tableCUSTOMER.c2.C_Show(); break; }
                    case "配送": { tablePOST.p2.P_Show(); break; }
                }
            }
            else
            {
                labelopinfo.Text = "操作失败";
                labelopinfo.ForeColor = Color.Red;
            }
        }

        private void tabletype_SelectedIndexChanged(object sender, EventArgs e)//显示左侧属性值编辑区和右下表
        {
            //labeltablename.Text = locatetable();
            keywords.Items.Clear();//清空下拉框原有值
            labeltablename.Text=tabletype.SelectedItem.ToString();//更新数据库名称显示label
            labeltablename.Visible = true;
            btndelete.Enabled = true;//解锁删除按钮
            switch (labeltablename.Text)
            {
                case "仓库":
                    {
                        S_edit form1 = new S_edit();
                        tableSTORE form2 = new tableSTORE();
                        Showform_panel1(form1);
                        Showform_panel2(form2);
                        string[] array = { "ID", "名称", "地址", "Tel", "物资类型" };
                        keywords.Items.AddRange(array);//放在这里同步操作添加数据才能使keywords成功动态更新
                        break;
                    }
                case "物资":
                    {
                        G_edit form1 = new G_edit();
                        tableGOODS form2 = new tableGOODS();
                        Showform_panel1(form1);
                        Showform_panel2(form2);
                        string[] array = { "ID", "名称", "价格", "数量", "日期", "所属仓库", "物资类型" };
                        keywords.Items.AddRange(array);
                        break;
                    }
                case "配送员":
                    {
                        W_edit form1 = new W_edit();
                        tableWORKER form2 = new tableWORKER();
                        Showform_panel1(form1);
                        Showform_panel2(form2);
                        string[] array = { "ID", "姓名", "Tel", "健康码", "所属仓库" };
                        keywords.Items.AddRange(array);
                        break;
                    }
                case "顾客":
                    {
                        C_edit form1 = new C_edit();
                        tableCUSTOMER form2 = new tableCUSTOMER();
                        Showform_panel1(form1);
                        Showform_panel2(form2);
                        string[] array = { "ID", "姓名", "地址", "Tel", "健康码", "密码" };
                        keywords.Items.AddRange(array);
                        break;
                    }
                case "配送":
                    {
                        P_edit form1 = new P_edit();
                        tablePOST form2 = new tablePOST();
                        Showform_panel1(form1);
                        Showform_panel2(form2);
                        string[] array = { "顾客ID", "配送员ID", "物资ID", "金额"};
                        keywords.Items.AddRange(array);
                        break;
                    }
            }
            btnclear.Enabled = true;
            btninsert.Enabled = true;
            btnchange.Enabled = true;
        }

        public void Showform_panel1(Form form)//在Panel1中显示窗体
        {
            //清除panel里面的其他窗体
            this.panel1.Controls.Clear();
            //将该子窗体设置成非顶级控件
            form.TopLevel = false;
            //将该子窗体的边框去掉
            form.FormBorderStyle = FormBorderStyle.None;
            //设置子窗体随容器大小自动调整
            form.Dock = DockStyle.Fill;
            //设置mdi父容器为当前窗口
            form.Parent = this.panel1;
            //子窗体显示
            form.Show();
        }

        public void Showform_panel2(Form form)//在Panel2中显示窗体
        {
            //清除panel里面的其他窗体
            this.panel2.Controls.Clear();
            //将该子窗体设置成非顶级控件
            form.TopLevel = false;
            //将该子窗体的边框去掉
            form.FormBorderStyle = FormBorderStyle.None;
            //设置子窗体随容器大小自动调整
            form.Dock = DockStyle.Fill;
            //设置mdi父容器为当前窗口
            form.Parent = this.panel2;
            //子窗体显示
            form.Show();
        }

        private void buttonclear_Click(object sender, EventArgs e)//清空按钮
        {
            switch (labeltablename.Text)
            {
                case "仓库": { S_edit.s1.Clearall(); break; }
                case "物资": { G_edit.g1.Clearall(); break; }
                case "配送员": { W_edit.w1.Clearall(); break; }
                case "顾客": { C_edit.c1.Clearall(); break; }
                case "配送": { P_edit.p1.Clearall(); break; }
            }
        }

        private void keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsearch.Enabled = true;
        }

        private void btnchange_Click(object sender, EventArgs e)//更改按钮
        {
            bool flag = false;
            switch (labeltablename.Text)//清空相应表
            {
                case "仓库": { flag = S_edit.s1.Updateold(); break; }
                case "物资": { flag = G_edit.g1.Updateold(); break; }
                case "配送员": { flag = W_edit.w1.Updateold(); break; }
                case "顾客": { flag = C_edit.c1.Updateold(); break; }
                case "配送": { flag = P_edit.p1.Updateold(); break; }
            }
            if (flag == true)
            {
                labelopinfo.Text = "操作成功";
                labelopinfo.ForeColor = Color.Green;
                switch (labeltablename.Text)//刷新
                {
                    case "仓库": { tableSTORE.s2.S_Show(); break; }
                    case "物资": { tableGOODS.g2.G_Show(); break; }
                    case "配送员": { tableWORKER.w2.W_Show(); break; }
                    case "顾客": { tableCUSTOMER.c2.C_Show(); break; }
                    case "配送": { tablePOST.p2.P_Show(); break; }
                }
            }
            else
            {
                labelopinfo.Text = "操作失败";
                labelopinfo.ForeColor = Color.Red;
            }
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            frmHelp form = new frmHelp();//启动帮助界面
            form.ShowDialog();
            this.Show();
        }
    }
}
