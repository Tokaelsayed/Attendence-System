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

namespace Second_Year
{
    public partial class Review : UserControl
    {
        SqlConnection con = new SqlConnection(Program.path);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int stud_id = 0;
        Student stud = new Student();
        public Review()
        {
            InitializeComponent();
        }

        private void Stud_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OneStudent_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Choose_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Choose_comboBox.SelectedItem.Equals("Only one student"))
            {
                oneStudent_panel.Visible = true;
                allStud_panel.Visible = false;

            }
            else if (Choose_comboBox.SelectedItem.Equals("All students"))
            {
                allStud_panel.Visible = true;
                oneStudent_panel.Visible = false;
                stud.ret_students_info(stud_dgv);
            }
        }

        private void Choose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (typeOfSearch.SelectedIndex == 0)
            {
                stud.search_by_id(searchTxt, nameTxt, IdTxt, phoneTxt, gmailTxt, genderTxt, parentTxt, statTxt);
                if (nameTxt.Text != "")
                {
                    stud.join(QuizesDGV, nameTxt);
                    stud.join2(ClassesDGV, nameTxt);
                }

            }
            else if(typeOfSearch.SelectedIndex == 1)
            {
                stud.search_by_name(searchTxt, nameTxt, IdTxt, phoneTxt, gmailTxt, genderTxt, parentTxt, statTxt);
                if (nameTxt.Text != "")
                {
                    stud.join(QuizesDGV, searchTxt);
                    stud.join2(ClassesDGV, searchTxt);
                }
            }
        }

        private void typeOfSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.TextLength > 0)
            {
                searchBtn.Visible = true;
            }
            else
                searchBtn.Visible = false;

        }
        //Clear Data  
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            stud_id = 0;
        }
        private void stud_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stud_id = Convert.ToInt32(stud_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = stud_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = stud_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = stud_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = stud_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = stud_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();


        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from student_information", con);
            adapt.Fill(dt);
            stud_dgv.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (stud_id != 0)
            {
                cmd = new SqlCommand("delete student_information where stud_id=@stud_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@stud_id", stud_id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("update student_information set stud_name=@stud_name,stud_phone=@stud_phone,stud_gmail=@stud_gmail,stud_status=@stud_status,parent_phone=@parent_phone where stud_id=@stud_id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@stud_id", stud_id);
                    cmd.Parameters.AddWithValue("@stud_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@stud_phone", textBox2.Text);
                    cmd.Parameters.AddWithValue("@stud_gmail", textBox3.Text);
                    cmd.Parameters.AddWithValue("@stud_status", textBox4.Text);
                    cmd.Parameters.AddWithValue("@parent_phone", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

    

      
    }
}