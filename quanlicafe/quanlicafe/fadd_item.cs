using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlicafe
{
    public partial class fadd_item : Form
    {
        private int checkhinhsp = 1, checkall = 0, checkten = 0, checkloai = 0, checkgia = 0;

        public fadd_item()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Tên món
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Mô tả
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFile.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                checkhinhsp = 0;
            }
        }

        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(textBox2.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
=======
            //Nút chọn ảnh
>>>>>>> b60e7e3504f71225d58719e62b6d79c5481d8cb2
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Giá
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (checkhinhsp == 1)
            {
                warningHinh.Show();
            
            }
            else {
                warningHinh.Hide();
            }

            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                warningTen.Show();
                checkten = 1;
            }
            else
            {
                warningTen.Hide();
                checkten = 0;
            }

            if (comboBox1.SelectedItem == null)
            {
                warningLoai.Show();
                checkloai = 1;
            }
            else
            {
                warningLoai.Hide();
                checkloai = 0;
            }

            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                warningGia.Show();
                checkgia = 1;
            }
            else
            {
                warningGia.Hide();
                checkgia = 0;
            }

            if (checkten==0 && checkgia==0 && checkloai==0 && checkhinhsp==0)
            {
                SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

                try
                {
                    //Mo ket noi
                    connection.Open();
                    //Chuan bi cau lenh query viet bang SQL
                    String sqlQuery = "insert into sanpham (loaisp,hinhsp,tensp,price) values(N'"+comboBox1.SelectedItem.ToString()+"','"+Convert.ToBase64String(converImgToByte())+"',N'"+textBox1.Text+"',"+textBox4.Text+")";
                    //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                     
                    //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                    command.ExecuteNonQuery();
                    //Su dung reader de doc tung dong du lieu
                    //va thuc hien thao tac xu ly mong muon voi du lieu doc 
                    MessageBox.Show("Them mon thanh cong");
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
=======
            //Nút thêm món
>>>>>>> b60e7e3504f71225d58719e62b6d79c5481d8cb2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void fadd_item_Load(object sender, EventArgs e)
        {
            textBox4.KeyPress += textBox1_KeyPress;

            warningGia.Visible = false;
            warningHinh.Hide();
            warningLoai.Hide();
            warningTen.Hide();

            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select * from loai";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc 
                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;
                    comboBox1.Items.Add(reader.GetString(0));
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
    }
}
