using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace httt
{
    public partial class DatMua : Form
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        String str= @"Data Source=DESKTOP-UNNBSU0;Initial Catalog=TIEMNGUA;Integrated Security=True";
        SqlDataAdapter adapter=new SqlDataAdapter();
        DataTable table = new DataTable();
        int dem = 1;
        String MAVX = "";
        String TENVX = "";
        double DONGIA ;
        double SOLUONG;
        void loadData()
        {
            command = sqlConnection.CreateCommand();
            command.CommandText = "Select * from VACXIN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public DatMua()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            loadData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String MADM = "DM" + dem;
            String MAKH = "unknown";
            dem++;
            using (var connection = sqlConnection)
            {
                var sql = "Insert into DatMua(MADM,MAKH,MAVX) values(@MADM,@MAKH,@MAVX)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@MADM", MADM);
                    cmd.Parameters.AddWithValue("@MAKH", MAKH);
                    cmd.Parameters.AddWithValue("@MAVX", MAVX);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ChonVacXin(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            MAVX = Convert.ToString(row.Cells["MAVX"].Value);
            TENVX = Convert.ToString(row.Cells["TENVX"].Value);
            DONGIA = Convert.ToDouble(row.Cells["DONGIA"].Value);
            SOLUONG = Convert.ToDouble(row.Cells["SOLUONG"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
