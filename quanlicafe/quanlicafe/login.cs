using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanlicafe;
using System.Security.Cryptography;

namespace log_in
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public string GetMd5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String matkhau = textBox2.Text;
            
            String connString = @"Data Source=LAPTOP-BOACL9PB;Initial Catalog=cafe;Integrated Security=True";
            string Pass = GetMd5(matkhau);
            SqlConnection connection = new SqlConnection(connString);
            //connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from dbo.TaiKhoanNV where TaiKhoan ='" + textBox1.Text +"' and MatKhau = '" + Pass +"'  ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                fmenu_edit f = new fmenu_edit();
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập sai! Vui lòng nhập lại.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
