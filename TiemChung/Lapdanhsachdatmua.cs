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
    public partial class Lapdanhsachdatmua : Form
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        String str = @"Data Source=DESKTOP-UNNBSU0;Initial Catalog=TIEMNGUA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        String selected = "";
        String MADM = "";
        void loadData()
        {
            command = sqlConnection.CreateCommand();
            command.CommandText = "Select * from DatMua where DSDATMUA is null";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewDatMua.DataSource = table;
            using (SqlConnection conn = sqlConnection)
            {
                
                    string query = "select MADS from DSDatMua";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DSDatMua");
                    comboBox1.DisplayMember = "MADS";
                    comboBox1.ValueMember = "MADS";
                    comboBox1.DataSource = ds.Tables["DSDatMua"];
                
               
            }
        }
        public Lapdanhsachdatmua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(str))
            {
                var sql = "UPDATE DatMua SET DSDatMua=@DSDatMua WHERE MADM=@MADM";
                connection.Open();
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@MADM", MADM);
                    cmd.Parameters.AddWithValue("@DSDatMua", selected);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Lapdanhsachdatmua_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            loadData();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView drv = comboBox1.SelectedItem as DataRowView;
                selected = comboBox1.SelectedValue.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChonDatMua(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewDatMua.Rows[e.RowIndex];
            MADM = Convert.ToString(row.Cells["MADM"].Value);
        }
    }
}
