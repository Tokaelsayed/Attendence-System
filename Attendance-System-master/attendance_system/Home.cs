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
using System.IO;
using System.Diagnostics;

namespace Second_Year
{
    public partial class Home : UserControl
    {
        string form = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Review_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (form == "B")
                Attendance.Attendance_ControlRemoved();
            panel1.Controls.Add(new Review());            
        }

        private void Attendance_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            form = "B";
            panel1.Controls.Add(new Attendance());
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (form == "B")
                Attendance.Attendance_ControlRemoved();
            panel1.Controls.Add(new AddStudent());
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (form == "B")
                Attendance.Attendance_ControlRemoved();
            panel1.Controls.Add(new Classes_Quizes());
        }

      

      
        private void AddQuizBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (form == "B")
                Attendance.Attendance_ControlRemoved();
            panel1.Controls.Add(new AddQuiz());
        }

        private void AddStudCB_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                DialogResult dialogResult2 = MessageBox.Show("Database will be deleted immediatly if you choose yes", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    SqlConnection connection = new SqlConnection(Program.path);

                    try
                    {
                        connection.Open();
                        string query = " DELETE FROM class WHERE  0 = 0";
                        string query2 = " DELETE FROM Attendance_tab WHERE 0 = 0";
                        string query3 = " DELETE FROM Exam_student WHERE 0 = 0";
                        string query4 = " DELETE FROM student_information WHERE 0 = 0";
                        string query5 = " DELETE FROM Exam WHERE 0 = 0";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlCommand cmd2 = new SqlCommand(query2, connection);
                        SqlCommand cmd3 = new SqlCommand(query3, connection);
                        SqlCommand cmd4 = new SqlCommand(query4, connection);
                        SqlCommand cmd5 = new SqlCommand(query5, connection);
                        cmd2.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("Done");

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (form == "B")
                Attendance.Attendance_ControlRemoved();
            panel1.Controls.Add(new QrGenerator());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to restore backup?", "Backup", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        string path = fbd.SelectedPath;
                        string path1 = Path.GetFullPath(Environment.CurrentDirectory);
                        foreach (Process Proc in Process.GetProcessesByName("sqlservr"))
                        {

                            Proc.Kill();

                            //Process Excel?
                        }

                        System.Threading.Thread.Sleep(500);
                        if (File.Exists(path1 + @"\second_year.mdf"))
                            File.Delete(path1 + @"\second_year.mdf");

                        if (File.Exists(path1 + @"\second_year_log.ldf"))
                            File.Delete(path1 + @"\second_year_log.ldf");
                       
                        File.Copy(path + @"\second_year.mdf", path1 + @"\second_year.mdf");
                        File.Copy(path + @"\second_year_log.ldf", path1 + @"\second_year_log.ldf");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }





            }
        }
    }
}
