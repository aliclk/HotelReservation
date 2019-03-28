namespace HotelReservation.CustomControls
{
    partial class YorumItem
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
            this.LblYorumBasligi = new System.Windows.Forms.Label();
            this.lblYorumlar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOtelAdi
            // 
            this.lblOtelAdi.AutoSize = true;
            this.lblOtelAdi.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdi.Location = new System.Drawing.Point(21, 30);
            this.lblOtelAdi.Name = "lblOtelAdi";
            this.lblOtelAdi.Size = new System.Drawing.Size(137, 40);
            this.lblOtelAdi.TabIndex = 19;
            this.lblOtelAdi.Text = "Otel Adı";
            // 
            // LblYorumBasligi
            // 
            this.LblYorumBasligi.AutoSize = true;
            this.LblYorumBasligi.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYorumBasligi.Location = new System.Drawing.Point(21, 102);
            this.LblYorumBasligi.Name = "LblYorumBasligi";
            this.LblYorumBasligi.Size = new System.Drawing.Size(142, 26);
            this.LblYorumBasligi.TabIndex = 20;
            this.LblYorumBasligi.Text = "Yorum Başlığı";
            // 
            // lblYorumlar
            // 
            this.lblYorumlar.AutoSize = true;
            this.lblYorumlar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYorumlar.Location = new System.Drawing.Point(21, 166);
            this.lblYorumlar.Name = "lblYorumlar";
            this.lblYorumlar.Size = new System.Drawing.Size(74, 26);
            this.lblYorumlar.TabIndex = 21;
            this.lblYorumlar.Text = "Yorum";
            // 
            // YorumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lblYorumlar);
            this.Controls.Add(this.LblYorumBasligi);
            this.Controls.Add(this.lblOtelAdi);
            this.Name = "YorumItem";
            this.Size = new System.Drawing.Size(838, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAdi;
        private System.Windows.Forms.Label LblYorumBasligi;
        private System.Windows.Forms.Label lblYorumlar;
    }
}
