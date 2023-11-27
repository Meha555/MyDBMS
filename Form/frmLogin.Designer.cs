
namespace MyDBMS
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.textusername = new System.Windows.Forms.TextBox();
            this.title1 = new System.Windows.Forms.Label();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbtnuser = new System.Windows.Forms.RadioButton();
            this.rbtnadmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(166, 170);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(201, 25);
            this.textusername.TabIndex = 0;
            // 
            // title1
            // 
            this.title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("楷体", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.ForeColor = System.Drawing.Color.Blue;
            this.title1.Location = new System.Drawing.Point(161, 29);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(261, 30);
            this.title1.TabIndex = 1;
            this.title1.Text = "物资供应管理系统";
            // 
            // textpwd
            // 
            this.textpwd.Location = new System.Drawing.Point(166, 215);
            this.textpwd.Name = "textpwd";
            this.textpwd.PasswordChar = '*';
            this.textpwd.Size = new System.Drawing.Size(201, 25);
            this.textpwd.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(79, 172);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(69, 20);
            this.username.TabIndex = 3;
            this.username.Text = "用户名";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.Location = new System.Drawing.Point(79, 217);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(69, 20);
            this.pwd.TabIndex = 4;
            this.pwd.Text = "密  码";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlogin.Location = new System.Drawing.Point(79, 294);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(108, 53);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "登 录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnregister.Location = new System.Drawing.Point(259, 294);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(108, 53);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "注 册";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("宋体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.Location = new System.Drawing.Point(211, 82);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(76, 17);
            this.lbltime.TabIndex = 9;
            this.lbltime.Text = "当前日期";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // rbtnuser
            // 
            this.rbtnuser.AutoSize = true;
            this.rbtnuser.Checked = true;
            this.rbtnuser.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnuser.Location = new System.Drawing.Point(107, 259);
            this.rbtnuser.Name = "rbtnuser";
            this.rbtnuser.Size = new System.Drawing.Size(67, 27);
            this.rbtnuser.TabIndex = 12;
            this.rbtnuser.TabStop = true;
            this.rbtnuser.Text = "用 户";
            this.rbtnuser.UseVisualStyleBackColor = true;
            // 
            // rbtnadmin
            // 
            this.rbtnadmin.AutoSize = true;
            this.rbtnadmin.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnadmin.Location = new System.Drawing.Point(265, 259);
            this.rbtnadmin.Name = "rbtnadmin";
            this.rbtnadmin.Size = new System.Drawing.Size(79, 27);
            this.rbtnadmin.TabIndex = 13;
            this.rbtnadmin.Text = "管理员";
            this.rbtnadmin.UseVisualStyleBackColor = true;
            this.rbtnadmin.CheckedChanged += new System.EventHandler(this.rbtnadmin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "用户ID";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(166, 128);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(201, 25);
            this.textid.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreset.BackgroundImage")));
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(200, 304);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(45, 38);
            this.btnreset.TabIndex = 16;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "快捷登录：";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.ColumnWidth = 75;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(184, 356);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(173, 42);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 465);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.rbtnadmin);
            this.Controls.Add(this.rbtnuser);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textpwd);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLogin";
            this.Text = "登录/注册";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtnuser;
        private System.Windows.Forms.RadioButton rbtnadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

