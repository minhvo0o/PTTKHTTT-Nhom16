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

namespace WinFormsApp1
{
    
    public partial class MHDSHoaDon : Form
    {
        public static MHDSHoaDon instance;

        private string connectionString = @"Data Source=PHONG\SQLEXPRESS; Initial Catalog=TIEMNGUA;Integrated Security=True;";
        private string cmdStr = @"
                select distinct *
                from Hoadon hd, Phieudangkytiemchung pdk, CT_Dangki_goitiem dk_gt, 
                Goitiemchung g, khach_hang kh
                where hd.maphieudk = pdk.madk and pdk.madk = dk_gt.madk and dk_gt.magtc = g.magtc 
                and kh.makh = hd.makh ";

        public MHDSHoaDon()
        {
            InitializeComponent();
            instance = this;
            dtgv1.AutoGenerateColumns = false;
            getGVdata(cmdStr + ";");

        }

        private void getGVdata(string cmdString)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(cmdString, sqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dttb1 = new DataTable();
            adapter.Fill(dttb1);

            DataTable dttb2 = new DataTable();

            int i = 0;
            int n = dttb1.Rows.Count;
            while (i< n)
            {
                bool flag = false;
                DataRow row = dttb1.Rows[i];
                if (i< n - 1)
                {
                    if (row["mahd"].ToString() == dttb1.Rows[i+1]["mahd"].ToString()){
                        flag = true;
                    }
                }
                if (flag)
                {
                    dttb1.Rows[i].SetField("tengoitiem", row["tengoitiem"].ToString() + "  " 
                        + dttb1.Rows[i + 1]["tengoitiem"]);
                    dttb1.Rows[i + 1].Delete();
                    i++;
                }
                i++;
            }

            dtgv1.DataSource = dttb1;
            sqlCon.Close();
        }

        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchText_Click(sender, e);
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            string searchStr = searchBox.Text;
            if (searchStr == "")
            {
                getGVdata(cmdStr + ";");
            }
            if (searchStr.Any(char.IsDigit))
            {
                string cmdString1 = cmdStr + " and hd.mahd like '%" + searchStr + "%';";
                getGVdata(cmdString1);
            }
            else
            {
                string cmdString1 = cmdStr + " and kh.hoten like '%" + searchStr + "%';";
                getGVdata(cmdString1);
            }            
        }

        private void searchText_Click(object sender, EventArgs e)
        {
            this.searchText.Visible = false;
            this.searchBox.Focus();
        }

        private void searchBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                searchBtn_Click_1(sender, e);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MHCTHoaDon();
            newForm.Text = "create";
            newForm.ShowDialog();
            this.Close();
        }

        private void dtgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string mahd = dtgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Hide();
                var newForm = new MHCTHoaDon();
                newForm.Text = mahd;
                newForm.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something wrong!");
            }
        }
    }
}
