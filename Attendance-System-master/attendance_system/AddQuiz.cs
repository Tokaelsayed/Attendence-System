using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Second_Year
{
    public partial class AddQuiz : UserControl
    {
        public AddQuiz()
        {
            InitializeComponent();
        }

        private void sendChB_CheckedChanged(object sender, EventArgs e)
        {
            if (sendChB.Checked == true)
                mailGB.Enabled = true;
            else
                mailGB.Enabled = false;
        }

        private void browseExelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ExelPathTXT.Text = openfiledialog1.FileName;
        }

        private void ADD_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text != "" && DateTxt.Text != "" && Tgradetxt.Text != "")
                {
                    Exam.addexam(nameTxt.Text, DateTxt.Text);
                    Excel.Application xlapp = new Excel.Application();
                    Excel.Workbook wrokb = xlapp.Workbooks.Open(ExelPathTXT.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    Excel.Worksheet wsheet = (Excel.Worksheet)wrokb.Worksheets.get_Item(1);
                    Excel.Range range = wsheet.UsedRange;
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    for (int i = 2; i <= rows; i++)
                    {
                        string gmail = ((range.Cells[i, 2] as Excel.Range).Value2).ToString();
                        string grade = ((range.Cells[i, 3] as Excel.Range).Value2).ToString();
                        Exam.addstu_exam(nameTxt.Text, gmail, grade + '/' + Tgradetxt.Text);
                        if (sendChB.Checked == true)
                        {
                            string email = yourEmail1.Text;
                            string pass = yourPass1.Text;
                            Exam.send_grade(gmail, grade + '/' + Tgradetxt.Text, email, pass);

                        }
                    }
                    MessageBox.Show("Done!");
                }
                else {
                    MessageBox.Show("please enter all data");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("please enter all data");
            }

        }

     

       

      

       
        private void Choose_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Choose_comboBox.SelectedItem.Equals("Only one student"))
            {
                onePanel.Visible = true;
                allPanel.Visible = false;

            }
            else if (Choose_comboBox.SelectedItem.Equals("All students"))
            {
                allPanel.Visible = true;
                onePanel.Visible = false;
            }

        }

        private void sendCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sendCB.Checked)
                mail1GB.Enabled = true;
            else
                mail1GB.Enabled = false;
        }

        private void Add1Txt_Click(object sender, EventArgs e)
        {
            if (quiz1Txt.Text != "" && date1Txt.Text != "" && gradeTxt.Text != "" && studTxt.Text != "")
            {
                Exam.addexam(quiz1Txt.Text, date1Txt.Text);
                Exam.addstu1_exam(quiz1Txt.Text, studTxt.Text, gradeTxt.Text);

                if (sendCB.Checked == true)
                {
                    
                    string email = mailTxt.Text;
                    string pass = passwordTxt.Text;
                    Exam.send_grade(stugmailtxt.Text, gradeTxt.Text, email, pass);

                }
                MessageBox.Show("Done!");
            }
            else {
                MessageBox.Show("please enter all data");
            }
        }

        private void mailTxt_Click(object sender, EventArgs e)
        {
            if (mailTxt.Text.Equals("E_mail"))
            {
                mailTxt.Text = "";
                mailTxt.ForeColor = Color.MidnightBlue;
            }
        }

        private void mailTxt_Leave(object sender, EventArgs e)
        {
            if (mailTxt.Text.Equals(""))
            {
                mailTxt.ForeColor = Color.Gray;
                mailTxt.Text = "E_mail";
            }
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            if (passwordTxt.Text.Equals("Password"))
            {
                passwordTxt.Text = "";
                passwordTxt.ForeColor = Color.MidnightBlue;
            }
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            if (passwordTxt.Text.Equals(""))
            {
                passwordTxt.Text = "Password";
                passwordTxt.ForeColor = Color.Gray;
            }
        }

        private void stugmailtxt_Leave(object sender, EventArgs e)
        {
            if (stugmailtxt.Text.Equals(""))
            {
                passwordTxt.Text = "student gmail";
                passwordTxt.ForeColor = Color.Gray;
            }
        }

        private void stugmailtxt_Click(object sender, EventArgs e)
        {
            if (stugmailtxt.Text.Equals("student gmail"))
            {
                stugmailtxt.Text = "";
                stugmailtxt.ForeColor = Color.MidnightBlue;
            }
        }

        private void ExelPathTXT_Click(object sender, EventArgs e)
        {
            if (ExelPathTXT.Text.Equals("Exel path"))
            {
                ExelPathTXT.Text = "";
                ExelPathTXT.ForeColor = Color.MidnightBlue;
            }
        }

        private void ExelPathTXT_Leave(object sender, EventArgs e)
        {
            if (ExelPathTXT.Text.Equals(""))
            {
                ExelPathTXT.Text = "Exel path";
                ExelPathTXT.ForeColor = Color.Gray;
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

        private void yourEmail1_Leave(object sender, EventArgs e)
        {
            if (yourEmail1.Text.Equals(""))
            {
                yourEmail1.ForeColor = Color.Gray;
                yourEmail1.Text = "E_mail";
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

        private void yourPass1_Leave(object sender, EventArgs e)
        {
            if (yourPass1.Text.Equals(""))
            {
                yourPass1.Text = "Password";
                yourPass1.ForeColor = Color.Gray;
            }
        }
    }
    }

