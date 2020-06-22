using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    static class Program
    {

        static public String connString = @"Data Source=LAPTOP-BOACL9PB;Initial Catalog=cafe;Integrated Security=True";
        static public bool chucdanh =false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
