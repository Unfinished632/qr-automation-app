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
            byte[] qrCodeImage = BitmapByteQRCodeHelper.GetQRCode("Hello World", QRCodeGenerator.ECCLevel.Q, 5);
            Bitmap bmp;
            using (var ms = new MemoryStream(qrCodeImage))
            {
                bmp = new Bitmap(ms);
            }

            qrImage.Image = bmp;
        }
    }
}
