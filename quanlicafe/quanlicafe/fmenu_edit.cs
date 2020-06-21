using quanlicafe.Properties;
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
    public partial class fmenu_edit : Form
    {
        public fmenu_edit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fadd_item add = new fadd_item();
            add.ShowDialog();
        }

        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
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

        private void Form1_Load(object sender, EventArgs e)
        {

           
            Point newP = new Point();
                //for (int i = 0; i < 20; i++)
                //{

                //    TextBox test = new TextBox();
                //    foreach (Control ct in panel5.Controls)
                //    {
                //        newP = ct.Location;
                //        newP.Y += ct.Size.Height;
                //        test.Name = i.ToString();
                //        test.Text = "Textbox " + i.ToString();
                //    }
                //    test.Location = newP;
                //    panel5.Controls.Add(test);
                //}
            //for (int i = 0; i < 12; i++) {
                
            //}


            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select * from SanPham";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                int i = -1;
                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;//doc ko duoc thi return
                                                       //xu ly khi da doc du lieu len
                    i++;
                    Panel nd = new Panel();
                    nd.Size = new Size(420, 58);
                    Label tenSP = new Label();
                    tenSP.Size = new Size(128, 18);
                    tenSP.Font = new Font("Georgia", 12);
                    tenSP.Location = new Point(75, 22);
                    tenSP.Text = reader.GetString(3);
                    Label Loaisp = new Label();
                    Loaisp.Size = new Size(23, 13);
                    Loaisp.Location = new Point(75, 9);
                    Loaisp.Text = reader.GetString(1);
                    Label price = new Label();
                    price.Size = new Size(62, 16);
                    price.Location = new Point(331, 4);
                    price.Font = new Font("Arial Rounded MT Bold", 10);
                    price.Text = reader.GetInt32(4).ToString()+ ".000 đ";
                    PictureBox hinhSP = new PictureBox();
                    hinhSP.Size = new Size(57, 54);
                    hinhSP.Location = new Point(0, 2);
                    hinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    hinhSP.Image = ByteToImg(reader.GetString(2));
                    PictureBox editbtn = new PictureBox();
                    editbtn.Size = new Size(34, 32);
                    editbtn.SizeMode = PictureBoxSizeMode.StretchImage;
                    editbtn.Location = new Point(350, 22);
                    editbtn.Image = quanlicafe.Properties.Resources.pictureBox2;

                    foreach (Control ct in panel5.Controls)
                    {
                        newP = ct.Location;
                        newP.Y += ct.Size.Height;
                        newP.X = 0;
                    }
                    editbtn.Name = reader.GetInt32(0).ToString();
                    editbtn.Click += edit_click;
                    tenSP.Name = i.ToString();
                    nd.Name = "panel"+i.ToString();
                    nd.Controls.Add(tenSP);
                    nd.Controls.Add(hinhSP);
                    nd.Controls.Add(editbtn);
                    nd.Controls.Add(price);
                    nd.Location = newP;
                    panel5.Controls.Add(nd);

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

        private void edit_click(object sender, EventArgs e)
        {
            var btn = (PictureBox)sender;

            fedit_item edit_item = new fedit_item(btn.Name);
            edit_item.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fedit_item f = new fedit_item();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
