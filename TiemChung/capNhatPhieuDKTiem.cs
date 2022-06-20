using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTT
{
    public partial class capNhatPhieuDKTiem : Form
    {
        public static capNhatPhieuDKTiem instance;
        public TextBox maKH;
        public CheckBox checkDuocTiem;
        public CheckBox checkDaTiem;

        public DateTimePicker dateTiem;
        public capNhatPhieuDKTiem()
        {
            InitializeComponent();
            instance = this;
            maKH = txtMaKH;

            checkDuocTiem = chkDuocTiem;
            checkDaTiem = chkDaTiem;
            dateTiem = txtTgTiem;
        }

        private void txtTgTiem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void capNhatPhieuDKTiem_Load(object sender, EventArgs e)
        {

        }
    }
}
