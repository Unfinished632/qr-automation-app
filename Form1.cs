using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace qr_automation_app
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveQrButton.Visible = false;
            deleteQrButton.Visible = false;

            conn.Open();

            RefreshQRList();
        }

        private void newQrButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO qr_codes (qr_text) VALUES (@text)", conn);
            command.Parameters.AddWithValue("@text", newQrTextBox.Text);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            RefreshQRList();

            newQrTextBox.Clear();
        }

        void RefreshQRList()
        {
            qrListBox.Items.Clear();

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM qr_codes", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
                qrListBox.Items.Add(row[1]);
        }

        private void qrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(qrListBox.SelectedItem == null)
            {
                qrImageDisplay.Image = null;
                saveQrButton.Visible = false;
                deleteQrButton.Visible = true;
                return;
            }
            else
            {
                saveQrButton.Visible = true;
                deleteQrButton.Visible = true;
            }

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM qr_codes", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            byte[] qrCodeImage = BitmapByteQRCodeHelper.GetQRCode(qrListBox.SelectedItem.ToString(), QRCodeGenerator.ECCLevel.Q, 5);
            var ms = new MemoryStream(qrCodeImage);
            Bitmap bmp = new Bitmap(ms);

            qrImageDisplay.Image = bmp;
        }

        private void deleteQrButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("DELETE FROM qr_codes WHERE qr_text=@text", conn);
            command.Parameters.AddWithValue("@text", qrListBox.SelectedItem.ToString());
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            RefreshQRList();

            if (qrListBox.SelectedItem == null)
            {
                qrImageDisplay.Image = null;
                saveQrButton.Visible = false;
                deleteQrButton.Visible = false;
            }
        }

        private void saveQrButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG (*.png)|*.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                qrImageDisplay.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
