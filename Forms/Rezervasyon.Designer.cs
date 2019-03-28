namespace HotelReservation.Forms
{
    partial class FrmRezervasyon
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
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.flpOdalarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxOdaTipi = new System.Windows.Forms.ComboBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblOtelAdiRzv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUyeOl = new System.Windows.Forms.Panel();
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.LlblCikisYap = new System.Windows.Forms.LinkLabel();
            this.LlblUyeOl = new System.Windows.Forms.LinkLabel();
            this.LlblGirisYap = new System.Windows.Forms.LinkLabel();
            this.pnlUyeOl.SuspendLayout();
            this.pnlCikisYap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAra
            // 
            this.tbxAra.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAra.Location = new System.Drawing.Point(59, 24);
            this.tbxAra.Multiline = true;
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(802, 54);
            this.tbxAra.TabIndex = 0;
            this.tbxAra.Text = "Örn:İstanbul";
            this.tbxAra.Click += new System.EventHandler(this.tbxAra_click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAra.Location = new System.Drawing.Point(867, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(140, 54);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // flpOdalarContainer
            // 
            this.flpOdalarContainer.AutoScroll = true;
            this.flpOdalarContainer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flpOdalarContainer.Location = new System.Drawing.Point(12, 104);
            this.flpOdalarContainer.Name = "flpOdalarContainer";
            this.flpOdalarContainer.Size = new System.Drawing.Size(1076, 427);
            this.flpOdalarContainer.TabIndex = 8;
            // 
            // cbxOdaTipi
            // 
            this.cbxOdaTipi.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOdaTipi.FormattingEnabled = true;
            this.cbxOdaTipi.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Lux",
            "King",
            "Suit"});
            this.cbxOdaTipi.Location = new System.Drawing.Point(876, 567);
            this.cbxOdaTipi.Name = "cbxOdaTipi";
            this.cbxOdaTipi.Size = new System.Drawing.Size(212, 30);
            this.cbxOdaTipi.TabIndex = 5;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGirisTarihi.Location = new System.Drawing.Point(101, 562);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(282, 35);
            this.dtpGirisTarihi.TabIndex = 13;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCikisTarihi.Location = new System.Drawing.Point(469, 562);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(282, 35);
            this.dtpCikisTarihi.TabIndex = 14;
            // 
            // lblOtelAdiRzv
            // 
            this.lblOtelAdiRzv.AutoSize = true;
            this.lblOtelAdiRzv.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdiRzv.Location = new System.Drawing.Point(402, 571);
            this.lblOtelAdiRzv.Name = "lblOtelAdiRzv";
            this.lblOtelAdiRzv.Size = new System.Drawing.Size(61, 26);
            this.lblOtelAdiRzv.TabIndex = 15;
            this.lblOtelAdiRzv.Text = "Çıkış:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giriş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oda Tipi:";
            // 
            // pnlUyeOl
            // 
            this.pnlUyeOl.Controls.Add(this.LlblUyeOl);
            this.pnlUyeOl.Controls.Add(this.LlblGirisYap);
            this.pnlUyeOl.Location = new System.Drawing.Point(39, 618);
            this.pnlUyeOl.Name = "pnlUyeOl";
            this.pnlUyeOl.Size = new System.Drawing.Size(215, 50);
            this.pnlUyeOl.TabIndex = 18;
            // 
            // pnlCikisYap
            // 
            this.pnlCikisYap.Controls.Add(this.LlblCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(39, 618);
            this.pnlCikisYap.Name = "pnlCikisYap";
            this.pnlCikisYap.Size = new System.Drawing.Size(213, 50);
            this.pnlCikisYap.TabIndex = 19;
            // 
            // LlblCikisYap
            // 
            this.LlblCikisYap.AutoSize = true;
            this.LlblCikisYap.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblCikisYap.Location = new System.Drawing.Point(56, 16);
            this.LlblCikisYap.Name = "LlblCikisYap";
            this.LlblCikisYap.Size = new System.Drawing.Size(102, 25);
            this.LlblCikisYap.TabIndex = 1;
            this.LlblCikisYap.TabStop = true;
            this.LlblCikisYap.Text = "Çıkış Yap";
            this.LlblCikisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblCikisYap_LinkClicked);
            // 
            // LlblUyeOl
            // 
            this.LlblUyeOl.AutoSize = true;
            this.LlblUyeOl.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblUyeOl.Location = new System.Drawing.Point(15, 11);
            this.LlblUyeOl.Name = "LlblUyeOl";
            this.LlblUyeOl.Size = new System.Drawing.Size(78, 25);
            this.LlblUyeOl.TabIndex = 2;
            this.LlblUyeOl.TabStop = true;
            this.LlblUyeOl.Text = "Üye Ol";
            this.LlblUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblUyeOl_LinkClicked);
            // 
            // LlblGirisYap
            // 
            this.LlblGirisYap.AutoSize = true;
            this.LlblGirisYap.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblGirisYap.Location = new System.Drawing.Point(109, 11);
            this.LlblGirisYap.Name = "LlblGirisYap";
            this.LlblGirisYap.Size = new System.Drawing.Size(103, 25);
            this.LlblGirisYap.TabIndex = 1;
            this.LlblGirisYap.TabStop = true;
            this.LlblGirisYap.Text = "Giriş Yap";
            this.LlblGirisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblGirisYap_LinkClicked);
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 693);
            this.Controls.Add(this.pnlUyeOl);
            this.Controls.Add(this.pnlCikisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOtelAdiRzv);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.cbxOdaTipi);
            this.Controls.Add(this.flpOdalarContainer);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.tbxAra);
            this.Name = "FrmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.FrmRezervasyon_Load);
            this.pnlUyeOl.ResumeLayout(false);
            this.pnlUyeOl.PerformLayout();
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.FlowLayoutPanel flpOdalarContainer;
        private System.Windows.Forms.ComboBox cbxOdaTipi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label lblOtelAdiRzv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUyeOl;
        private System.Windows.Forms.LinkLabel LlblUyeOl;
        private System.Windows.Forms.LinkLabel LlblGirisYap;
        private System.Windows.Forms.Panel pnlCikisYap;
        private System.Windows.Forms.LinkLabel LlblCikisYap;
    }
}