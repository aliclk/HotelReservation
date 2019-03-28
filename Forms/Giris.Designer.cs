namespace HotelReservation.Forms
{
    partial class FrmGirisEkrani
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.chbxBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(44, 207);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(148, 26);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(121, 265);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(71, 26);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(198, 201);
            this.tbxKullaniciAdi.Multiline = true;
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(191, 32);
            this.tbxKullaniciAdi.TabIndex = 4;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSifre.Location = new System.Drawing.Point(198, 259);
            this.tbxSifre.Multiline = true;
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(191, 32);
            this.tbxSifre.TabIndex = 5;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGiris.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(49, 367);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(170, 46);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // chbxBeniHatirla
            // 
            this.chbxBeniHatirla.AutoSize = true;
            this.chbxBeniHatirla.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxBeniHatirla.Location = new System.Drawing.Point(198, 307);
            this.chbxBeniHatirla.Name = "chbxBeniHatirla";
            this.chbxBeniHatirla.Size = new System.Drawing.Size(159, 30);
            this.chbxBeniHatirla.TabIndex = 7;
            this.chbxBeniHatirla.Text = "Beni Hatırla";
            this.chbxBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(225, 367);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(170, 46);
            this.btnSifremiUnuttum.TabIndex = 8;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // FrmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 477);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.chbxBeniHatirla);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "FrmGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chbxBeniHatirla;
        private System.Windows.Forms.Button btnSifremiUnuttum;
    }
}