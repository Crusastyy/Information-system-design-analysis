using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            fprofile f = new fprofile();
            f.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
           
        }

        private void menu_Click(object sender, EventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to log out? ","Log out",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Nút Report
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fmenu_edit f = new fmenu_edit();
            f.FormClosed += form_close;
            f.Show();
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            //Nút tính tiền
            Project.fTableManager f = new Project.fTableManager();
            f.ShowDialog();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            if(Program.chucdanh == false)
            {
                MessageBox.Show("Bạn không có quyền để thực hành hành động này");
            }
        }

        private void customer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
