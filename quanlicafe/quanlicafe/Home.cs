﻿using System;
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
            
           if(Program.chucdanh == true)
            employee.Hide();
            
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmenu_edit f = new fmenu_edit();
            f.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to log out? ","Log out",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                log_in.Login f = new log_in.Login();
                f.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cai nay la nut Report
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
            //Cai nay la nut Menu
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            //Cai nay la nut Payment
            Project.fTableManager f = new Project.fTableManager();
            f.ShowDialog();
        }
    }
}
