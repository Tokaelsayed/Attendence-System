using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Year
{
    public partial class Classes_Quizes : UserControl
    {
        Student stud = new Student();
        public Classes_Quizes()
        {
            InitializeComponent();
        }

        private void Classes_Quizes_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                    dayCB.Items.Add("0" + i.ToString());
                else
                    dayCB.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    monthCB.Items.Add("0" + i.ToString());
                    hoursCB.Items.Add("0" + i.ToString());
                }
                else
                {
                    monthCB.Items.Add(i.ToString());
                    hoursCB.Items.Add(i.ToString());
                }
            }
            for (int i = 2019; i <= 2050; i++)
            {
                yearCB.Items.Add(i.ToString());
            }
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                    minutesCB.Items.Add("0" + i.ToString());
                else
                    minutesCB.Items.Add(i.ToString());
            }




















        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("All Classes"))
            {
                string date = yearCB.Text + "-" + monthCB.Text + "-" + dayCB.Text;
                string time = hoursCB.Text + ":" + minutesCB.Text;
                stud.all_classes(date, dataGridView1);
              
            }
            else if(comboBox1.SelectedItem.Equals("All Quizes"))
            {
               
               
                stud.All_Quiz( dataGridView1);
           
            }
            else if (comboBox1.SelectedItem.Equals("Specific Class"))
            {
                
           

            if(yearCB.Text!="" && monthCB.Text!=""&& dayCB.Text!="")
                {
                    string date = yearCB.Text+"-"+monthCB.Text+"-"+dayCB.Text;
                    string time= hoursCB.Text + ":"+ minutesCB.Text ;
                    stud.search_class(date, dataGridView1,time);
                    Enter_Btn.Enabled = true;
                }
            else
                {
                    MessageBox.Show("Please Enter the Date of the Class !");
                }
            }
            else if (comboBox1.SelectedItem.Equals("Specific Quiz"))
            {
                if (textBox1.TextLength > 0)
                {
                    stud.search_Quiz(textBox1, dataGridView1);
                }
                else
                {
                    MessageBox.Show("Please Enter Quiz name!");
                }

            
            }
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Specific Quiz"))
            {
             
                ex_name.Visible = true;
                textBox1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                yearCB.Visible = false;
                monthCB.Visible = false;
                dayCB.Visible = false;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                if (textBox1.TextLength > 0)
                {

                    Enter_Btn.Enabled = true;


                }

            }
            else if (comboBox1.SelectedItem.Equals("All Classes"))
            {
                label2.Visible = false;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                ex_name.Visible = false;
                textBox1.Visible = false;
                label3.Visible = true;
                yearCB.Visible = true;
                monthCB.Visible = true;
                dayCB.Visible = true;
            }
            else if (comboBox1.SelectedItem.Equals("All Quizes"))
            {
                label2.Visible = false;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                ex_name.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                yearCB.Visible = false;
                monthCB.Visible = false;
                dayCB.Visible = false;
            }
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
                Enter_Btn.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            hoursCB.Visible = false;
            minutesCB.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Enter_Btn.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("All Classes"))
            {

                ex_name.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                yearCB.Visible = true;
                monthCB.Visible = true;
                dayCB.Visible = true;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                Enter_Btn.Enabled = true;
            }
            if (comboBox1.SelectedItem.Equals("All Quizes"))
            {

                ex_name.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                yearCB.Visible = false;
                monthCB.Visible = false;
                dayCB.Visible = false;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                Enter_Btn.Enabled = true;
            }
            if (comboBox1.SelectedItem.Equals("Specific Class"))
            {

                ex_name.Visible = false;
                textBox1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                yearCB.Visible = true;
                monthCB.Visible = true;
                dayCB.Visible = true;
                if (textBox1.TextLength > 0)
                {

                    Enter_Btn.Enabled = true;


                }
                hoursCB.Visible = true;
                minutesCB.Visible = true;

            }
            if (comboBox1.SelectedItem.Equals("Specific Quiz"))
            {

                ex_name.Visible = true;
                textBox1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                yearCB.Visible = false;
                monthCB.Visible = false;
                dayCB.Visible = false;
                hoursCB.Visible = false;
                minutesCB.Visible = false;
                Enter_Btn.Enabled = true;
                

            }

        }

     
    }
}
