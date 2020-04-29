using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using QRCoder;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace Second_Year
{
    
    public partial class AddStudent : UserControl
    {
        string gender = "";
        public AddStudent()
        {
            InitializeComponent();
        }

  
        public static string SaveImageCapture_one(System.Drawing.Image image, string name)
        {
            string filename="";
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = name;
            s.DefaultExt = ".Jpg";
            s.Filter = "Image (.jpg)|*.jpg";


            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);


            s.RestoreDirectory = true;

            if (s.ShowDialog() == DialogResult.OK)
            {
                filename = s.FileName;
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
            return filename;
        }
        public static void SaveImageCapture(System.Drawing.Image image, string name)
        {
            
           
                using (System.IO.FileStream fstream = new System.IO.FileStream(name, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            
            
        }




        private void sendChB_CheckedChanged(object sender, EventArgs e)
        {
            if (sendChB.Checked == true)
                mailGB.Enabled = true;
            else
                mailGB.Enabled = false;
        }

       

        private void AddStudCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AddStudCB.SelectedItem.Equals("Multi Students"))
            {
                multiPanel.Visible = true;
                one_student_panel.Visible = false;
            }
            else if (AddStudCB.SelectedItem.Equals("Only one student"))
            {
                multiPanel.Visible = false;
                one_student_panel.Visible = true;
            }
        }

        private void female1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (female1_radioButton.Checked == true)
            {
                gender = "female";
                male1_radioButton.Checked = false;
            }
        }

        private void male1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (male1_radioButton.Checked == true)
            {
                gender = "male";
                female1_radioButton.Checked = false;
            }
        }

        private void ADD_Btn_Click(object sender, EventArgs e)
        {
            if (name1Txt.Text != "" && Gmail1Txt.Text != "" && gender != "" && phone1Txt.Text != "" && parent1Txt.Text != "")
            {
                Student stu = new Student();
                stu.set_name(name1Txt.Text);
                stu.set_gmail(Gmail1Txt.Text);
                stu.set_gender(gender);
                stu.set_phone(phone1Txt.Text);
                stu.set_status("Good");
                stu.set_parant_phone(parent1Txt.Text);
                stu.add_student(stu);
                QRCodeGenerator coder = new QRCodeGenerator();
                var mydata = coder.CreateQrCode(name1Txt.Text, QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(mydata);
                pictureBox1.Image = code.GetGraphic(50);
                string path = SaveImageCapture_one(pictureBox1.Image, name1Txt.Text);
                if (sendChB.Checked == true)
                {
                    stu.send_qr(stu, path, yourEmail1.Text, yourPass1.Text);
                }
                MessageBox.Show("Done!");
            }
            else {
                MessageBox.Show("please enter all data");
            }

        }

        private void browseExelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ExelPathTXT.Text = openfiledialog1.FileName;

        }

        private void BrowseQrTXT_Click(object sender, EventArgs e)
        {
            
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                qrFileTXT.Text = fbd.SelectedPath;
        }

        private void AddBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlapp = new Excel.Application();
                Excel.Workbook wrokb = xlapp.Workbooks.Open(ExelPathTXT.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet wsheet = (Excel.Worksheet)wrokb.Worksheets.get_Item(1);
                Excel.Range range = wsheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                progressBar1.Visible = true;
                
                for (int i = 2; i <= rows; i++)
                {
                    double x = i;
                    double y = rows;
                    double z = x / y;
                    int a = Convert.ToUInt16(z);
                    progressBar1.Increment(a*100);
                   
                    
                    Student stu = new Student();
                    stu.set_name(((range.Cells[i, 2] as Excel.Range).Value2).ToString());
                    stu.set_gmail(((range.Cells[i, 3] as Excel.Range).Value2).ToString());
                    stu.set_phone(((range.Cells[i, 4] as Excel.Range).Value2).ToString());
                    stu.set_gender(((range.Cells[i, 5] as Excel.Range).Value2).ToString());
                    stu.set_parant_phone(((range.Cells[i, 6] as Excel.Range).Value2).ToString());
                    stu.set_status("Good");
                    stu.add_student(stu);
                    QRCodeGenerator coder = new QRCodeGenerator();
                    var mydata = coder.CreateQrCode(stu.get_name(), QRCodeGenerator.ECCLevel.H);
                    var code = new QRCoder.QRCode(mydata);
                    PictureBox pic = new PictureBox();

                    pic.Image = code.GetGraphic(50);
                    SaveImageCapture(pic.Image, qrFileTXT.Text + "\\" + stu.get_name() + ".jpg");
                    if (Send2CheckBox.Checked == true)
                    {
                        stu.send_qr(stu, qrFileTXT.Text + "\\" + stu.get_name() + ".jpg", yourMail2.Text, yourPass2.Text);
                    }




                }
                MessageBox.Show("Done!");
                progressBar1.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show("select full data please");
            }

        }

        private void Send2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Send2CheckBox.Checked == true)
                GmailGB2.Enabled = true;
            else
                GmailGB2.Enabled = false;
        }

      

        private void ExelPathTXT_Leave(object sender, EventArgs e)
        {
            if (ExelPathTXT.Text.Equals(""))
            {
                ExelPathTXT.ForeColor = Color.Gray;
                ExelPathTXT.Text = "Exel path";
            }
        }

        private void qrFileTXT_Leave(object sender, EventArgs e)
        {
            if (qrFileTXT.Text.Equals(""))
            {
                qrFileTXT.ForeColor = Color.Gray;
                qrFileTXT.Text = "Qr file path";
            }
        }

        private void qrFileTXT_Click(object sender, EventArgs e)
        {
            if (qrFileTXT.Text.Equals("Qr file path"))
            {
                qrFileTXT.Text = "";
                qrFileTXT.ForeColor = Color.MidnightBlue;
            }
        }

        private void ExelPathTXT_Click(object sender, EventArgs e)
        {
            if (qrFileTXT.Text.Equals("Exel path"))
            {
                qrFileTXT.Text = "";
                qrFileTXT.ForeColor = Color.MidnightBlue;
            }
        }

        private void yourMail2_Click(object sender, EventArgs e)
        {
            if (yourMail2.Text.Equals("E_mail"))
            {
                yourMail2.Text = "";
                yourMail2.ForeColor = Color.MidnightBlue;
            }
        }

        private void yourPass2_Click(object sender, EventArgs e)
        {
            if (yourPass2.Text.Equals("Password"))
            {
                yourPass2.Text = "";
                yourPass2.ForeColor = Color.MidnightBlue;
            }
        }

        private void yourPass2_Leave(object sender, EventArgs e)
        {
            if (yourPass2.Text.Equals(""))
            {
                yourPass2.ForeColor = Color.Gray;
                yourPass2.Text = "Password";
            }
        }

        private void yourMail2_Leave(object sender, EventArgs e)
        {
            if (yourMail2.Text.Equals(""))
            {
                yourMail2.ForeColor = Color.Gray;
                yourMail2.Text = "E_mail";
            }
        }

        private void yourEmail1_Leave(object sender, EventArgs e)
        {
            if (yourEmail1.Text.Equals(""))
            {
                yourEmail1.ForeColor = Color.Gray;
                yourEmail1.Text = "E_mail";
            }
        }

        private void yourEmail1_Click(object sender, EventArgs e)
        {
            if (yourEmail1.Text.Equals("E_mail"))
            {
                yourEmail1.Text = "";
                yourEmail1.ForeColor = Color.MidnightBlue;
            }
        }

        private void yourPass1_Leave(object sender, EventArgs e)
        {
            if (yourPass1.Text.Equals(""))
            {
                yourPass1.ForeColor = Color.Gray;
                yourPass1.Text = "Password";
            }
        }

        private void yourPass1_Click(object sender, EventArgs e)
        {
            if (yourPass1.Text.Equals("Password"))
            {
                yourPass1.Text = "";
                yourPass1.ForeColor = Color.MidnightBlue;
            }
        }

       
    }
    }

