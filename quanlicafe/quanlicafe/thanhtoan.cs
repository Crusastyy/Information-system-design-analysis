using System;
using quanlicafe;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class thanhtoan : Form
    {
        public thanhtoan()
        {
            InitializeComponent();
            Tienkhach.KeyPress += textBox1_KeyPress;
        }

        public thanhtoan(string tien)
        {

            InitializeComponent();
            Tongtien.Text = tien.ToString();
            Tienkhach.KeyPress += textBox1_KeyPress;
            khachhang.KeyPress += number_only;
        }

        private void number_only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tienkhach_TextChanged(object sender, EventArgs e)
        {
            Tienthoi.Text = (-Int32.Parse(Tongtien.Text) + Int32.Parse(Tienkhach.Text)).ToString();
        }

        private void thanhtoan_Load(object sender, EventArgs e)
        {
            Tienthoi.Text = (-Int32.Parse(Tongtien.Text) + Int32.Parse(Tienkhach.Text)).ToString();
        }

        private int makh = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Tienthoi.Text) < 0)
            {
                MessageBox.Show("Tiền khách không đủ.");
                return;
            }

            if (!String.IsNullOrWhiteSpace(khachhang.Text))
            {


                SqlConnection connection1 = new SqlConnection(quanlicafe.Program.connString);

                try
                {
                    //Mo ket noi
                    connection1.Open();
                    //Chuan bi cau lenh query viet bang SQL
                    String sqlQuery = "select makh from khachhang where sdt = '" + khachhang.Text+"'";
                    //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                    SqlCommand command = new SqlCommand(sqlQuery, connection1);
                    //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                    SqlDataReader reader = command.ExecuteReader();
                    //Su dung reader de doc tung dong du lieu
                    //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                    while (reader.HasRows)//con dong du lieu thi doc tiep
                    {
                        if (reader.Read() == false) break;//doc ko duo\
                        makh = reader.GetInt32(0);
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
                    connection1.Close();
                }
                connection1 = new SqlConnection(quanlicafe.Program.connString);

                try
                {
                    //Mo ket noi
                    connection1.Open();
                    //Chuan bi cau lenh query viet bang SQL
                    String sqlQuery = "update khachhang set tichluy = " + Tongtien.Text + " where makh =" + makh;
                    //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                    SqlCommand command = new SqlCommand(sqlQuery, connection1);
                    //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                    

                    
                    
                    command.ExecuteNonQuery();
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
                    connection1.Close();
                }
            }
                

            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into hoadon (nghd,thoigianhd,makh,trigia,manv) values (getdate(),getdate()," + ((makh == -1) ? "null" : makh.ToString()) + ", "+Tongtien.Text+", "+Program.MaNV+")";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                Program.Isedit = true;
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
