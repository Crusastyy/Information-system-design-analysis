using System;
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
    public partial class fedit_item : Form
    {

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
            //Tên món
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Loại
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nút chọn ảnh
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Giá
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            //Nút lưu thay đổi
        }

        private void fedit_item_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select * from SanPham where masp="+id;
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;
                    textBox1.Text =reader.GetString(3);
                    textBox3.Text =reader.GetString(1);
                    textBox4.Text = reader.GetInt32(4) + "000 đ";
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
