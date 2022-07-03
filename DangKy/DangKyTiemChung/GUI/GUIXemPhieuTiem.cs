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
    public partial class GUIXemPhieuTiem : Form
    {
        public GUIXemPhieuTiem()
        {
            InitializeComponent();
        }

        private void XemPhieuTiem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            PhieuTiem.LayTT_PT(GUITraCuu.makh).Fill(dt);
            view_phieudangky.DataSource = dt;
        }
    }
}
