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
       
        private void button1_Click(object sender, EventArgs e)
        {
            String matkhau = textBox2.Text;
            string hash;
            using (MD5 md5Hash = MD5.Create())
            
                hash = GetMd5Hash(md5Hash, matkhau);
            


            SqlConnection connection = new SqlConnection(Program.connString);
            //connection.Open();
            connection.Open();
            String sqlQuery = "Select chucdanh from nhanvien,TaiKhoanNV where TaiKhoan ='" + textBox1.Text + "' and MatKhau = '" + hash + "' and taikhoannv.Manv = nhanvien.Manv  " ;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;//doc ko duoc thi return


                Program.chucdanh = reader.GetBoolean(0);//xu ly khi da doc du lieu len
                this.Hide();
                Home f = new Home();
                f.Show();
            }
            else
            
                MessageBox.Show("Đăng nhập sai! Vui lòng nhập lại.");
            
        }

        private bool VerifyMd5Hash(MD5 md5Hash, object source, string hash)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

    }
}
