namespace qr_automation_app
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrImageDisplay = new System.Windows.Forms.PictureBox();
            this.newQrButton = new System.Windows.Forms.Button();
            this.newQrTextBox = new System.Windows.Forms.TextBox();
            this.newQrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // qrImageDisplay
            // 
            this.qrImageDisplay.Location = new System.Drawing.Point(371, 70);
            this.qrImageDisplay.Name = "qrImageDisplay";
            this.qrImageDisplay.Size = new System.Drawing.Size(180, 180);
            this.qrImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrImageDisplay.TabIndex = 0;
            this.qrImageDisplay.TabStop = false;
            // 
            // newQrButton
            // 
            this.newQrButton.Location = new System.Drawing.Point(636, 98);
            this.newQrButton.Name = "newQrButton";
            this.newQrButton.Size = new System.Drawing.Size(155, 23);
            this.newQrButton.TabIndex = 1;
            this.newQrButton.Text = "Yeni QR Kod Oluştur";
            this.newQrButton.UseVisualStyleBackColor = true;
            this.newQrButton.Click += new System.EventHandler(this.newQrButton_Click);
            // 
            // newQrTextBox
            // 
            this.newQrTextBox.Location = new System.Drawing.Point(636, 70);
            this.newQrTextBox.Name = "newQrTextBox";
            this.newQrTextBox.Size = new System.Drawing.Size(155, 22);
            this.newQrTextBox.TabIndex = 2;
            // 
            // newQrLabel
            // 
            this.newQrLabel.AutoSize = true;
            this.newQrLabel.Location = new System.Drawing.Point(557, 73);
            this.newQrLabel.Name = "newQrLabel";
            this.newQrLabel.Size = new System.Drawing.Size(73, 16);
            this.newQrLabel.TabIndex = 3;
            this.newQrLabel.Text = "Yazı Verisi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 493);
            this.Controls.Add(this.newQrLabel);
            this.Controls.Add(this.newQrTextBox);
            this.Controls.Add(this.newQrButton);
            this.Controls.Add(this.qrImageDisplay);
            this.Name = "Form1";
            this.Text = "QR Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrImageDisplay;
        private System.Windows.Forms.Button newQrButton;
        private System.Windows.Forms.TextBox newQrTextBox;
        private System.Windows.Forms.Label newQrLabel;
    }
}

