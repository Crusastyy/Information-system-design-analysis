﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    static class Program
    {

        static public String connString = @"Data Source=HOME-PC;Initial Catalog=PhanTichThietKe;Integrated Security=True";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmenu_edit());
        }
    }
}
