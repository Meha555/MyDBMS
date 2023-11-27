
namespace MyDBMS
{
    partial class Buylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buylist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnum = new System.Windows.Forms.Label();
            this.labelmoney = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelchoosed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 425);
            this.panel1.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclear.Location = new System.Drawing.Point(556, 364);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 47);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "清 空";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("宋体", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(674, 364);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 47);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "删 除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("华文中宋", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.Location = new System.Drawing.Point(560, 189);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(70, 23);
            this.labelname.TabIndex = 25;
            this.labelname.Text = "用户：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18.15126F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(580, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "我的购物车";
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Font = new System.Drawing.Font("华文中宋", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelnum.Location = new System.Drawing.Point(560, 234);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(90, 23);
            this.labelnum.TabIndex = 26;
            this.labelnum.Text = "订单数：";
            // 
            // labelmoney
            // 
            this.labelmoney.AutoSize = true;
            this.labelmoney.Font = new System.Drawing.Font("华文中宋", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelmoney.Location = new System.Drawing.Point(560, 281);
            this.labelmoney.Name = "labelmoney";
            this.labelmoney.Size = new System.Drawing.Size(90, 23);
            this.labelmoney.TabIndex = 27;
            this.labelmoney.Text = "总金额：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // labelchoosed
            // 
            this.labelchoosed.AutoSize = true;
            this.labelchoosed.Font = new System.Drawing.Font("华文中宋", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelchoosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelchoosed.Location = new System.Drawing.Point(553, 324);
            this.labelchoosed.Name = "labelchoosed";
            this.labelchoosed.Size = new System.Drawing.Size(88, 17);
            this.labelchoosed.TabIndex = 29;
            this.labelchoosed.Text = "当前未选择";
            // 
            // Buylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelchoosed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelmoney);
            this.Controls.Add(this.labelnum);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Buylist";
            this.Text = "我的购物车";
            this.Load += new System.EventHandler(this.Buylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.Label labelmoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelchoosed;
    }
}