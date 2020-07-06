using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class c : Form
    {
        public c()
        {
            InitializeComponent();
            current_pass.KeyPress += sqlinject;
            new_pass.KeyPress += sqlinject;
            confirm_pass.KeyPress += sqlinject;
        }

        private int manv;
        private String sql_pass;

        public c(int manv)
        {
            InitializeComponent();
            this.manv = manv;
            current_pass.KeyPress += sqlinject;
            new_pass.KeyPress += sqlinject;
            confirm_pass.KeyPress += sqlinject;
            SqlConnection connection = new SqlConnection(Program.connString);

            //connection.Open();
            try
            {


                connection.Open();
                String sqlQuery = "select matkhau from taikhoannv where manv = " + manv;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;//doc ko duoc thi return
                    sql_pass = reader.GetString(0);
                }
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
        }

        private void sqlinject(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Chỗ này nhập pass mới
        }

        private void change_pass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Chỗ này nhập Pass cũ
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirm_pass_TextChanged(object sender, EventArgs e)
        {
            //Chỗ này confirm pass mới
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            




            String matkhau = current_pass.Text;
            String hash;
            using (MD5 md5Hash = MD5.Create())

                hash = GetMd5Hash(md5Hash, matkhau);

            if(String.Compare(hash,sql_pass)!=0)
            {
                MessageBox.Show("Current password is not correct.");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(new_pass.Text) || String.IsNullOrWhiteSpace(confirm_pass.Text))
                {
                    MessageBox.Show("New password can not be empty.");
                }
                else
                {
                    if (String.Compare(new_pass.Text, confirm_pass.Text) != 0)
                    {
                        MessageBox.Show("New password and confirm password are not the same.");
                    }
                    else
                    {
                        matkhau = new_pass.Text;
                        using (MD5 md5Hash = MD5.Create())
                            hash = GetMd5Hash(md5Hash, matkhau);

                        SqlConnection connection = new SqlConnection(Program.connString);

                        //connection.Open();
                        try
                        {


                            connection.Open();
                            String sqlQuery = "update taikhoannv set matkhau ='"+hash+"' where manv =" + manv;
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("New password had been updated.");
                            this.Close();
                        }
                        catch (InvalidOperationException ex)
                        {
                            //xu ly khi ket noi co van de
                            MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
                        }
                        catch (Exception ex)
                        {
                            //xu ly khi ket noi co van de
                            MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                        }
                        finally
                        {
                            //Dong ket noi sau khi thao tac ket thuc
                            connection.Close();
                        }





                    }
                }
            }

            


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
