
namespace MyDBMS
{
    partial class frmHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.增添功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增添功能ToolStripMenuItem,
            this.删除功能ToolStripMenuItem,
            this.修改功能ToolStripMenuItem,
            this.查询功能ToolStripMenuItem,
            this.用户权限ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 增添功能ToolStripMenuItem
            // 
            this.增添功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.增添功能ToolStripMenuItem.Name = "增添功能ToolStripMenuItem";
            this.增添功能ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.增添功能ToolStripMenuItem.Text = "增添功能";
            this.增添功能ToolStripMenuItem.Click += new System.EventHandler(this.增添功能ToolStripMenuItem_Click);
            // 
            // 删除功能ToolStripMenuItem
            // 
            this.删除功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.删除功能ToolStripMenuItem.Name = "删除功能ToolStripMenuItem";
            this.删除功能ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.删除功能ToolStripMenuItem.Text = "删除功能";
            this.删除功能ToolStripMenuItem.Click += new System.EventHandler(this.删除功能ToolStripMenuItem_Click);
            // 
            // 修改功能ToolStripMenuItem
            // 
            this.修改功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改功能ToolStripMenuItem.Name = "修改功能ToolStripMenuItem";
            this.修改功能ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.修改功能ToolStripMenuItem.Text = "更改功能";
            this.修改功能ToolStripMenuItem.Click += new System.EventHandler(this.更改功能ToolStripMenuItem_Click);
            // 
            // 查询功能ToolStripMenuItem
            // 
            this.查询功能ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询功能ToolStripMenuItem.Name = "查询功能ToolStripMenuItem";
            this.查询功能ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.查询功能ToolStripMenuItem.Text = "查询功能";
            this.查询功能ToolStripMenuItem.Click += new System.EventHandler(this.查询功能ToolStripMenuItem_Click);
            // 
            // 用户权限ToolStripMenuItem
            // 
            this.用户权限ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户权限ToolStripMenuItem.Name = "用户权限ToolStripMenuItem";
            this.用户权限ToolStripMenuItem.Size = new System.Drawing.Size(106, 31);
            this.用户权限ToolStripMenuItem.Text = "用户权限";
            this.用户权限ToolStripMenuItem.Click += new System.EventHandler(this.用户权限ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHelp";
            this.Text = "使用帮助";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增添功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户权限ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}