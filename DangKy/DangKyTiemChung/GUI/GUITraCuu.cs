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
    public partial class GUITraCuu : Form
    {
        public static string makh = null;
        public static string hoten = null;

        public GUITraCuu()
        {
            InitializeComponent();
        }

        private void xem_Click(object sender, EventArgs e)
        {
            GUIXemThongTinKH f = new GUIXemThongTinKH();
            f.ShowDialog();
        }

        private void lapphieu_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(makh))
            {
            GUILapPhieuTiem f = new GUILapPhieuTiem();
            f.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void dangky_Click(object sender, EventArgs e)
        {
            GUIDangKyKH f = new GUIDangKyKH();
            f.ShowDialog();
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            KhachHang.LayDS_KH().Fill(dt);
            view_dskhachhang.DataSource = dt;
        }


        private void timkiem_Click(object sender, EventArgs e)
        {
            string info = thongtintimkiem.Text;
            DataTable dt = new DataTable();
            KhachHang.TraCuuKH(info).Fill(dt);
            view_dskhachhang.DataSource = dt;
        }

        private void view_dskhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (view_dskhachhang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    view_dskhachhang.CurrentRow.Selected = true;
                    makh = view_dskhachhang.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();
                    hoten = view_dskhachhang.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
