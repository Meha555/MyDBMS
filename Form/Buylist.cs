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
    public partial class Buylist : Form
    {
        public static Buylist b2;//静态成员用于对外调用
        public Buylist()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            b2 = this;
        }

        public void Showform_panel1(Form form)//在Panel2中显示窗体
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

        private void Buylist_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;//不显示最大化按钮
            this.MinimizeBox = false;//不显示最小化按钮
            tablePOST form1 = new tablePOST();
            Showform_panel1(form1);
            string sql = "select * from POST where CID='" + PublicValue.userid + "'";
            tablePOST.p2.P_Search(sql);//用户只能查看自己的订单
            labelname.Text = "用户：" + PublicValue.userid + " " + PublicValue.username;
            Show_count();
            Show_sum();
        }

        private void btndelete_Click(object sender, EventArgs e)//删除按钮
        {
            try
            {
                string[] id_list = new string[3];
                id_list = tablePOST.p2.P_id();
                string id1, id2, id3;
                id1 = id_list[0];
                id2 = id_list[1];
                id3 = id_list[2];
                //弹出消息框，并获取消息框的返回值
                DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //如果消息框返回值是Yes，显示新窗体
                if (dr == DialogResult.Yes)
                {
                    DBconnect conn = new DBconnect();//实例化数据库连接
                    string sql = "delete from POST where CID='" + id1 + "'and WID='" + id2 + "'and GID='" + id3 + "'";
                    conn.Execute(sql);
                    conn.DBclose();
                }
                //如果消息框返回值是No，关闭当前窗体
                string sql2 = "select * from POST where CID='" + PublicValue.userid + "'";
                tablePOST.p2.P_Search(sql2);//用户只能查看自己的订单//刷新
            }
            catch
            {
                MessageBox.Show("请先在表格中选中要删除的记录！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Show_count()//计算总行数
        {
            DBconnect conn = new DBconnect();
            string sql = "select COUNT(*) from POST where CID='"+PublicValue.userid+"'";
            string row_num = "";
            IDataReader dc = conn.read(sql);//读取数据
            if (dc.Read())
            {
                row_num = dc[0].ToString();
            }
            labelnum.Text = "订单数：" + row_num;
            dc.Close();
            conn.DBclose();
        }

        public void Show_sum()//计算总金额
        {
            DBconnect conn = new DBconnect();
            string sql = "select SUM(MONEY) from POST where CID='" + PublicValue.userid + "'";
            string total_money = "";
            IDataReader dc = conn.read(sql);//读取数据
            if (dc.Read())
            {
                total_money = dc[0].ToString();
            }
            labelmoney.Text = "总金额：" + total_money;
            dc.Close();
            conn.DBclose();
        }

        private void btnclear_Click(object sender, EventArgs e)//用户只能清除自己的订单
        {
            DialogResult dr = MessageBox.Show("是否清空？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DBconnect conn = new DBconnect();
                string sql = "delete from POST where CID='" + PublicValue.userid + "'";
                IDataReader dc = conn.read(sql);//读取数据
                conn.Execute(sql);
                Show_count();
                Show_sum();
                string sql2 = "select * from POST where CID='" + PublicValue.userid + "'";
                tablePOST.p2.P_Search(sql2);//用户只能查看自己的订单
                dc.Close();
                conn.DBclose();
            }
        }
    }
}
