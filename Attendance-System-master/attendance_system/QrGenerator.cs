using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Second_Year
{
    public partial class QrGenerator : UserControl
    {
        public QrGenerator()
        {
            InitializeComponent();
        }

        private void LinkTxt_Click(object sender, EventArgs e)
        {
            if (LinkTxt.Text.Equals("https://******"))
            {
                LinkTxt.Text = "";
                LinkTxt.ForeColor = Color.MidnightBlue;
            }
        }

        private void nameTxt_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text.Equals("Name of Qr pic"))
            {
                nameTxt.Text = "";
                nameTxt.ForeColor = Color.MidnightBlue;
            }
        }

        private void LinkTxt_Leave(object sender, EventArgs e)
        {
            if (LinkTxt.Text.Equals(""))
            {
                LinkTxt.ForeColor = Color.Gray;
                LinkTxt.Text = "https://******";
            }
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text.Equals(""))
            {
                nameTxt.ForeColor = Color.Gray;
                nameTxt.Text = "Name of Qr pic";
            }
        }

        private void Generate_Btn_Click(object sender, EventArgs e)
        {
            if (LinkTxt.Text != "https://******" && nameTxt.Text != "Name of Qr pic")
            {
                QRCodeGenerator coder = new QRCodeGenerator();
                var mydata = coder.CreateQrCode(LinkTxt.Text, QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(mydata);
                pictureBox1.Image = code.GetGraphic(50);
                SaveImageCapture(pictureBox1.Image, nameTxt.Text);
            }
            else {
                MessageBox.Show("please enter full data");
            }
        }
        public static void SaveImageCapture(System.Drawing.Image image, string name)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = name;
            s.DefaultExt = ".Jpg";
            s.Filter = "Image (.jpg)|*.jpg";


            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);


            s.RestoreDirectory = true;

            if (s.ShowDialog() == DialogResult.OK)
            {

                string filename = s.FileName;

                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
        }
    }
}
