namespace HotelReservation.CustomControls
{
    partial class OdaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOtelAdi = new System.Windows.Forms.Label();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblYildiz = new System.Windows.Forms.Label();
            this.lblOdaFiyat = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtelAdi
            // 
            this.lblOtelAdi.AutoSize = true;
            this.lblOtelAdi.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdi.Location = new System.Drawing.Point(19, 42);
            this.lblOtelAdi.Name = "lblOtelAdi";
            this.lblOtelAdi.Size = new System.Drawing.Size(128, 37);
            this.lblOtelAdi.TabIndex = 18;
            this.lblOtelAdi.Text = "Otel Adı";
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaTipi.Location = new System.Drawing.Point(19, 100);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(64, 26);
            this.lblOdaTipi.TabIndex = 19;
            this.lblOdaTipi.Text = "Single";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(19, 150);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(64, 26);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(19, 221);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(143, 26);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "0532654879";
            // 
            // lblYildiz
            // 
            this.lblYildiz.AutoSize = true;
            this.lblYildiz.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYildiz.Location = new System.Drawing.Point(924, 24);
            this.lblYildiz.Name = "lblYildiz";
            this.lblYildiz.Size = new System.Drawing.Size(104, 55);
            this.lblYildiz.TabIndex = 22;
            this.lblYildiz.Text = "*****";
            // 
            // lblOdaFiyat
            // 
            this.lblOdaFiyat.AutoSize = true;
            this.lblOdaFiyat.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaFiyat.Location = new System.Drawing.Point(941, 100);
            this.lblOdaFiyat.Name = "lblOdaFiyat";
            this.lblOdaFiyat.Size = new System.Drawing.Size(88, 26);
            this.lblOdaFiyat.TabIndex = 23;
            this.lblOdaFiyat.Text = "300 TL";
            // 
            // btnKirala
            // 
            this.btnKirala.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKirala.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKirala.Location = new System.Drawing.Point(889, 193);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(140, 54);
            this.btnKirala.TabIndex = 24;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = false;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // OdaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.lblOdaFiyat);
            this.Controls.Add(this.lblYildiz);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblOdaTipi);
            this.Controls.Add(this.lblOtelAdi);
            this.Name = "OdaItem";
            this.Size = new System.Drawing.Size(1043, 287);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAdi;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblYildiz;
        private System.Windows.Forms.Label lblOdaFiyat;
        private System.Windows.Forms.Button btnKirala;
    }
}
