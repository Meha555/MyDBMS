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
    public partial class P_edit : Form
    {
        public static P_edit p1;//静态成员用于对外调用
        public P_edit()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            p1 = this;
        }

        public void Clearall()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public bool Addnew()//因为每个表属性数目不一样，所以在每个表单独的编辑窗体写Add方法
        {
            DBconnect conn = new DBconnect();//连接数据库实例化
            string sql = "insert into POST(CID,WID,GID,MONEY) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (conn.Execute(sql) != -1)
                {
                    //MessageBox.Show("添加成功");
                    return true;
                }
                else
                {
                    //MessageBox.Show("添加失败");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("非法输入，值不能全为空");
                return false;
            }
        }

        public bool Updateold()//因为每个表属性数目不一样，所以在每个表单独的编辑窗体写Add方法
        {
            DBconnect conn = new DBconnect();//连接数据库实例化
            string sql = "";
            string head = "";
            string tail = "";
            //文本框不为空表示值需要修改
            bool flag = false;//false表示只有一个值表达式，true表示有2个或2个以上值表达式
            if (textBox1.Text != "")
            {
                head += " CID='" + textBox1.Text + "'";
                flag = true;
            }
            if (textBox2.Text != "")
            {
                if (flag == false) head += " WID='" + textBox2.Text + "'";
                else head += ",WID='" + textBox2.Text + "'";
                flag = true;
            }
            if (textBox3.Text != "")
            {
                if (flag == false) head += " GID='" + textBox3.Text + "'";
                else head += ",GID='" + textBox3.Text + "'";
                flag = true;
            }
            if (textBox4.Text != "")
            {
                if (flag == false) head += " MONEY='" + textBox4.Text + "'";
                else head += ",MONEY='" + textBox4.Text + "'";
                flag = true;
            }
            string[] id_list = new string[3];
            string id1, id2, id3;
            id_list = tablePOST.p2.P_id();
            id1 = id_list[0];
            id2 = id_list[1];
            id3 = id_list[2];
            tail = "CID='" + id1 + "'and WID='" + id2 + "'and GID='" + id3 + "'";
            sql = "update POST set" + head + " where " + tail;
            MessageBox.Show(sql);
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("值全为空表示不做修改");
                return false;
            }
            else
            {
                if (conn.Execute(sql) != -1)
                {
                    //MessageBox.Show("添加成功");
                    return true;
                }
                else
                {
                    //MessageBox.Show("添加失败");
                    return false;
                }
            }
        }
    }
}
