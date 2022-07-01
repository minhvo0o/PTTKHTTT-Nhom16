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

namespace PTTKHTTT
{
    public partial class capNhatPhieuDKTiem : Form
    {
        public static capNhatPhieuDKTiem instance;
        public TextBox maKH;
        public CheckBox checkDuocTiem;
        public CheckBox checkDaTiem;
        public String maDK;

        SqlConnection sqlConn;
        String str = "Data Source=MINHVOPC;Initial Catalog=TIEMNGUA;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();


        public DateTimePicker dateTiem;
        public capNhatPhieuDKTiem()
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
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.PHIEUDANGKYTIEMCHUNG SET DUOCTIEM = @DUOCTIEM, DATIEM = @DATIEM WHERE MADK = @MADK", sqlConn))
                {
                    cmd.Parameters.AddWithValue("MADK", maDK);
                    cmd.Parameters.AddWithValue("DUOCTIEM", chkDuocTiem.Checked);
                    cmd.Parameters.AddWithValue("DATIEM", chkDaTiem.Checked);

                    if ((chkDuocTiem.Checked != true) && (chkDaTiem.Checked == true))  {
                        cmd.Parameters.AddWithValue("DATIEM", chkDaTiem.Checked = false);
                        MessageBox.Show("Cần được sự cho phép của bác sĩ trước khi tiêm");
                    } 
                    else
                    {
                        cmd.ExecuteNonQuery();
                        traCuuPhieuDKTiem.instance.loadData();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void capNhatPhieuDKTiem_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(str);
            sqlConn.Open();
        }
    }
}
