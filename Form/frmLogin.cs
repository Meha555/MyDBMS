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
    public partial class frmLogin : Form
    {
        public string[] user_ID = new string[10];
        public string[] user_name = new string[10];
        public string[] codes = new string[10];
        public string[] type = new string[10];
        public int user_ID_count = 0;

        public frmLogin()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            user_ID_count = 3;
            user_ID[0] = "2022001"; codes[0] = "hzy12345"; user_name[0] = "黄祯彦"; type[0] = "0";
            user_ID[1] = "2022002"; codes[1] = "hzb54321"; user_name[1] = "韩杼彬"; type[1] = "0";
            user_ID[2] = "admin"; codes[2] = "admin123"; user_name[2] = "admin"; type[2] = "1";
            for (int i = 0; i < user_ID_count; i++)
            {
                checkedListBox1.Items.Add(user_name[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "登录/注册";
            lbltime.Text = DateTime.Now.ToLongDateString();
            this.MaximizeBox = false;//不显示最大化按钮
            this.MinimizeBox = false;//不显示最小化按钮
            textid.Focus();//设置焦点在id上
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textid.Text != "" && textusername.Text != "" && textpwd.Text != "")
            {
                if (rbtnuser.Checked == true)
                {
                    DBconnect loginconn = new DBconnect();//连接数据库实例化
                    string sql = "select * from CUSTOMER where CID='" + textid.Text + "' and CNAME='" + textusername.Text + "' and PWD='" + textpwd.Text + "'";//顾客表中查找该用户，显示欢迎页面
                    IDataReader dc = loginconn.read(sql);//查找用户
                    if (dc.Read() == true)
                    {
                        PublicValue.permission = false;
                        PublicValue.userid = textid.Text;
                        PublicValue.username = textusername.Text;
                        MessageBox.Show("用户" + textusername.Text + "登录成功！", "欢迎", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Hide();//隐藏此界面
                        frmUser form = new frmUser();//启动用户界面
                        form.ShowDialog();
                        this.Show();
                        //this.Dispose();//释放所有资源
                    }
                    else
                    {
                        MessageBox.Show("信息有误，请重新输入或注册！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textid.Text = "";
                        textusername.Text = "";
                        textpwd.Text = "";
                    }
                }
                else if (rbtnadmin.Checked == true && textid.Text == "admin" && textusername.Text == "admin" && textpwd.Text == "admin123")//管理员固定账号
                {
                    PublicValue.permission = true;
                    MessageBox.Show("管理员admin登录成功！", "欢迎", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();//隐藏此界面
                    frmAdmin form = new frmAdmin();//启动管理界面
                    form.ShowDialog();
                    this.Show();
                    //this.Dispose();//释放所有资源
                }
                else
                {
                    MessageBox.Show("信息有误，请重新输入或注册！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textid.Text = "";
                    textusername.Text = "";
                    textpwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("存在空项，请填写完整信息！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (rbtnuser.Checked == true && rbtnadmin.Checked == false)
            {
                if (textid.Text != "" && textusername.Text != "" && textpwd.Text != "")
                {
                    DBconnect loginconn = new DBconnect();//连接数据库实例化
                    string sql = "insert into CUSTOMER(CID,CNAME,PWD) values('" + textid.Text + "','" + textusername.Text + "','" + textpwd.Text + "')";
                    if (loginconn.Execute(sql) != -1)
                    {
                        MessageBox.Show("用户" + textusername.Text + "注册成功，请重新登录！");
                    }
                    else
                    {
                        MessageBox.Show("注册失败，请重试！");
                    }
                }
                else
                {
                    MessageBox.Show("信息有误，请重新输入！");
                    textid.Text = "";
                    textusername.Text = "";
                    textpwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("不允许注册管理员账号！");
            }
        }

        private void rbtnadmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnadmin.Checked == true) btnregister.Enabled = false;
            else btnregister.Enabled = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            textusername.Text = "";
            textpwd.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = checkedListBox1.SelectedItem.ToString();
            textusername.Text = temp;
            textpwd.Text = codes[checkedListBox1.SelectedIndex];
            textid.Text = user_ID[checkedListBox1.SelectedIndex];
            if (type[checkedListBox1.SelectedIndex] == "0") rbtnuser.Checked = true;
            else rbtnadmin.Checked = true;
        }
    }
    public class PublicValue //全局变量，用于用户组功能
    {
        public static bool permission;//true为管理员，false为用户
        public static string userid;
        public static string username;
    }//这段代码必须放在Form类下方。否则编译器会识别不到窗体类，从而将其显示为.cs文件
}
