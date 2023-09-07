namespace Stok_Takip_Uygulaması
{
    partial class Form1
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            this.lblGirisYazisi = new System.Windows.Forms.Label();
            this.lblMusteriEkleme = new System.Windows.Forms.Label();
            this.lblListeleme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 7;
            // 
            // btnListeleme
            // 
            this.btnListeleme.Location = new System.Drawing.Point(543, 328);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(170, 47);
            this.btnListeleme.TabIndex = 2;
            this.btnListeleme.Text = "Müşteri Listeleme";
            this.btnListeleme.UseVisualStyleBackColor = true;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.Location = new System.Drawing.Point(543, 246);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(170, 48);
            this.btnMusteriEkleme.TabIndex = 0;
            this.btnMusteriEkleme.Text = "Müşteri Ekleme";
            this.btnMusteriEkleme.UseVisualStyleBackColor = true;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.btnMusteriEkleme_Click);
            // 
            // lblGirisYazisi
            // 
            this.lblGirisYazisi.AutoSize = true;
            this.lblGirisYazisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGirisYazisi.Location = new System.Drawing.Point(251, 160);
            this.lblGirisYazisi.Name = "lblGirisYazisi";
            this.lblGirisYazisi.Size = new System.Drawing.Size(96, 16);
            this.lblGirisYazisi.TabIndex = 8;
            this.lblGirisYazisi.Text = "HOŞGELDİNİZ";
            // 
            // lblMusteriEkleme
            // 
            this.lblMusteriEkleme.AutoSize = true;
            this.lblMusteriEkleme.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMusteriEkleme.Location = new System.Drawing.Point(78, 262);
            this.lblMusteriEkleme.Name = "lblMusteriEkleme";
            this.lblMusteriEkleme.Size = new System.Drawing.Size(191, 16);
            this.lblMusteriEkleme.TabIndex = 9;
            this.lblMusteriEkleme.Text = "Müşteri Eklemek İçin Tıklayınız:";
            // 
            // lblListeleme
            // 
            this.lblListeleme.AutoSize = true;
            this.lblListeleme.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblListeleme.Location = new System.Drawing.Point(78, 343);
            this.lblListeleme.Name = "lblListeleme";
            this.lblListeleme.Size = new System.Drawing.Size(221, 16);
            this.lblListeleme.TabIndex = 10;
            this.lblListeleme.Text = "Müşterileri Listelemek İçin Tıklayınız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 558);
            this.Controls.Add(this.lblListeleme);
            this.Controls.Add(this.lblMusteriEkleme);
            this.Controls.Add(this.lblGirisYazisi);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.btnMusteriEkleme);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "SATIŞ SAYFASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button btnMusteriEkleme;
        private System.Windows.Forms.Label lblGirisYazisi;
        private System.Windows.Forms.Label lblMusteriEkleme;
        private System.Windows.Forms.Label lblListeleme;
    }
}

