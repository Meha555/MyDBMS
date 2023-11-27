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
    public partial class frmUser : Form
    {
        public static frmUser f2;//静态成员用于对外调用
        public frmUser()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            f2 = this;
        }

        private void btnviewgoods_Click(object sender, EventArgs e)
        {
            string  item = "";
            switch (keywords.SelectedItem)
            {
                case "ID": { item = "GID"; break; }
                case "名称": { item = "GNAME"; break; }
                case "所属仓库": { item = "SID"; break; }
                case "物资类型": { item = "KIND"; break; }
            }
            string sql = "select * from GOODS where " + item + "='" + keyvalue.Text + "'";
            tableGOODS.g2.G_Search(sql);
        }

        private void btnviewlist_Click(object sender, EventArgs e)
        {
            Buylist form = new Buylist();//启动用户界面
            form.ShowDialog();
            this.Show();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            try//防止出现“索引超出范围。必须为非负值并小于集合大小。”的报错
            {
                string wid = "", money = "", id = "";
                id = tableGOODS.g2.G_id();
                DBconnect conn = new DBconnect();//连接数据库实例化
                string w_p = "select top 1 WID,PRICE from GOODS,WORKER,STORE where GOODS.SID=STORE.SID and WORKER.SID=STORE.SID and GOODS.GID='" + id + "' order by NEWID()";
                IDataReader dc = conn.read(w_p);
                if (dc.Read())
                {
                    wid = dc["WID"].ToString();
                    money = dc["PRICE"].ToString();
                }
                string sql = "insert into POST(CID,WID,GID,MONEY) values('" + PublicValue.userid + "','" + wid + "','" + id + "','" + money + "')";
                if (conn.Execute(sql) != -1)
                {
                    labelchoosed.Text = "已加入购物车！";
                }
                else
                {
                    labelchoosed.Text = "加入购物车失败！";
                }
            }
            catch
            {
                MessageBox.Show("请先在表格中选择！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;//不显示最大化按钮
            this.MinimizeBox = false;//不显示最小化按钮
            btnviewgoods.Enabled = false;
            labelname.Text = "用户：" + PublicValue.userid + " " + PublicValue.username;
            tableGOODS form2 = new tableGOODS();
            Showform_panel2(form2);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            keyvalue.Text = "";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            tableGOODS.g2.G_Show();
        }

        private void keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnviewgoods.Enabled = true;
        }
    }
}
