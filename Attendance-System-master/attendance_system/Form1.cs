using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.SmoMetadataProvider;

using System.Diagnostics;

using System.Threading;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Second_Year
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to take backup?", "Backup", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {

                        string path = fbd.SelectedPath;
                        string path1 = Path.GetFullPath(Environment.CurrentDirectory);



                        //ServiceController service = new ServiceController(serviceName);
                        //try
                        //{
                        //    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                        //    service.Start();
                        //    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                        //}
                        //catch
                        //{
                        //    // ...
                        //}

                        foreach (Process Proc in Process.GetProcessesByName("sqlservr"))
                        {
                          
                               Proc.Kill();
                            
                             //Process Excel?
                        }

                       System.Threading.Thread.Sleep(500);

                        if (File.Exists(path + @"\second_year.mdf"))
                            File.Delete(path + @"\second_year.mdf");

                        if (File.Exists(path + @"\second_year_log.ldf"))
                            File.Delete(path + @"\second_year_log.ldf");

                        File.Copy(path1 + @"\second_year.mdf", path + @"\second_year.mdf");
                        File.Copy(path1 + @"\second_year_log.ldf", path + @"\second_year_log.ldf");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }







                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Home home = new Home();
            this.Controls.Add(home);
            home.Location = new Point(5, 0);
        }
    }
}
