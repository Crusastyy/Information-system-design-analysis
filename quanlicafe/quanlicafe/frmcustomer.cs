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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmadd_customer f = new frmadd_customer();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmedit_customer f = new frmedit_customer();
            f.ShowDialog();
        }
    }
}
