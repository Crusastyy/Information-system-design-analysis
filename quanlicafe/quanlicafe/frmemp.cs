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
    public partial class frmemp : Form
    {
        public frmemp()
        {
            InitializeComponent();
        }

        private void frmemp_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.connString);

            try

            {
                connection.Open();
                String sqlQuerry = "select	* from nhanvien ";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(1);
                    row.Cells[1].Value = reader.GetDateTime(2).ToShortDateString();
                    row.Cells[2].Value = reader.GetString(3);
                    bool asd = reader.GetBoolean(4);
                    if (asd == true)
                    {
                        row.Cells[3].Value = "nam";
                    }
                    else
                        row.Cells[3].Value = "nu";
                    row.Cells[4].Value = reader.GetString(5);
                    asd = reader.GetBoolean(6);
                    if (asd == true)
                    {
                        row.Cells[5].Value = "manager";
                    }
                    else
                        row.Cells[5].Value = "staff";
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi xay ra loi");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_but_Click(object sender, EventArgs e)
        {
            frmadd_emp f = new frmadd_emp();
            f.ShowDialog();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            frmedit_emp f = new frmedit_emp();
            f.ShowDialog();
        }
    }
}
