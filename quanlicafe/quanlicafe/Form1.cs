using iTextSharp.text;
using iTextSharp.text.pdf;
using quanlicafe;
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

namespace Project
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            lsvBill.Click += listView1_Click;
        }

        private int tien = 0;
        private int soluongloai = 0;


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCategory_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arr = new String[5];

            ListViewItem asd;
            arr[0] = cbDrink.SelectedItem.ToString();


            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select price,masp from sanpham where tensp = N'" + cbDrink.SelectedItem.ToString() + "'";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) break;//doc ko duo\
                    arr[1] = reader.GetInt32(0).ToString();
                    arr[4] = reader.GetInt32(1).ToString();
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

            arr[2] = nmDrinkCount.Value.ToString() ;

            arr[3] = (Int32.Parse(arr[2]) * Int32.Parse(arr[1])).ToString() ;

            asd = new ListViewItem(arr);

            ListViewItem test = lsvBill.FindItemWithText(arr[0]);
            if (test != null)
            {

                tien = tien - Int32.Parse(test.SubItems[3].Text.ToString());
                lsvBill.Items.Remove(test);
                arr[2] = (Int32.Parse(arr[2]) + Int32.Parse(test.SubItems[2].Text)).ToString();
                arr[3] = (Int32.Parse(arr[2]) * Int32.Parse(arr[1])).ToString();
                asd = new ListViewItem(arr);
                asd.Name = arr[4];
                lsvBill.Items.Add(asd);
                tien = tien + Int32.Parse(arr[3]);
                thanhtien.Text = tien.ToString();
            }
            else
            {
                tien = tien + Int32.Parse(arr[3]);
                asd.Name = arr[4];
                thanhtien.Text = tien.ToString();
                lsvBill.Items.Add(asd);
            }

            
        }
        
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDrink.Items.Clear();

            SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);

            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "select tensp from sanpham where loaisp = N'" + cbCategory.SelectedItem.ToString() + "'";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) break;//doc ko duoc thi return
                    cbDrink.Items.Add(reader.GetString(0));
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
            cbDrink.SelectedIndex = 0;


        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {



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
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) break;//doc ko duoc thi return
                    soluongloai++;
                    cbCategory.Items.Add(reader.GetString(0));
                   
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
            cbCategory.SelectedIndex = 0;




        }

        private void listView1_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = lsvBill.SelectedItems[0];
            if (MessageBox.Show("Do you really want to remove? ", firstSelectedItem.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lsvBill.Items.Remove(firstSelectedItem);
                tien = tien - Int32.Parse(firstSelectedItem.SubItems[3].ToString());
                thanhtien.Text = tien.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            thanhtoan tt = new thanhtoan(thanhtien.Text);
            tt.FormClosed += thanhtoanclose;
            tt.ShowDialog();
        }

        private void thanhtoanclose (object sender, FormClosedEventArgs e)
        {
            if(Program.Isedit == true)
            {
                Program.Isedit = false;
                SqlConnection connection = new SqlConnection(quanlicafe.Program.connString);


                int mahd=-123;
                try
                {
                    //Mo ket noi
                    connection.Open();
                    //Chuan bi cau lenh query viet bang SQL
                    String sqlQuery = "SELECT TOP 1 mahd FROM hoadon ORDER BY mahd DESC";
                    //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                    SqlDataReader reader = command.ExecuteReader();
                    //Su dung reader de doc tung dong du lieu
                    //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                    while (reader.HasRows)//con dong du lieu thi doc tiep
                    {
                        if (reader.Read() == false) break;//doc ko duoc thi return
                        mahd = reader.GetInt32(0);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    //xu ly khi ket noi co van de
                    MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
                    return;
                }
                catch (Exception ex)
                {
                    //xu ly khi ket noi co van de
                    MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi"); return;
                }
                finally
                {
                    connection.Close();
                }
                int i = 0;
                foreach(ListViewItem itemrow in lsvBill.Items)
                {
                    if (i == 0)
                    {
                        i++;
                        continue;
                    }

                    try
                    {
                        connection.Open();

                        String sqlQuery = "insert into cthd values ("+mahd.ToString()+", "+itemrow.Name+", "+itemrow.SubItems[2].Text+", "+itemrow.SubItems[3].Text+")";
                        //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                        command.ExecuteNonQuery();
                        //Su dung reader de doc tung dong du lieu
                        //va thuc hien thao tac xu ly mong muon voi du lieu doc len

                        
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
                        connection.Close();
                    }
                }
                i = 0;
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("C:/Users/HOME/Desktop/BillPhanTichThietKe/" + mahd + ".pdf", FileMode.Create));
                document.Open();


                PdfContentByte cb = writer.DirectContent;
                cb.BeginText();

                BaseFont f_cn = BaseFont.CreateFont("C:\\windows\\fonts\\Arial.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetFontAndSize(f_cn, 25);
                cb.SetTextMatrix(200, 800);
                cb.ShowText("The Coffee School");
                cb.SetFontAndSize(f_cn, 12);
                cb.SetTextMatrix(30, 700);
                cb.ShowText("So hoa don: " + mahd);
                cb.SetTextMatrix(400, 700);
                cb.ShowText(DateTime.Now.ToString());
                cb.SetTextMatrix(400, 650);
             

                cb.SetTextMatrix(30, 625);
                cb.ShowText("__________________________________________________________________________________");

                cb.SetTextMatrix(50, 600);
                cb.ShowText("Ten");
                cb.SetTextMatrix(200, 600);
                cb.ShowText("SL");
                cb.SetTextMatrix(300, 600);
                cb.ShowText("Don gia");
                cb.SetTextMatrix(400, 600);
                cb.ShowText("Thanh tien");
                int y = 570;
                foreach(ListViewItem itemrow in lsvBill.Items) {
                    if (i == 0)
                    {
                        i++;
                        continue;
                    }
                    cb.SetTextMatrix(50, y);
                    cb.ShowText(itemrow.SubItems[0].Text);
                    cb.SetTextMatrix(200, y);
                    cb.ShowText(itemrow.SubItems[2].Text);
                    cb.SetTextMatrix(300, y);
                    cb.ShowText(itemrow.SubItems[1].Text);
                    cb.SetTextMatrix(400, y);
                    cb.ShowText(itemrow.SubItems[3].Text);
                    y -= 30;
                }
                y -= 20;
                cb.SetTextMatrix(30, y + 25);
                cb.ShowText("__________________________________________________________________________________");


                cb.SetTextMatrix(30, y);
                cb.ShowText("Tong Tien");
                cb.SetTextMatrix(400, y);
                cb.ShowText(thanhtien.Text + "000");
                y -= 30;
               

                cb.EndText();


                document.Close();
                writer.Close();
                lsvBill.Clear();
            }
            else
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
