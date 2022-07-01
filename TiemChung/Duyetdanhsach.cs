using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace httt
{
    public partial class Duyetdanhsach : Form
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        String str = @"Data Source=DESKTOP-UNNBSU0;Initial Catalog=TIEMNGUA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        String MADS = "";
        public Duyetdanhsach()
        {
            InitializeComponent();
        }

        void loadData()
        {
            command = sqlConnection.CreateCommand();
            command.CommandText = "Select * from DSDatMua where DUYET is null";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewDuyet.DataSource = table;
        }
        private void Duyetdanhsach_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            loadData();
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            using (var connection = sqlConnection)
            {
                var sql = "UPDATE DSDatMua SET DUYET=@DUYET WHERE MADS=@MADS";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@DUYET", 1);
                    cmd.Parameters.AddWithValue("@MADS", MADS);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChonDanhSachDatMua(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewDuyet.Rows[e.RowIndex];
            MADS = Convert.ToString(row.Cells["MADS"].Value);
        }
    }
}
