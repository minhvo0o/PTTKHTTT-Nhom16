using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangKyTiemChung.DAL;

namespace DangKyTiemChung.GUI
{
    public partial class GUIDangNhap : Form
    {
        public GUIDangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string tk = taikhoan.Text.ToString();
            string mk = matkhau.Text.ToString();
            if (TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Hướng dẫn")
            {
                GUITraCuu tc = new GUITraCuu();
                this.Hide();
                tc.ShowDialog();
                this.Close();
            }
            //TK BacSi / Nhan vien y te
            else if (TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Bác sĩ")
            {
                GUITraCuuPhieuDKTiem tcpdk = new GUITraCuuPhieuDKTiem();
                this.Hide();
                tcpdk.ShowDialog();     
                this.Close();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
        }

        private void GUIDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
