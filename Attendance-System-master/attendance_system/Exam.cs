using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
namespace Second_Year
{
    class Exam
    {
        private int exam_id;
      

       
        private SqlConnection connection = new SqlConnection(Program.path);
        private SqlDataReader reader;
        private string selectSql;
        private SqlCommand command;

        static public void addexam(string name, string date) {
            SqlConnection connect = new SqlConnection(Program.path);
            try
            {
                string quary = "insert into [Exam] (ex_name,ex_data) values ('" + name + "','" + date + "')";
                SqlCommand command = new SqlCommand(quary, connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        static public void addstu_exam(string ex_name, string gmail, string grade) {
            SqlConnection connect = new SqlConnection(Program.path);
            try
            {
                string quary = "insert into [student_exam] ([ex_id],[stu_id],[grade]) values((select ex_ID from Exam where ex_name='"+ex_name+"'),(select stud_id from student_information where stud_gmail='"+gmail+"'),'"+grade+"');";
;
                SqlCommand command = new SqlCommand(quary, connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        static public void addstu1_exam(string ex_name, string name, string grade)
        {
            SqlConnection connect = new SqlConnection(Program.path);
            try
            {
                string quary = "insert into [Exam_Student] ([ex_id],[stu_id],[grade]) values((select ex_ID from Exam where ex_name='" + ex_name + "'),(select stud_id from student_information where stud_name=N'" + name + "'),'" + grade + "');";
                ;
                SqlCommand command = new SqlCommand(quary, connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static public void send_grade(string gmail, string grade, string email, string password)
        {
            try
            {
                MailMessage Email = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                Email.From = new MailAddress(email);
                Email.To.Add(gmail);
                Email.Subject = "Exam grade";
                Email.Body = "Dear student, \n your score in last exam is "+grade;
                
                
                smtpServer.Port = 587;

                smtpServer.Credentials = new System.Net.NetworkCredential(email, password);
                smtpServer.EnableSsl = true;


                smtpServer.Send(Email);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void find_TheLast_Quiz(int studID)
        {
            selectSql = "SELECT ex_ID FROM Exam;";
            command = new SqlCommand(selectSql, connection);
            connection.Open();
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        exam_id = reader.GetInt32(0);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public bool check_TheLast_Exam(int studID)
        {
            find_TheLast_Quiz(studID);
            bool check = false;
            selectSql = "SELECT grade FROM Exam_student WHERE stu_id='" + studID + "' and ex_id='" + exam_id + "';";
            command = new SqlCommand(selectSql, connection);
            connection.Open();
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string quiz = reader.GetString(0);
                    check = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return check;
        }
    }
}
