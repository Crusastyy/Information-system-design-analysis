using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class fprofile : Form
    {
        public fprofile()
        {
            InitializeComponent();
        }

        private void emp_changepass_Click(object sender, EventArgs e)
        {
            c f = new c();
            f.ShowDialog();
        }
    }
}
