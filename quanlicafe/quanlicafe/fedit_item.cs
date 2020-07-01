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
    public partial class fedit_item : Form
    {
        private bool checkten = false, checkloai = false, checkgia = false, checkhinh = false, checkall = true;
        String hinhsp;
        private string id;
        public fedit_item()
        {
            InitializeComponent();
        }

        public fedit_item(string i) : this()
        {
            id = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFile.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                checkhinh = true;
                hinhsp = Convert.ToBase64String(converImgToByte());
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                warningTen.Show();
                checkten = true;
            }
            else
            {
                warningTen.Hide();
                checkten = false;
            }

            if (comboBox1.SelectedItem == null)
            {
                warningLoai.Show();
                checkloai = true;
                checkall = checkall && false;
            }
            else
            {
                warningLoai.Hide();
                checkloai = false;
            }

            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                warningGia.Show();
                checkgia = true;
                checkall = false;
            }
            else
            {
                warningGia.Hide();
                checkgia = false;
            }

            if (!(checkgia && checkten && checkloai))
            {
                SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

                try
                {
                    //Mo ket noi
                    connection.Open();
                    //Chuan bi cau lenh query viet bang SQL
                    String sqlQuery = "update sanpham set tensp =N'" + textBox1.Text + "', loaisp=N'" + comboBox1.SelectedItem.ToString() + "', price = " + textBox4.Text + ", hinhsp = '" + hinhsp + "' where masp =" + id;
                    //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                    command.ExecuteNonQuery();
                    //Su dung reader de doc tung dong du lieu
                    //va thuc hien thao tac xu ly mong muon voi du lieu doc 
                    MessageBox.Show("Sua mon thanh cong");
                    quanlicafe.Program.Isedit = true;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fedit_item_Load(object sender, EventArgs e)
        {

            warningGia.Hide();
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
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
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



            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL


                String sqlQuery = "select * from SanPham where masp=" + id;
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai

                SqlCommand command2 = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu

                SqlDataReader reader = command2.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;
                    textBox1.Text = reader.GetString(3);
                    comboBox1.Text = reader.GetString(1);
                    textBox4.Text = reader.GetInt32(4).ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    hinhsp = reader.GetString(2);
                    pictureBox1.Image = ByteToImg(hinhsp);
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
        }
    }
}