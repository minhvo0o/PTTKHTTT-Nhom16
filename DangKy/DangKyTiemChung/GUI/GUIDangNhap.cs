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
using DangKyTiemChung.BLL;

namespace DangKyTiemChung.GUI
{
    public partial class GUIDangNhap : Form
    {
        public static string ma = null;
        public static string hoten = null;
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
            else if(TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Bác sĩ")
            {
                MessageBox.Show("Bác sĩ");
            }
            else if (TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Y tế")
            {
                MessageBox.Show("Y tế");

            }
            else if(TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Đặt mua")
            {
                MessageBox.Show("Đăt mua");

            }
            else if (TaiKhoan.GetRole(tk, mk) == "nhanvien" && TaiKhoan.GetRoleNhanVien(tk, mk) == "Kế Toán")
            {
                MessageBox.Show("Kế toán");

            }
            else if(TaiKhoan.GetRole(tk, mk) == "khachhang")
            {
                GUIKhachHang f = new GUIKhachHang();
                KhachHang kh = new KhachHang();
                kh = KhachHang.LayTT_KH(TaiKhoan.GetId(tk,mk));
                ma = kh._makh;
                hoten = kh._hoten;
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng!");
        }

        private void GUIDangNhap_Load(object sender, EventArgs e)
        {
            sadjajwdpojapwodjdjpaowjdojjwodopwpodpwq445
                qjowdpoqjwdpojqpwdjpowqojqwopdjpqwpoqwdjp
        }
    }
}
