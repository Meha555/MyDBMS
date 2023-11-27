
namespace MyDBMS
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhelp = new System.Windows.Forms.Button();
            this.labelselected = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.keyvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keywords = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabletype = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tablename = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.labelopinfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltablename = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnhelp);
            this.groupBox1.Controls.Add(this.labelselected);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.keyvalue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.keywords);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tabletype);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.tablename);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(256, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询/删除窗口";
            // 
            // btnhelp
            // 
            this.btnhelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhelp.Location = new System.Drawing.Point(542, 37);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(64, 47);
            this.btnhelp.TabIndex = 14;
            this.btnhelp.Text = "使用帮助";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // labelselected
            // 
            this.labelselected.AutoSize = true;
            this.labelselected.Font = new System.Drawing.Font("华文中宋", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelselected.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelselected.Location = new System.Drawing.Point(289, 71);
            this.labelselected.Name = "labelselected";
            this.labelselected.Size = new System.Drawing.Size(117, 20);
            this.labelselected.TabIndex = 13;
            this.labelselected.Text = "未选择任何项";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 468);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(495, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 11;
            // 
            // keyvalue
            // 
            this.keyvalue.Location = new System.Drawing.Point(376, 33);
            this.keyvalue.Name = "keyvalue";
            this.keyvalue.Size = new System.Drawing.Size(100, 27);
            this.keyvalue.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "关键字值";
            // 
            // keywords
            // 
            this.keywords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keywords.FormattingEnabled = true;
            this.keywords.Location = new System.Drawing.Point(138, 69);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(121, 25);
            this.keywords.TabIndex = 8;
            this.keywords.SelectedIndexChanged += new System.EventHandler(this.keywords_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(737, 37);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 47);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "删 除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "关键字名称";
            // 
            // tabletype
            // 
            this.tabletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabletype.FormattingEnabled = true;
            this.tabletype.Items.AddRange(new object[] {
            "仓库",
            "物资",
            "配送员",
            "顾客",
            "配送"});
            this.tabletype.Location = new System.Drawing.Point(138, 34);
            this.tabletype.Name = "tabletype";
            this.tabletype.Size = new System.Drawing.Size(121, 25);
            this.tabletype.TabIndex = 6;
            this.tabletype.SelectedIndexChanged += new System.EventHandler(this.tabletype_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsearch.Location = new System.Drawing.Point(627, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(104, 47);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "查 询";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tablename
            // 
            this.tablename.AutoSize = true;
            this.tablename.Location = new System.Drawing.Point(24, 38);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(98, 17);
            this.tablename.TabIndex = 0;
            this.tablename.Text = "关系表名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btnchange);
            this.groupBox2.Controls.Add(this.labelopinfo);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.labeltablename);
            this.groupBox2.Controls.Add(this.btninsert);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 572);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "增添/更改窗口";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclear.Location = new System.Drawing.Point(6, 457);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(77, 49);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "清 空";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // btnchange
            // 
            this.btnchange.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnchange.Location = new System.Drawing.Point(6, 513);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(104, 44);
            this.btnchange.TabIndex = 17;
            this.btnchange.Text = "更 改";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // labelopinfo
            // 
            this.labelopinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelopinfo.AutoSize = true;
            this.labelopinfo.Font = new System.Drawing.Font("华文琥珀", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelopinfo.Location = new System.Drawing.Point(122, 467);
            this.labelopinfo.Name = "labelopinfo";
            this.labelopinfo.Size = new System.Drawing.Size(90, 27);
            this.labelopinfo.TabIndex = 15;
            this.labelopinfo.Text = "无操作";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 374);
            this.panel1.TabIndex = 14;
            // 
            // labeltablename
            // 
            this.labeltablename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltablename.AutoSize = true;
            this.labeltablename.Font = new System.Drawing.Font("楷体", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltablename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labeltablename.Location = new System.Drawing.Point(67, 37);
            this.labeltablename.Name = "labeltablename";
            this.labeltablename.Size = new System.Drawing.Size(137, 30);
            this.labeltablename.TabIndex = 13;
            this.labeltablename.Text = "数据库名";
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninsert.Location = new System.Drawing.Point(127, 513);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(104, 44);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "增 添";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAdmin";
            this.Text = "物资供应管理系统[管理员]";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label tablename;
        private System.Windows.Forms.ComboBox tabletype;
        private System.Windows.Forms.TextBox keyvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label labeltablename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelopinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox keywords;
        public System.Windows.Forms.Label labelselected;//设成公有以便在table窗体中更改
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnhelp;
    }
}