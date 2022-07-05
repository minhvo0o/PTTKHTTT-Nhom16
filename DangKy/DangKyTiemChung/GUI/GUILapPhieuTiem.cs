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
    public partial class GUILapPhieuTiem : Form
    {
        private int _stt = -1;

        public GUILapPhieuTiem()
        {
            InitializeComponent();
        }

        private void LapPhieuTiem_Load(object sender, EventArgs e)
        {
            MHVacXin.listvx.Clear();
            MHGoiTiem.listgt.Clear();
            radio_goi.Checked = true;
            ten.Text = GUITraCuu.hoten;
            makh.Text = GUITraCuu.makh;
            if(GUITraCuu.makh == null)
            {
                ten.Text = GUIDangNhap.hoten;
                makh.Text = GUIDangNhap.ma;
            }
            LoadData();
        }
        private void LoadData()
        {
            if (radio_le.Checked == true)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("STT", typeof(int));
                dt.Columns.Add("ID", typeof(String));
                dt.Columns.Add("Name", typeof(String));
                dt.Columns.Add("Price", typeof(int));
                int stt = 1;
                foreach (var item in MHVacXin.listvx)
                {
                    dt.Rows.Add(stt,item._mavx, item._tenvx, item._giatien);
                    stt++;
                }
                view_danhsach.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("STT", typeof(int));
                dt.Columns.Add("ID", typeof(String));
                dt.Columns.Add("Name", typeof(String));
                dt.Columns.Add("Price", typeof(int));
                int stt = 1;
                foreach (var item in MHGoiTiem.listgt)
                {
                    dt.Rows.Add(stt,item._magoi, item._tengoi, item._giatien);
                    stt++;
                }
                view_danhsach.DataSource = dt;
            }

        }
        private void Them_Click(object sender, EventArgs e)
        {
            if(radio_le.Checked == true)
            {
                MHVacXin f = new MHVacXin();
                f.ShowDialog();
                LoadData();
            }
            else if(radio_goi.Checked == true)
            {
                MHGoiTiem f = new MHGoiTiem();
                f.ShowDialog();
                LoadData();
            }
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            if(view_danhsach.Rows.Count > 0)
            {

            string makh = GUITraCuu.makh;
                if (makh == null)
                    makh = GUIDangNhap.ma;
            string mapt = "PT" + PhieuTiem.CountPT().ToString();
            DateTime thoigiantiem = thoigian.Value;
            PhieuTiem pt = new PhieuTiem(makh, mapt, MHGoiTiem.listgt, MHVacXin.listvx, thoigiantiem);
                try
                {
                    bool checkpt = PhieuTiem.ThemPT(pt);
                    if (checkpt == true)
                    {
                        if (radio_goi.Checked == true)
                        {
                            int index = 0;
                            foreach (var item in pt._goitiem)
                            {
                                PhieuTiem.ThemCT_GT(pt, index);
                                index++;
                            }
                        }
                        else if (radio_le.Checked == true)
                        {
                            int index = 0;
                            foreach (var item in pt._vacxin)
                            {
                                PhieuTiem.ThemCT_VX(pt, index);
                                index++;
                            }
                        }
                        MessageBox.Show("Thêm thành công");

                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                catch (Exception ex)
                {

                }
            this.Close();
            }
            else
            {
                MessageBox.Show("Không đủ dữ liệu để lập phiếu");
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radio_goi_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void radio_le_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (radio_goi.Checked == true && _stt > 0 )
            {
                MHGoiTiem.listgt.RemoveAt(_stt-1);
                _stt = -1;
                LoadData();
            }
            else if(radio_le.Checked == true && _stt > 0)
            {
                MHVacXin.listvx.RemoveAt(_stt - 1);
                _stt = -1;
                LoadData();
            }
        }

        private void view_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (view_danhsach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    view_danhsach.CurrentRow.Selected = true;
                    _stt = Int32.Parse(view_danhsach.Rows[e.RowIndex].Cells["STT"].FormattedValue.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }


    }
}
