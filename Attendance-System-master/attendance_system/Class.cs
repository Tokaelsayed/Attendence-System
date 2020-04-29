using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Year
{
    class Class
    {
        private int class_id;
     

      
        private SqlConnection connection = new SqlConnection(Program.path);
        private SqlDataReader reader;
        private string selectSql;
        private SqlCommand command;

        public int find_class(string time , string date)
        {
            selectSql = "SELECT class_ID FROM class WHERE time ='" + time + "'and date ='" + date + "';";
            command = new SqlCommand(selectSql, connection);
            connection.Open();
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    class_id = reader.GetInt32(0);
                }
                else
                    MessageBox.Show("There are no classes");
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
            return class_id;
        }

        public bool check_theLast_class(int studID)
        {
            DateTime firstDay = getFirstDay();
            DateTime lastDay = firstDay.AddDays(6);

            List<int> lastClassID = new List<int>();
            int count = 0;
            connection.Open();
            while (!(lastDay.ToString().Equals(firstDay.ToString())))
            {
                selectSql = "SELECT class_id FROM class WHERE date ='" + firstDay + "';";
                command = new SqlCommand(selectSql, connection);
                try
                {
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lastClassID.Add(reader.GetInt32(0));
                            count++;

                        }
                        reader.Close();
                    }

                    firstDay = firstDay.AddDays(1);
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            connection.Close();
            return get_stud_class(lastClassID,studID);
        }

        public bool get_stud_class(List<int> lastClassID , int studID)
        {
            bool check = false;
            foreach (int n in lastClassID)
            {
                selectSql = "SELECT * FROM Attendance_tab WHERE stu_id ='" + studID + "' and class_id='" + n + "';";
                command = new SqlCommand(selectSql, connection);
                connection.Open();
                try
                {
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        check = true;
                        break;
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
            return check;
        }
        private DateTime getFirstDay()
        {
            DateTime firstDay = DateTime.Now.Date;
            DayOfWeek day = DateTime.Now.DayOfWeek;

            if (day.ToString().Equals("Saturday"))
                firstDay = firstDay.AddDays(-7);
            else if (day.ToString().Equals("Sunday"))
                firstDay = firstDay.AddDays(-8);
            else if (day.ToString().Equals("Monday"))
                firstDay = firstDay.AddDays(-9);
            else if (day.ToString().Equals("Tuesday"))
                firstDay = firstDay.AddDays(-10);
            else if (day.ToString().Equals("Wednesday"))
                firstDay = firstDay.AddDays(-11);
            else if (day.ToString().Equals("Thursday"))
                firstDay = firstDay.AddDays(-12);
            else if (day.ToString().Equals("Friday"))
                firstDay = firstDay.AddDays(-13);
            return firstDay;
        }
    }
}
