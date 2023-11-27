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
    public partial class S_edit : Form
    {
        public static S_edit s1;//静态成员用于对外调用
        public S_edit()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            s1 = this;//初始化
        }
        public void Clearall()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        public bool Addnew()//因为每个表属性数目不一样，所以在每个表单独的编辑窗体写Add方法
        {
            DBconnect conn = new DBconnect();//连接数据库实例化
            string sql = "insert into STORE(SID,SNAME,ADDRESS,TEL,KIND) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
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

        public bool Updateold()//因为每个表属性数目不一样，所以在每个表单独的编辑窗体写Update方法
        {
            DBconnect conn = new DBconnect();//连接数据库实例化
            string sql = "update STORE set";
            //文本框不为空表示值需要修改
            bool flag = false;//false表示只有一个值表达式，true表示有2个或2个以上值表达式
            if (textBox1.Text != "")
            {
                sql += " SID='" + textBox1.Text + "'";
                flag = true;
            }
            if (textBox2.Text != "")
            {
                if(flag==false) sql += " SNAME='" + textBox2.Text + "'";
                else sql += ",SNAME='" + textBox2.Text + "'";
                flag = true;
            }
            if (textBox3.Text != "")
            {
                if (flag == false) sql += " ADDRESS='" + textBox3.Text + "'";
                else sql += ",ADDRESS='" + textBox3.Text + "'";
                flag = true;
            }
            if (textBox4.Text != "")
            {
                if (flag == false) sql += " TEL='" + textBox4.Text + "'";
                else sql += ",TEL='" + textBox4.Text + "'";
                flag = true;
            }
            if (textBox5.Text != "")
            {
                if (flag == false) sql += " KIND='" + textBox5.Text + "'";
                else sql += ",KIND='" + textBox5.Text + "'";
                flag = true;
            }
            sql += " where SID='"+textBox1.Text+"'";
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
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
