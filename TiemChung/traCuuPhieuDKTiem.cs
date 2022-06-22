using System.Data.SqlClient;
using System.Data;

namespace PTTKHTTT
{
    public partial class traCuuPhieuDKTiem : Form
    {
        public static traCuuPhieuDKTiem instance;
        SqlConnection sqlConn;
        SqlCommand sqlCmd;

        String str = "Data Source=MINHVOPC;Initial Catalog=TIEMNGUA;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        public void loadData()
        {
            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM PHIEUDANGKYTIEMCHUNG";
            dataAdapter.SelectCommand = sqlCmd;

            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            lsTiem.DataSource = dataTable;
        }


        public traCuuPhieuDKTiem()
        {
            InitializeComponent();
            instance = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void traCuuPhieuDKTiem_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(str);
            sqlConn.Open();
            loadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {              
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUDANGKYTIEMCHUNG WHERE MAKH=@MAKH", sqlConn))
                {
                    if (txtMaKH.Text != "") { 
                        cmd.Parameters.AddWithValue("MAKH", txtMaKH.Text);
                        dataAdapter.SelectCommand = cmd;
                        dataTable.Clear();
                        dataAdapter.Fill(dataTable);
                        lsTiem.DataSource = dataTable;
                    } else { loadData(); }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                btnTimKiem.PerformClick();
        }

        private void lsTiem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = lsTiem.CurrentRow.Index;
            capNhatPhieuDKTiem f2 = new capNhatPhieuDKTiem();
            f2.Show();

            capNhatPhieuDKTiem.instance.maDK = lsTiem.Rows[i].Cells[0].Value.ToString();
            capNhatPhieuDKTiem.instance.maKH.Text = lsTiem.Rows[i].Cells[1].Value.ToString();
            
            if (lsTiem.Rows[i].Cells[2].Value.ToString().Equals("True"))
            {
                capNhatPhieuDKTiem.instance.checkDuocTiem.Checked = true;
            }

            if (lsTiem.Rows[i].Cells[3].Value.ToString().Equals("True"))
            {
                capNhatPhieuDKTiem.instance.checkDaTiem.Checked = true;
            }

            capNhatPhieuDKTiem.instance.dateTiem.Text = Convert.ToDateTime(lsTiem.Rows[i].Cells[4].Value).ToString();
            //System.Diagnostics.Debug.WriteLine(Convert.ToDateTime(lsTiem.Rows[i].Cells[4].Value));
        }
    }
}