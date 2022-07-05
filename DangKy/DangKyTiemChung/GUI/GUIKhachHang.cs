using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyTiemChung.GUI
{
    public partial class GUIKhachHang : Form
    {
        public GUIKhachHang()
        {
            InitializeComponent();
        }

        private void XemThongTin_Click(object sender, EventArgs e)
        {
            GUIXemThongTinKH f = new GUIXemThongTinKH();
            f.ShowDialog();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            GUILapPhieuTiem f = new GUILapPhieuTiem();
            f.ShowDialog();
        }
    }
}
