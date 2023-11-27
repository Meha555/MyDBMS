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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            label1.Visible = false;
        }

        private void 增添功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "使用方法：\n" +
                "1.在左侧“增添/更改窗口”填写值，\n" +
                "  需要符合数据库完整性约束\n" +
                "2.点击“增添”按钮";
        }

        private void 删除功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "使用方法：\n" +
                "1.在右侧“查询/删除窗口”数据表中选择要删除的行\n" +
                "2.点击“删除”按钮";
        }

        private void 更改功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "使用方法：\n" +
                "1.在左侧“增添/更改窗口”填写值，\n" +
                "  需要符合数据库完整性约束\n" +
                "2.点击“更改”按钮";
        }

        private void 查询功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "使用方法：\n" +
                "1.在右侧“查询/删除窗口”按照\n" +
                "  关系表名称-关键字名称-关键字值的顺序选择或填写，\n" +
                "  填写值需要符合数据库完整性约束\n" +
                "2.点击“查询”按钮";
        }

        private void 用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "说明：\n" +
                "分为两种用户：\n" +
                "1.管理员：拥有全部功能\n" +
                "2.普通用户：仅开放查看购物车和下单功能\n";
        }
    }
}
