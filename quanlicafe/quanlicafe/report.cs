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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection connection = new SqlConnection(Program.connString);

            try

            {
                connection.Open();
                String sqlQuerry = "select	* from HoaDon where (NgHD)='" + dateTimePicker1.Value.ToShortDateString() + "'";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetDateTime(1).ToShortDateString();
                    //DateTime dt = (DateTime)reader.GetSqlDateTime(1);
                    row.Cells[1].Value = reader.GetTimeSpan(2).ToString();
                    
                    row.Cells[3].Value = reader.GetInt32(4).ToString();
                    row.Cells[4].Value = reader.GetInt32(5).ToString();
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
    }
}
