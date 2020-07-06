using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class fprofile : Form
    {
        public fprofile()
        {
            InitializeComponent();
            SDT.KeyPress += number_only;
            Email.KeyPress += sqlinject;
            
        }

        private int manv;

        private void sqlinject(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"'))
            {
                e.Handled = true;
            }
        }

        private void number_only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }


        private bool check = false;
        private void emp_changepass_Click(object sender, EventArgs e)
        {
            c f = new c(Program.MaNV);
            f.ShowDialog();
        }

        private void fprofile_Load(object sender, EventArgs e)
        {
            check = false;
            button_ok.Text = "OK";
            SqlConnection connection = new SqlConnection(Program.connString);

            //connection.Open();
            try
            {


                connection.Open();
                String sqlQuery = "Select * from nhanvien where  Manv = " + Program.MaNV;
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;//doc ko duoc thi return
                    HoTen.Text = reader.GetString(1);
                    SDT.Text = reader.GetString(3);
                    Email.Text = reader.GetString(5);
                    if (Program.chucdanh == false)
                    {
                        ChucDanh.Text = "Nhân viên";
                    }
                    else
                    {
                        ChucDanh.Text = "Quản lý";
                    }
                    NgaySinh.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                    radio_female.Enabled = false;
                    radio_male.Enabled = false;
                    if (reader.GetBoolean(4) == true)
                    {
                        radio_male.Checked = true;
                    }
                    else
                    {
                        radio_female.Checked = true;
                    }

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
            SDT.TextChanged += SDT_TextChanged;
            Email.TextChanged += Email_TextChanged;
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            check = true;
            button_ok.Text = "Save";
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            check = true;
            button_ok.Text = "Save";
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(Email.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                }
                else {
                    Regex phonevali = new Regex(@"^(\+[0-9]{9})$");
                    if (!(Regex.Match(SDT.Text, @"^([0-9]{10})$").Success|| Regex.Match(SDT.Text, @"^([0-9]{11})$").Success))
                    {
                        MessageBox.Show("Phone number is invalid");
                    }

                    else
                    {
                        SqlConnection connection = new SqlConnection(Program.connString);

                        //connection.Open();
                        try
                        {
                            connection.Open();
                            String sqlQuery = "update nhanvien set sdt ='" + SDT.Text + "', email='" + Email.Text + "' where manv=" + Program.MaNV + ";";
                            sqlQuery += "update khachhang set sdt ='" + SDT.Text + "' where hoten =N'" + HoTen.Text + "';";
                            SqlCommand command = new SqlCommand(sqlQuery, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Đã cập nhật thông tin thành công");
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
            else
            {
                this.Close();
            }
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
