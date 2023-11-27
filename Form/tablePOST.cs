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
    public partial class tablePOST : Form
    {
        public static tablePOST p2;//静态成员用于对外调用
        string id1 = "空";
        string id2 = "空";
        string id3 = "空";
        public tablePOST()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            p2 = this;//初始化
        }

        private void tablePOST_Load(object sender, EventArgs e)
        {
            P_Show();//初始查询
        }

        public void P_Show()
        {
            dataGridView1.Rows.Clear();//清空原有数据
            DBconnect conn = new DBconnect();//数据库连接对象
            string sql = "select * from POST";
            IDataReader dc = conn.read(sql);//读取数据
            while (dc.Read())//按行读入数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            conn.DBclose();
        }

        public void P_Search(string sql)
        {
            dataGridView1.Rows.Clear();//清空原有数据
            DBconnect conn = new DBconnect();//数据库连接对象
            IDataReader dc = conn.read(sql);//读取数据
            while (dc.Read())//按行读入数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            conn.DBclose();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)//点击事件获取id
        {
            try//防止出现“索引超出范围。必须为非负值并小于集合大小。”的报错
            {
                id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                id2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                id3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                switch (PublicValue.permission)
                {
                    case true:
                        {
                            frmAdmin.f1.labelselected.Text = "当前选择：" + id1 + " " + id2 + " " + id3;
                            break;
                        }
                    case false:
                        {
                            Buylist.b2.labelchoosed.Text = "当前选择：" + id1 + " " + id2 + " " + id3;
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("请先在表格中选中要删除的记录！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] P_id()//返回选中的元组ID，因为删除操作需要通过候选键对元组进行定位
        {
            string[] id_list = new string[3]{ "0","0","0"};
            id_list[0] = id1;
            id_list[1] = id2;
            id_list[2] = id3;
            return id_list;
        }

    }
}
