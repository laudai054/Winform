
namespace CongTruNhanChia
{
    partial class CongTruNhanChia
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
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.butc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butt = new System.Windows.Forms.Button();
            this.butchia = new System.Windows.Forms.Button();
            this.butn = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(118, 37);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(65, 13);
            this.a.TabIndex = 0;
            this.a.Text = "Số thứ nhất:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(118, 63);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(58, 13);
            this.b.TabIndex = 1;
            this.b.Text = "Số thứ hai:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(192, 34);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(242, 20);
            this.txta.TabIndex = 2;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(192, 60);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(242, 20);
            this.txtb.TabIndex = 8;
            // 
            // butc
            // 
            this.butc.Location = new System.Drawing.Point(192, 86);
            this.butc.Name = "butc";
            this.butc.Size = new System.Drawing.Size(56, 23);
            this.butc.TabIndex = 4;
            this.butc.Text = "Cộng";
            this.butc.UseVisualStyleBackColor = true;
            this.butc.Click += new System.EventHandler(this.butc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kết quả:";
            // 
            // butt
            // 
            this.butt.Location = new System.Drawing.Point(254, 86);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(56, 23);
            this.butt.TabIndex = 7;
            this.butt.Text = "Trừ";
            this.butt.UseVisualStyleBackColor = true;
            this.butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // butchia
            // 
            this.butchia.Location = new System.Drawing.Point(378, 86);
            this.butchia.Name = "butchia";
            this.butchia.Size = new System.Drawing.Size(56, 23);
            this.butchia.TabIndex = 9;
            this.butchia.Text = "Chia";
            this.butchia.UseVisualStyleBackColor = true;
            this.butchia.Click += new System.EventHandler(this.butchia_Click);
            // 
            // butn
            // 
            this.butn.Location = new System.Drawing.Point(316, 86);
            this.butn.Name = "butn";
            this.butn.Size = new System.Drawing.Size(56, 23);
            this.butn.TabIndex = 10;
            this.butn.Text = "Nhân";
            this.butn.UseVisualStyleBackColor = true;
            this.butn.Click += new System.EventHandler(this.butn_Click);
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(189, 113);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(13, 13);
            this.ketqua.TabIndex = 11;
            this.ketqua.Text = "0";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(359, 143);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 12;
            this.close.Text = "Đóng";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 193);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.butn);
            this.Controls.Add(this.butchia);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button butc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt;
        private System.Windows.Forms.Button butchia;
        private System.Windows.Forms.Button butn;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Button close;
    }
}

