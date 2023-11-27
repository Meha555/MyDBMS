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
    public partial class tableCUSTOMER : Form
    {
        public static tableCUSTOMER c2;//静态成员用于对外调用
        string id = "NULL";
        public tableCUSTOMER()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            c2 = this;
        }

        private void tableCUSTOMER_Load(object sender, EventArgs e)
        {
            C_Show();
        }
        public void C_Search(string sql)
        {
            dataGridView1.Rows.Clear();//清空原有数据
            DBconnect conn = new DBconnect();//数据库连接对象
            IDataReader dc = conn.read(sql);//读取数据
            while (dc.Read())//按行读入数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            conn.DBclose();
        }
        public void C_Show()
        {
            dataGridView1.Rows.Clear();//清空原有数据
            DBconnect conn = new DBconnect();//数据库连接对象
            string sql = "select * from CUSTOMER";
            IDataReader dc = conn.read(sql);//读取数据
            while (dc.Read())//按行读入数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            conn.DBclose();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            try//防止出现“索引超出范围。必须为非负值并小于集合大小。”的报错
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                frmAdmin.f1.labelselected.Text = "当前选择：" + id;
                //MessageBox.Show(id);
            }
            catch
            {
                MessageBox.Show("请先在表格中选中要删除的记录！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string C_id()//返回选中的元组ID，因为删除操作需要通过候选键对元组进行定位
        {
            return id;
        }
    }
}
