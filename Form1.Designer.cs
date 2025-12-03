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
            this.qrListBox = new System.Windows.Forms.ListBox();
            this.deleteQrButton = new System.Windows.Forms.Button();
            this.saveQrButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // qrImageDisplay
            // 
            this.qrImageDisplay.Location = new System.Drawing.Point(263, 12);
            this.qrImageDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.qrImageDisplay.Name = "qrImageDisplay";
            this.qrImageDisplay.Size = new System.Drawing.Size(150, 150);
            this.qrImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrImageDisplay.TabIndex = 0;
            this.qrImageDisplay.TabStop = false;
            // 
            // newQrButton
            // 
            this.newQrButton.ForeColor = System.Drawing.Color.Black;
            this.newQrButton.Location = new System.Drawing.Point(476, 61);
            this.newQrButton.Margin = new System.Windows.Forms.Padding(2);
            this.newQrButton.Name = "newQrButton";
            this.newQrButton.Size = new System.Drawing.Size(116, 19);
            this.newQrButton.TabIndex = 1;
            this.newQrButton.Text = "Yeni QR Kod Oluştur";
            this.newQrButton.UseVisualStyleBackColor = true;
            this.newQrButton.Click += new System.EventHandler(this.newQrButton_Click);
            // 
            // newQrTextBox
            // 
            this.newQrTextBox.Location = new System.Drawing.Point(476, 12);
            this.newQrTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newQrTextBox.Multiline = true;
            this.newQrTextBox.Name = "newQrTextBox";
            this.newQrTextBox.Size = new System.Drawing.Size(190, 45);
            this.newQrTextBox.TabIndex = 2;
            // 
            // newQrLabel
            // 
            this.newQrLabel.AutoSize = true;
            this.newQrLabel.Location = new System.Drawing.Point(417, 14);
            this.newQrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newQrLabel.Name = "newQrLabel";
            this.newQrLabel.Size = new System.Drawing.Size(58, 13);
            this.newQrLabel.TabIndex = 3;
            this.newQrLabel.Text = "Yazı Verisi:";
            // 
            // qrListBox
            // 
            this.qrListBox.FormattingEnabled = true;
            this.qrListBox.Location = new System.Drawing.Point(12, 12);
            this.qrListBox.Name = "qrListBox";
            this.qrListBox.Size = new System.Drawing.Size(246, 381);
            this.qrListBox.TabIndex = 4;
            this.qrListBox.SelectedIndexChanged += new System.EventHandler(this.qrListBox_SelectedIndexChanged);
            // 
            // deleteQrButton
            // 
            this.deleteQrButton.ForeColor = System.Drawing.Color.Black;
            this.deleteQrButton.Location = new System.Drawing.Point(263, 371);
            this.deleteQrButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteQrButton.Name = "deleteQrButton";
            this.deleteQrButton.Size = new System.Drawing.Size(116, 19);
            this.deleteQrButton.TabIndex = 5;
            this.deleteQrButton.Text = "QR Kodu Sil";
            this.deleteQrButton.UseVisualStyleBackColor = true;
            this.deleteQrButton.Click += new System.EventHandler(this.deleteQrButton_Click);
            // 
            // saveQrButton
            // 
            this.saveQrButton.ForeColor = System.Drawing.Color.Black;
            this.saveQrButton.Location = new System.Drawing.Point(281, 166);
            this.saveQrButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveQrButton.Name = "saveQrButton";
            this.saveQrButton.Size = new System.Drawing.Size(116, 19);
            this.saveQrButton.TabIndex = 6;
            this.saveQrButton.Text = "QR Kodu İndir";
            this.saveQrButton.UseVisualStyleBackColor = true;
            this.saveQrButton.Click += new System.EventHandler(this.saveQrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(677, 401);
            this.Controls.Add(this.saveQrButton);
            this.Controls.Add(this.deleteQrButton);
            this.Controls.Add(this.qrListBox);
            this.Controls.Add(this.newQrLabel);
            this.Controls.Add(this.newQrTextBox);
            this.Controls.Add(this.newQrButton);
            this.Controls.Add(this.qrImageDisplay);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox qrListBox;
        private System.Windows.Forms.Button deleteQrButton;
        private System.Windows.Forms.Button saveQrButton;
    }
}

