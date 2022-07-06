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
    public partial class GUICapNhatPhieuDKTiem : Form
    {
        public static GUICapNhatPhieuDKTiem instance;
        public TextBox maKH;
        public CheckBox checkDuocTiem;
        public CheckBox checkDaTiem;
        public String maDK;
        public DateTimePicker dateTiem;

        public GUICapNhatPhieuDKTiem()
        {
            InitializeComponent();
            instance = this;
            maKH = txtMaKH;

            checkDuocTiem = chkDuocTiem;
            checkDaTiem = chkDaTiem;
            dateTiem = timeTgTiem;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if ((chkDuocTiem.Checked != true) && (chkDaTiem.Checked == true))
                {
                    PhieuTiem.capNhatPhieuDKTiem(chkDuocTiem.Checked, false, maDK);
                    MessageBox.Show("Cần được sự cho phép của bác sĩ trước khi tiêm");
                    this.Close();
                }
                else
                {
                    PhieuTiem.capNhatPhieuDKTiem(chkDuocTiem.Checked, chkDaTiem.Checked, maDK);
                    GUITraCuuPhieuDKTiem.instance.loadData();
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }
    }
}
