using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qr_automation_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newQrButton_Click(object sender, EventArgs e)
        {
            byte[] qrCodeImage = BitmapByteQRCodeHelper.GetQRCode(newQrTextBox.Text, QRCodeGenerator.ECCLevel.Q, 5);
            var ms = new MemoryStream(qrCodeImage);
            Bitmap bmp = new Bitmap(ms);
            bmp = new Bitmap(ms);

            qrImageDisplay.Image = bmp;
        }
    }
}
