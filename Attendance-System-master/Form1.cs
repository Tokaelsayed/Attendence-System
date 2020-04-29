using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_system
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Controls.Add(home);
            this.Logo.Visible = false;
            home.Location = new Point(5, 0);
            this.Controls.Remove(panel1);
        }
    }
}
