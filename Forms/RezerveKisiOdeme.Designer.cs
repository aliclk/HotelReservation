namespace HotelReservation.Forms
{
    partial class FrmRezerveKisi
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
            this.btnOdemeyiTamamla = new System.Windows.Forms.Button();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtKartIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKartNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.lblCikisTarihiOdeme = new System.Windows.Forms.Label();
            this.lblGirisTarihiOdeme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdemeyiTamamla
            // 
            this.btnOdemeyiTamamla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOdemeyiTamamla.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeyiTamamla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeyiTamamla.Location = new System.Drawing.Point(133, 551);
            this.btnOdemeyiTamamla.Name = "btnOdemeyiTamamla";
            this.btnOdemeyiTamamla.Size = new System.Drawing.Size(271, 53);
            this.btnOdemeyiTamamla.TabIndex = 20;
            this.btnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.btnOdemeyiTamamla.UseVisualStyleBackColor = false;
            this.btnOdemeyiTamamla.Click += new System.EventHandler(this.btnOdemeyiTamamla_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(23, 327);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(229, 26);
            this.lbl12.TabIndex = 21;
            this.lbl12.Text = "Kartın Üzerindeki İsim:";
            // 
            // txtKartIsim
            // 
            this.txtKartIsim.Location = new System.Drawing.Point(258, 319);
            this.txtKartIsim.Multiline = true;
            this.txtKartIsim.Name = "txtKartIsim";
            this.txtKartIsim.Size = new System.Drawing.Size(186, 34);
            this.txtKartIsim.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kart Numarası:";
            // 
            // txtKartNumarasi
            // 
            this.txtKartNumarasi.Location = new System.Drawing.Point(258, 370);
            this.txtKartNumarasi.Multiline = true;
            this.txtKartNumarasi.Name = "txtKartNumarasi";
            this.txtKartNumarasi.Size = new System.Drawing.Size(186, 34);
            this.txtKartNumarasi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Yıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cvc:";
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(258, 443);
            this.txtAy.Multiline = true;
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(65, 34);
            this.txtAy.TabIndex = 28;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(329, 443);
            this.txtYil.Multiline = true;
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(65, 34);
            this.txtYil.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kullanma Tarihi:";
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(258, 498);
            this.txtCvc.Multiline = true;
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(65, 34);
            this.txtCvc.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ödenecek Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(258, 275);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(0, 26);
            this.lblOdenecekTutar.TabIndex = 35;
            // 
            // lblCikisTarihiOdeme
            // 
            this.lblCikisTarihiOdeme.AutoSize = true;
            this.lblCikisTarihiOdeme.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikisTarihiOdeme.Location = new System.Drawing.Point(258, 233);
            this.lblCikisTarihiOdeme.Name = "lblCikisTarihiOdeme";
            this.lblCikisTarihiOdeme.Size = new System.Drawing.Size(0, 26);
            this.lblCikisTarihiOdeme.TabIndex = 36;
            // 
            // lblGirisTarihiOdeme
            // 
            this.lblGirisTarihiOdeme.AutoSize = true;
            this.lblGirisTarihiOdeme.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisTarihiOdeme.Location = new System.Drawing.Point(259, 192);
            this.lblGirisTarihiOdeme.Name = "lblGirisTarihiOdeme";
            this.lblGirisTarihiOdeme.Size = new System.Drawing.Size(0, 26);
            this.lblGirisTarihiOdeme.TabIndex = 37;
            // 
            // FrmRezerveKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 633);
            this.Controls.Add(this.lblGirisTarihiOdeme);
            this.Controls.Add(this.lblCikisTarihiOdeme);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCvc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKartNumarasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKartIsim);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.btnOdemeyiTamamla);
            this.Name = "FrmRezerveKisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezerveKisiOdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdemeyiTamamla;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox txtKartIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKartNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label lblCikisTarihiOdeme;
        private System.Windows.Forms.Label lblGirisTarihiOdeme;
    }
}