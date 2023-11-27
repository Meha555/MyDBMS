
namespace MyDBMS
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnviewgoods = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.btnviewlist = new System.Windows.Forms.Button();
            this.labelchoosed = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keywords = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnviewgoods
            // 
            this.btnviewgoods.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnviewgoods.Location = new System.Drawing.Point(672, 321);
            this.btnviewgoods.Name = "btnviewgoods";
            this.btnviewgoods.Size = new System.Drawing.Size(104, 44);
            this.btnviewgoods.TabIndex = 10;
            this.btnviewgoods.Text = "查 询";
            this.btnviewgoods.UseVisualStyleBackColor = true;
            this.btnviewgoods.Click += new System.EventHandler(this.btnviewgoods_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.Aqua;
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuy.Location = new System.Drawing.Point(808, 383);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(104, 44);
            this.btnbuy.TabIndex = 11;
            this.btnbuy.Text = "购 买";
            this.btnbuy.UseVisualStyleBackColor = false;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // btnviewlist
            // 
            this.btnviewlist.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnviewlist.Location = new System.Drawing.Point(672, 383);
            this.btnviewlist.Name = "btnviewlist";
            this.btnviewlist.Size = new System.Drawing.Size(104, 44);
            this.btnviewlist.TabIndex = 12;
            this.btnviewlist.Text = "购物车";
            this.btnviewlist.UseVisualStyleBackColor = true;
            this.btnviewlist.Click += new System.EventHandler(this.btnviewlist_Click);
            // 
            // labelchoosed
            // 
            this.labelchoosed.AutoSize = true;
            this.labelchoosed.Font = new System.Drawing.Font("华文中宋", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelchoosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelchoosed.Location = new System.Drawing.Point(731, 246);
            this.labelchoosed.Name = "labelchoosed";
            this.labelchoosed.Size = new System.Drawing.Size(120, 24);
            this.labelchoosed.TabIndex = 13;
            this.labelchoosed.Text = "当前未选择";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclear.Location = new System.Drawing.Point(808, 321);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 44);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "清 空";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(696, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "物资采购平台";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 426);
            this.panel2.TabIndex = 18;
            // 
            // keyvalue
            // 
            this.keyvalue.Location = new System.Drawing.Point(810, 191);
            this.keyvalue.Name = "keyvalue";
            this.keyvalue.Size = new System.Drawing.Size(102, 25);
            this.keyvalue.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(689, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "关键字值";
            // 
            // keywords
            // 
            this.keywords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keywords.FormattingEnabled = true;
            this.keywords.Items.AddRange(new object[] {
            "ID",
            "名称",
            "所属仓库",
            "物资类型"});
            this.keywords.Location = new System.Drawing.Point(810, 144);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(102, 23);
            this.keywords.TabIndex = 20;
            this.keywords.SelectedIndexChanged += new System.EventHandler(this.keywords_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(689, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "关键字名称";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("华文中宋", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.Location = new System.Drawing.Point(689, 95);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(70, 23);
            this.labelname.TabIndex = 23;
            this.labelname.Text = "用户：";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefresh.BackgroundImage")));
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Location = new System.Drawing.Point(645, 13);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(45, 41);
            this.btnrefresh.TabIndex = 24;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.keyvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keywords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.labelchoosed);
            this.Controls.Add(this.btnviewlist);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnviewgoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUser";
            this.Text = "物资供应管理系统[普通用户]";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnviewgoods;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Button btnviewlist;
        public System.Windows.Forms.Label labelchoosed;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox keyvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox keywords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button btnrefresh;
    }
}