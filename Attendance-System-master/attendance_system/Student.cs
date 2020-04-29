using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Data;
namespace Second_Year
{
    class Student
    {

        private int stud_id;
        private string stud_name;
        private string stud_phone;
        private string stud_gmail;
        private string stud_status;
        private string parent_phone;
        private bool found;
        private string gender;
        private List<Exam> exams;
        private List<Class> classes;

        
        private SqlConnection connection = new SqlConnection(Program.path);
        private SqlDataReader reader;
        private string selectSql;
        private SqlCommand command;
        public Student()
        {
            stud_id = -1;
            stud_name = null;
            stud_phone = null;
            stud_gmail = null;
            stud_status = null;
            parent_phone = null;
            found = false;
            exams = new List<Exam>();
            classes = new List<Class>();

            
        }
        public string get_name() { return stud_name; }
        public void set_name(string n) { stud_name = n; }
        public string get_phone() { return stud_phone; }
        public void set_phone(string p) { stud_phone = p; }
        public string get_gmail() { return stud_gmail; }
        public void set_gmail(string g) { stud_gmail = g; }
        public string get_status() { return stud_status; }
        public void set_status(string s) { stud_status = s; }
        public string get_parent_phone() { return parent_phone; }
        public void set_parant_phone(string p) { parent_phone = p; }
        public string get_gender() { return gender; }
        public void set_gender(string g) { gender = g; }




        public void add_student(Student stu)
        {
            string command = "insert into [student_information] ([stud_name],[stud_phone],[stud_gmail],[stud_status],[parent_phone],[Gender]) values (N'" + stu.stud_name + "','" + stu.stud_phone + "','" + stu.stud_gmail + "','" + stu.stud_status + "','" + stu.parent_phone + "','" + stu.gender + "')";
            SqlConnection connect = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand(command, connect);
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                

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
        public void send_qr(Student stu, string path, string email, string password)
        {
            try
            {
                MailMessage Email = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                Email.From = new MailAddress(email);
                Email.To.Add(stu.stud_gmail);
                Email.Subject = "QR Attendance code";
                Email.Body = "Dear " + stu.stud_name + ", \n Here is your Qr code,kindly refer to the attached.";
                Attachment qr = new Attachment(path);
                Email.Attachments.Add(qr);
                smtpServer.Port = 587;

                smtpServer.Credentials = new System.Net.NetworkCredential(email, password);
                smtpServer.EnableSsl = true;


                smtpServer.Send(Email);
              
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

        public void find_Id_ofstudent(string NAME)
        {
            selectSql = "SELECT stud_id FROM student_information WHERE stud_name =N'" + NAME + "';";
            command = new SqlCommand(selectSql, connection);
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    stud_id = reader.GetInt32(0);
                    found = true;
                }
                else
                {
                    found = false;
                   
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

        public int attendance(string NAME , int classId)
        {
            
            find_Id_ofstudent(NAME);
            if (found == false) {
                return -2;
            }
            selectSql = "INSERT INTO Attendance_tab (stu_id , class_id) VALUES ('" + stud_id.ToString() + "','" + classId.ToString() + "')";
            command = new SqlCommand(selectSql, connection);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return stud_id;
        }
        //// tokaaaa
        public void ret_students_info(DataGridView dataGridView1)
        {
            SqlConnection con = new SqlConnection(Program.path);//connection name                                                                                                                                           
            SqlCommand cmd = new SqlCommand("select * from student_information", con);
            connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
            finally
            {
                connection.Close();
            }
          

        }
        public void join(DataGridView dataGridView1, TextBox search)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT s.stud_name,e.ex_name,es.grade FROM student_information s inner join Exam_student es on s.stud_id=es.stu_id inner join Exam e on es.ex_id=e.ex_ID where stud_name =N'" + search.Text + "';", con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void join2(DataGridView dataGridView1, TextBox search)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT s.stud_name,c.time,c.date FROM student_information s inner join Attendance_tab at on s.stud_id=at.stu_id inner join class c on c.class_id=at.class_ID where stud_name =N'" + search.Text + "';", con);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void search_by_id(TextBox search, TextBox Name, TextBox id, TextBox phone, TextBox gmail, TextBox gender, TextBox parent_phone, TextBox status)
        {
            
            SqlConnection con = new SqlConnection(Program.path);

            string selectSql = "SELECT * FROM student_information WHERE stud_id ='" + search.Text + "';";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();


                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Name.Text = read["stud_name"].ToString();
                        id.Text = read["stud_id"].ToString();
                        phone.Text = read["stud_phone"].ToString();
                        gmail.Text = read["stud_gmail"].ToString();
                        gender.Text = read["Gender"].ToString();
                        parent_phone.Text = read["parent_phone"].ToString();
                        status.Text = read["stud_status"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect input");
            }
            finally
            {
                con.Close();
            }
           
        }
        public void search_by_name(TextBox search, TextBox Name, TextBox id, TextBox phone, TextBox gmail, TextBox gender, TextBox parent_phone, TextBox status)
        {
         
            SqlConnection con = new SqlConnection(Program.path);
            string selectSql = "SELECT * FROM student_information WHERE stud_name =N'" + search.Text + "';";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();


                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Name.Text = read["stud_name"].ToString();
                        id.Text = read["stud_id"].ToString();
                        phone.Text = read["stud_phone"].ToString();
                        gmail.Text = read["stud_gmail"].ToString();
                        gender.Text = read["Gender"].ToString();
                        parent_phone.Text = read["parent_phone"].ToString();
                        status.Text = read["stud_status"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect input");
            }
            finally
            {
                con.Close();
            }

        }
        public void search_class(string date, DataGridView dataGridView1, string time)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT s.stud_name FROM student_information s inner join Attendance_tab a on s.stud_id=a.stu_id inner join class c on c.class_ID=a.class_ID where date ='" + date+ "' And time='" + time + "';", con);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void search_Quiz(TextBox ex_name, DataGridView dataGridView1)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT s.stud_id,s.stud_name,ex.grade,s.parent_phone FROM student_information s inner join Exam_student ex  on s.stud_id=ex.stu_id inner join Exam e on e.ex_ID = ex.ex_id where ex_name ='" + ex_name.Text + "';", con);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void All_Quiz( DataGridView dataGridView1)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Exam e", con);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void all_classes(string s, DataGridView dataGridView1)
        {
            SqlConnection con = new SqlConnection(Program.path);
            SqlCommand cmd = new SqlCommand("SELECT c.time FROM class c  where date ='" + s + "';", con);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;

                dataGridView1.DataSource = bsource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}








