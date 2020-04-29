using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Second_Year
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static string path1 = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "second_year.mdf";
        public static string path = @"Data Source=(localdb)\v11.0;AttachDbFilename=" + path1 + @"\" + databaseName + ";Integrated Security=True";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
