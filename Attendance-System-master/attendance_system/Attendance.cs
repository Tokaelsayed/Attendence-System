using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

using ZXing;
using ZXing.QrCode;

using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Second_Year
{
    public partial class Attendance : UserControl
    {
       static private VideoCaptureDevice finalframe;
       static private FilterInfoCollection capturedevice;
        
        private SqlConnection connection = new SqlConnection(Program.path);
       
        private string timenow;
        private string datenow;
       
        private SqlCommand command;
        public Attendance()
        {
            InitializeComponent();
        }

        //////////////////////////////// camera code////////////////////////////
        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            if (dayCB.SelectedItem != "" && yearCB.SelectedItem != "" && monthCB.SelectedItem != "" && hoursCB.SelectedItem != "" && minutesCB.SelectedItem != "")
            {
                capturedevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                string device = capturedevice[0].Name;
                finalframe = new VideoCaptureDevice(capturedevice[0].MonikerString);
                finalframe.NewFrame += new NewFrameEventHandler(finalframe_newframe);
                finalframe.Start();
                timer1.Start();
                GB.Enabled = true;

                timenow = hoursCB.SelectedItem.ToString() + ":" + minutesCB.SelectedItem.ToString() + ":00";
                datenow = yearCB.SelectedItem.ToString() + "-" + monthCB.SelectedItem.ToString() + "-" + dayCB.SelectedItem.ToString();
                string insertSql = "INSERT INTO  class (time , date) VALUES ('" + timenow + "','" + datenow + "')";
                command = new SqlCommand(insertSql, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                   
                }
                finally
                {
                    MessageBox.Show("Done");
                    connection.Close();
                }
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
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

        

        private void  attendance()
        {
            int studID, NewClassID;
            
            ////////////////////////////////////// find id of the new class /////////////////////////////////////////
            Class c = new Class();
            NewClassID = c.find_class(timenow, datenow);
            ////////////////////////////////////// Attendance /////////////////////////////////////////
            Student s = new Student();
            studID = s.attendance(resultNameTxt.Text, NewClassID);
            if (studID == -2)
            {
              
            }
            ////////////////////////////////////// check the last quiz /////////////////////////////////////////
            else
            {
                Exam q = new Exam();
                bool check = q.check_TheLast_Exam(studID);
                if (check)
                    last_Q.BackColor = Color.Green;
                else if (!check)
                    last_Q.BackColor = Color.Red;
                ////////////////////////////////////check the last class////////////////////////////////////
                check = c.check_theLast_class(studID);
                if (check)
                    last_C.BackColor = Color.Green;
                else if (!check)
                    last_C.BackColor = Color.Red;

                MessageBox.Show("Done!");
                // System.Threading.Thread.Sleep(5000);
                resultNameTxt.Text = "";
                last_C.BackColor = Color.White;
                last_Q.BackColor = Color.White;


            }
        }

         private void finalframe_newframe(object sender, NewFrameEventArgs e) {
             QrPic.Image = (Image)e.Frame.Clone();

         }

      static public  void Attendance_ControlRemoved()
         {
            try
            {
                if (finalframe.IsRunning == true)
                {
                    finalframe.Stop();
                    capturedevice.Clear();

                }
            }
            catch (Exception ex) { }
         }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                //QRCodeDecoder decoder = new QRCodeDecoder();
                // string s = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                // MessageBox.Show(s);
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)QrPic.Image);
                if (last_C.BackColor != Color.Red && last_C.BackColor != Color.Green)
                {
                    resultNameTxt.Text = result.ToString().Trim();
                    attendance();
                }

               

            }
            catch (Exception ex) { }
        }

      
    }
}
