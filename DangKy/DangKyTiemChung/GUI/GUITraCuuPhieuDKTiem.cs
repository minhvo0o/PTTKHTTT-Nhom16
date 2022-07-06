using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangKyTiemChung.BLL;

namespace DangKyTiemChung.GUI
{
    public partial class GUITraCuuPhieuDKTiem : Form
    {
        public static GUITraCuuPhieuDKTiem instance;
        DataTable dataTable = new DataTable();

        public void loadData()
        {
            dataTable.Clear();
            PhieuTiem.layDSPhieuDKTiem().Fill(dataTable);
            lsTiem.DataSource = dataTable;
        }

        public GUITraCuuPhieuDKTiem()
        {
            InitializeComponent();
            instance = this;
            loadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text.Length > 0)
                {
                    dataTable.Clear();
                    PhieuTiem.LayTT_PT(txtMaKH.Text).Fill(dataTable);
                    lsTiem.DataSource = dataTable;
                }
                else {loadData(); }
                
            }
            catch (Exception ex)
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
            GUICapNhatPhieuDKTiem f2 = new GUICapNhatPhieuDKTiem();
            f2.Show();

            GUICapNhatPhieuDKTiem.instance.maDK = lsTiem.Rows[i].Cells[0].Value.ToString();
            GUICapNhatPhieuDKTiem.instance.maKH.Text = lsTiem.Rows[i].Cells[1].Value.ToString();

            if (lsTiem.Rows[i].Cells[2].Value.ToString().Equals("True"))
            {
                GUICapNhatPhieuDKTiem.instance.checkDuocTiem.Checked = true;
            }

            if (lsTiem.Rows[i].Cells[3].Value.ToString().Equals("True"))
            {
                GUICapNhatPhieuDKTiem.instance.checkDaTiem.Checked = true;
            }

            GUICapNhatPhieuDKTiem.instance.dateTiem.Text = Convert.ToDateTime(lsTiem.Rows[i].Cells[4].Value).ToString();
            //System.Diagnostics.Debug.WriteLine(Convert.ToDateTime(lsTiem.Rows[i].Cells[4].Value));
        }
    }
}
