namespace HotelReservation.Forms
{
    partial class FrmSifremiUnuttum
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
            this.lblSifremiUnuttumEmail = new System.Windows.Forms.Label();
            this.txtlblSifremiUnuttumEmail = new System.Windows.Forms.TextBox();
            this.txtlblSifremiUnuttumKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifremiUnuttumKullaniciAdi = new System.Windows.Forms.Label();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifremiUnuttumEmail
            // 
            this.lblSifremiUnuttumEmail.AutoSize = true;
            this.lblSifremiUnuttumEmail.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifremiUnuttumEmail.Location = new System.Drawing.Point(77, 145);
            this.lblSifremiUnuttumEmail.Name = "lblSifremiUnuttumEmail";
            this.lblSifremiUnuttumEmail.Size = new System.Drawing.Size(76, 25);
            this.lblSifremiUnuttumEmail.TabIndex = 0;
            this.lblSifremiUnuttumEmail.Text = "E-Mail:";
            // 
            // txtlblSifremiUnuttumEmail
            // 
            this.txtlblSifremiUnuttumEmail.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlblSifremiUnuttumEmail.Location = new System.Drawing.Point(159, 136);
            this.txtlblSifremiUnuttumEmail.Multiline = true;
            this.txtlblSifremiUnuttumEmail.Name = "txtlblSifremiUnuttumEmail";
            this.txtlblSifremiUnuttumEmail.Size = new System.Drawing.Size(214, 34);
            this.txtlblSifremiUnuttumEmail.TabIndex = 1;
            // 
            // txtlblSifremiUnuttumKullaniciAdi
            // 
            this.txtlblSifremiUnuttumKullaniciAdi.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlblSifremiUnuttumKullaniciAdi.Location = new System.Drawing.Point(159, 192);
            this.txtlblSifremiUnuttumKullaniciAdi.Multiline = true;
            this.txtlblSifremiUnuttumKullaniciAdi.Name = "txtlblSifremiUnuttumKullaniciAdi";
            this.txtlblSifremiUnuttumKullaniciAdi.Size = new System.Drawing.Size(214, 34);
            this.txtlblSifremiUnuttumKullaniciAdi.TabIndex = 2;
            // 
            // lblSifremiUnuttumKullaniciAdi
            // 
            this.lblSifremiUnuttumKullaniciAdi.AutoSize = true;
            this.lblSifremiUnuttumKullaniciAdi.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifremiUnuttumKullaniciAdi.Location = new System.Drawing.Point(26, 201);
            this.lblSifremiUnuttumKullaniciAdi.Name = "lblSifremiUnuttumKullaniciAdi";
            this.lblSifremiUnuttumKullaniciAdi.Size = new System.Drawing.Size(128, 25);
            this.lblSifremiUnuttumKullaniciAdi.TabIndex = 3;
            this.lblSifremiUnuttumKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifremiUnuttum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(159, 253);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(214, 40);
            this.btnSifremiUnuttum.TabIndex = 4;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 331);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.lblSifremiUnuttumKullaniciAdi);
            this.Controls.Add(this.txtlblSifremiUnuttumKullaniciAdi);
            this.Controls.Add(this.txtlblSifremiUnuttumEmail);
            this.Controls.Add(this.lblSifremiUnuttumEmail);
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifremiUnuttumEmail;
        private System.Windows.Forms.TextBox txtlblSifremiUnuttumEmail;
        private System.Windows.Forms.TextBox txtlblSifremiUnuttumKullaniciAdi;
        private System.Windows.Forms.Label lblSifremiUnuttumKullaniciAdi;
        private System.Windows.Forms.Button btnSifremiUnuttum;
    }
}