namespace HotelReservation.Forms
{
    partial class FrmYorumlar
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
            this.flpYorumlar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOtelAdi = new System.Windows.Forms.Label();
            this.lblOtelAdiYorumlar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtYorum = new System.Windows.Forms.RichTextBox();
            this.txtYorumBasligi = new System.Windows.Forms.TextBox();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpYorumlar
            // 
            this.flpYorumlar.AutoScroll = true;
            this.flpYorumlar.Location = new System.Drawing.Point(12, 77);
            this.flpYorumlar.Name = "flpYorumlar";
            this.flpYorumlar.Size = new System.Drawing.Size(875, 283);
            this.flpYorumlar.TabIndex = 0;
            // 
            // lblOtelAdi
            // 
            this.lblOtelAdi.AutoSize = true;
            this.lblOtelAdi.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdi.Location = new System.Drawing.Point(19, 26);
            this.lblOtelAdi.Name = "lblOtelAdi";
            this.lblOtelAdi.Size = new System.Drawing.Size(94, 25);
            this.lblOtelAdi.TabIndex = 1;
            this.lblOtelAdi.Text = "Otel Adı:";
            // 
            // lblOtelAdiYorumlar
            // 
            this.lblOtelAdiYorumlar.AutoSize = true;
            this.lblOtelAdiYorumlar.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdiYorumlar.Location = new System.Drawing.Point(110, 26);
            this.lblOtelAdiYorumlar.Name = "lblOtelAdiYorumlar";
            this.lblOtelAdiYorumlar.Size = new System.Drawing.Size(0, 25);
            this.lblOtelAdiYorumlar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yorum Başlığı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yorum:";
            // 
            // rtxtYorum
            // 
            this.rtxtYorum.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtYorum.Location = new System.Drawing.Point(177, 437);
            this.rtxtYorum.Name = "rtxtYorum";
            this.rtxtYorum.Size = new System.Drawing.Size(439, 172);
            this.rtxtYorum.TabIndex = 5;
            this.rtxtYorum.Text = "";
            // 
            // txtYorumBasligi
            // 
            this.txtYorumBasligi.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYorumBasligi.Location = new System.Drawing.Point(177, 386);
            this.txtYorumBasligi.Multiline = true;
            this.txtYorumBasligi.Name = "txtYorumBasligi";
            this.txtYorumBasligi.Size = new System.Drawing.Size(439, 33);
            this.txtYorumBasligi.TabIndex = 6;
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnYorumYap.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYorumYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYorumYap.Location = new System.Drawing.Point(177, 615);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(227, 53);
            this.btnYorumYap.TabIndex = 12;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = false;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // FrmYorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 691);
            this.Controls.Add(this.btnYorumYap);
            this.Controls.Add(this.txtYorumBasligi);
            this.Controls.Add(this.rtxtYorum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOtelAdiYorumlar);
            this.Controls.Add(this.lblOtelAdi);
            this.Controls.Add(this.flpYorumlar);
            this.Name = "FrmYorumlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yorumlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpYorumlar;
        private System.Windows.Forms.Label lblOtelAdi;
        private System.Windows.Forms.Label lblOtelAdiYorumlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtYorum;
        private System.Windows.Forms.TextBox txtYorumBasligi;
        private System.Windows.Forms.Button btnYorumYap;
    }
}