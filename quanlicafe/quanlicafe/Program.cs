using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    static class Program
    {
<<<<<<< HEAD
        static public bool Isedit = false;
        static public String connString = @"Data Source=HOME-PC;Initial Catalog=PhanTichThietKe;Integrated Security=True";
=======

        static public String connString = @"Data Source=LAPTOP-BOACL9PB;Initial Catalog=cafe;Integrated Security=True";
>>>>>>> b60e7e3504f71225d58719e62b6d79c5481d8cb2
        static public bool chucdanh =false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new log_in.Login());
=======
            Application.Run(new Home());
>>>>>>> b60e7e3504f71225d58719e62b6d79c5481d8cb2
        }
    }
}
