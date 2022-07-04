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

namespace WinFormsApp1
{
    public partial class MHCTHoaDon : Form
    {
        public static MHCTHoaDon instance;
            
        private string connectionString = @"Data Source=PHONG\SQLEXPRESS; Initial Catalog=TIEMNGUA;Integrated Security=True;";
        private string cmdStr = @"
                select distinct *
                from Hoadon hd, Phieudangkytiemchung pdk, CT_Dangki_goitiem dk_gt, 
                Goitiemchung g, ct_goitiemchung ct_g, vacxin vx, khach_hang kh
                where hd.maphieudk = pdk.madk and pdk.madk = dk_gt.madk and dk_gt.magtc = g.magtc 
                and ct_g.magtc = g.magtc and ct_g.mavx = vx.mavx and kh.makh = hd.makh";
        public MHCTHoaDon()
        {
            InitializeComponent();
            instance = this;
        }

        private void MHCTHoaDon_Load(object sender, EventArgs e)
        {
            if (this.Text == "create")
            {
                grandTitle.Text = "LẬP HOÁ ĐƠN";
                this.Text = grandTitle.Text;
                finishBtn.Text = "Hoàn Tất";
                view_mode(false);

            }
            else
            {
                view_mode(true);
                try
                {
                    loadData(cmdStr, this.Text);
                }
                catch
                {

                }
                grandTitle.Text = "XEM HOÁ ĐƠN";
                this.Text = grandTitle.Text;
                finishBtn.Text = "Chỉnh Sửa Hoá Đơn";
            }
            paymentInstallment_CB_SelectedIndexChanged(sender, e);
        }


        private DataTable getDataTable(string cmdString)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand(cmdString, sqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            return dt1;
            sqlCon.Close();
        }
        private void loadData(string cmdString, string mahd)
        {

            string cmd = cmdString + " and mahd = '" + mahd + "';";
            DataTable dt1 = getDataTable(cmd); 

            string padding = "";

            billCode_txt.Text = padding + dt1.Rows[0]["mahd"].ToString();
            registerCode_txt.Text = padding + dt1.Rows[0]["maphieudk"].ToString();
            clientCode_txt.Text = padding + dt1.Rows[0]["makh"].ToString();
            clientName_txt.Text = padding + dt1.Rows[0]["hoten"].ToString();
            vaccinePackage_txt.Text = padding + dt1.Rows[0]["TenGoiTiem"].ToString();
            vaccine_txt.Text = padding + dt1.Rows[0]["TenVacXin"].ToString();
            injectDay_txt.Text = padding + get_date(dt1.Rows[0]["ThoiGianTiem"].ToString());

            if (dt1.Rows[0]["PPThanhToan"].ToString() == "tiền mặt")
            {
                paymentMethod_CB.Text = "Tiền mặt";
            }
            else
            {
                paymentMethod_CB.Text = "Thẻ tín dụng";
            }

            if (dt1.Rows[0]["trangthai"].ToString() == "True")
            {
                paymentStatus.Text = "Đã thanh toán";
            }
            else
            {
                paymentStatus.Text = "Đang tiến hành";
            }

            totalPayment2_txt.Text = padding + dt1.Rows[0]["Tongtien"];
            totalPayment_txt.Text = padding + dt1.Rows[0]["Tongtien"];

            paymentDay_txt.Text = padding + get_date(dt1.Rows[0]["NgayThanhToan"].ToString());

            if (dt1.Rows[0]["tragop"].ToString() == "True")
            {
                installmentPayment_CB.Text = padding + "Trả góp theo đợt";
                loadInstallmentPayment(mahd);
            }
            else
            {
                installmentPayment_CB.Text = padding + "Thanh toán một lần";
            }
        }

        private void loadInstallmentPayment(string mahd)
        {
            string cmdString = @"select distinct * 
                            from hoadon hd, CT_HoaDon cthd
                            where hd.mahd = cthd.mahd and hd.mahd = '" + mahd + "';";

            string padding = "";

            DataTable dt = getDataTable(cmdString);

            paymentAmount1_txt.Text = padding + dt.Rows[0]["TienDongLan1"].ToString();
            paymentAmount2_txt.Text = padding + dt.Rows[0]["TienDongLan2"].ToString();
            paymentAmount3_txt.Text = padding + dt.Rows[0]["TienDongLan3"].ToString();

            paymentDay1_txt.Text = padding + get_date(dt.Rows[0]["NgayDongLan1"].ToString());
            paymentDay2_txt.Text = padding + get_date(dt.Rows[0]["NgayDongLan2"].ToString());
            paymentDay3_txt.Text = padding + get_date(dt.Rows[0]["NgayDongLan3"].ToString());

            if (dt.Rows[0]["TinhTrangLan3"].ToString() == "True")
            {
                paymentProgress_txt.Text = padding + "Đã hoàn thành";
            }
            else if (dt.Rows[0]["TinhTrangLan2"].ToString() == "True")
            {
                paymentProgress_txt.Text = padding + "Lần 3";
            }
            else if (dt.Rows[0]["TinhTrangLan1"].ToString() == "True")
            {
                paymentProgress_txt.Text = padding + "Lần 2";
            }
            else
            {
                paymentProgress_txt.Text = padding + "Lần 1";
            }
        }

        private string get_date(string date)
        {
            DateTime result;
            DateTime.TryParse(date, out result);
            return result.ToString("d");
        }

        private void view_mode(bool prevent)
        {
            billCode_txt.ReadOnly = prevent;
            clientCode_txt.ReadOnly = prevent;
            clientName_txt.ReadOnly = prevent;
            injectDay_txt.ReadOnly = prevent;
            registerCode_txt.ReadOnly = prevent;
            vaccinePackage_txt.ReadOnly = prevent;
            vaccine_txt.ReadOnly = prevent;
            paymentMethod_CB.Enabled = !prevent;
            installmentPayment_CB.Enabled = !prevent;
            totalPayment_txt.ReadOnly = prevent;
            totalPayment2_txt.ReadOnly = prevent;
            paymentDay_txt.ReadOnly = prevent;
            paymentAmount1_txt.ReadOnly = prevent;
            paymentAmount2_txt.ReadOnly = prevent;
            paymentAmount3_txt.ReadOnly = prevent;
            paymentDay1_txt.ReadOnly = prevent;
            paymentDay2_txt.ReadOnly = prevent;
            paymentDay3_txt.ReadOnly = prevent;
        }

        private void paymentInstallment_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (installmentPayment_CB.Text == "Trả góp theo đợt")
            {
                paymentArea.Size = new Size(606, 322 + 70);
                payment_TablePannel.Size = new Size(498, 70);
                installmentPayment_TB.Location = new Point(57, 111);
                fullPayment_TB.Hide();
                installmentPayment_TB.Show();
                finishBtn.Location = new Point(275, 795 + 70);
                this.Size = new Size(814, 910 + 70);
                goback.Location = new Point(670, 795 + 70);
            }
            else
            {
                paymentArea.Size = new Size(606, 186);
                fullPayment_TB.Location = new Point(57, 111);
                installmentPayment_TB.Hide();
                fullPayment_TB.Show();
                finishBtn.Location = new Point(275, 807 - 322 + 186);
                this.Size = new Size(814, 921 - 322 + 186);
                goback.Location = new Point(670, 815 - 326 + 186);
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (finishBtn.Text == "Hoàn Tất")
            {

                try
                {
                    insertHD();
                    MessageBox.Show("Thành Công");
                }
                catch
                {
                    MessageBox.Show("Không tạo được hoá đơn. Kiểm tra lại thông tin.");
                }
            }
            else if (finishBtn.Text == "Chỉnh Sửa Hoá Đơn")
            {
                view_mode(false);
                finishBtn.Text = "Cập Nhật Hoá Đơn";
                grandTitle.Text = "Chỉnh Sửa Hoá Đơn";
                this.Text = "Chỉnh Sửa Hoá Đơn";
                this.Refresh();
            }
            else if (finishBtn.Text == "Cập Nhật Hoá Đơn")
            {
                try
                {
                    updateHD();
                    MessageBox.Show("Thành Công");
                }
                catch
                {
                    MessageBox.Show("Hoá đơn không được cập nhật. Kiểm tra lại thông tin.");
                }
            }
            else
            {
                this.Refresh();
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MHDSHoaDon();
            newForm.ShowDialog();
            this.Close();
        }

        private void insertHD()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string cmdString = @"insert into Hoadon values(@mahd, @makh,NULL, @maphieudk, @tongtien, 
                                @ppthanhtoan, @ngaytt, @trangthai, @tragop);";
            SqlCommand cmd = new SqlCommand(cmdString, sqlCon);
            cmd.Parameters.AddWithValue("@mahd", billCode_txt.Text);
            cmd.Parameters.AddWithValue("@makh", clientCode_txt.Text);
            cmd.Parameters.AddWithValue("@maphieudk", registerCode_txt.Text);
            cmd.Parameters.AddWithValue("@trangthai", false);

            if (paymentMethod_CB.Text == "Tiền mặt")
            {
                cmd.Parameters.AddWithValue("@ppthanhtoan", "tiền mặt");
            }
            else
            {
                cmd.Parameters.AddWithValue("@ppthanhtoan", "thẻ");
            }

            if (installmentPayment_CB.Text == "Trả góp theo đợt")
            {
                cmd.Parameters.AddWithValue("@tragop", true); 
                cmd.Parameters.AddWithValue("@tongtien", int.Parse(totalPayment2_txt.Text));
                cmd.Parameters.AddWithValue("@ngaytt", get_date(paymentDay3_txt.Text));
                cmd.ExecuteNonQuery();


                string cmdString2 = @"insert into ct_hoadon values(@mahd,@tiendonglan1,@ngaydonglan1, 0,
                        @tiendonglan2, @ngaydonglan2, 0,
                        @tiendonglan3, @ngaydonglan3, 0);";

                SqlCommand cmd2 = new SqlCommand(cmdString2, sqlCon);
                cmd2.Parameters.AddWithValue("@mahd", billCode_txt.Text);
                cmd2.Parameters.AddWithValue("@tiendonglan1", int.Parse(paymentAmount1_txt.Text));
                cmd2.Parameters.AddWithValue("@ngaydonglan1", get_date(paymentDay1_txt.Text));
                cmd2.Parameters.AddWithValue("@tiendonglan2", int.Parse(paymentAmount2_txt.Text));
                cmd2.Parameters.AddWithValue("@ngaydonglan2", get_date(paymentDay2_txt.Text));
                cmd2.Parameters.AddWithValue("@tiendonglan3", int.Parse(paymentAmount3_txt.Text));
                cmd2.Parameters.AddWithValue("@ngaydonglan3", get_date(paymentDay3_txt.Text));

                cmd2.ExecuteNonQuery();
            }
            else
            {
                cmd.Parameters.AddWithValue("@tragop", false);
                cmd.Parameters.AddWithValue("@tongtien", int.Parse(totalPayment_txt.Text));
                cmd.Parameters.AddWithValue("@ngaytt", get_date(paymentDay_txt.Text));
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }

        private void updateHD()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string cmdString = @"
                update Hoadon
                set 
	                makh = @makh, 
	                manv = NULL,
	                maphieudk = @maphieudk,
	                ppthanhtoan = @ppthanhtoan,
	                ngaythanhtoan = @ngaythanhtoan
                where mahd = @mahd;";

            SqlCommand cmd = new SqlCommand(cmdString, sqlCon);

            cmd.Parameters.AddWithValue("@mahd", billCode_txt.Text);
            cmd.Parameters.AddWithValue("@makh", clientCode_txt.Text);
            cmd.Parameters.AddWithValue("@maphieudk", registerCode_txt.Text);
            cmd.Parameters.AddWithValue("@ngaythanhtoan", get_date(paymentDay_txt.Text));

            if (paymentMethod_CB.Text == "Tiền mặt")
            {
                cmd.Parameters.AddWithValue("@ppthanhtoan", "tiền mặt");
            }
            else
            {
                cmd.Parameters.AddWithValue("@ppthanhtoan", "thẻ");
            }


            cmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void registerCode_txt_Leave(object sender, EventArgs e)
        {
            autoFill(registerCode_txt.Text);
        }

        private void autoFill(string mapdk)
        {
            string cmdString = String.Format(@"select distinct * 
                from phieudangkytiemchung dk, ct_dangki_goitiem ctdk, goitiemchung g, khach_hang kh
                where dk.madk = '{0}' and dk.madk = ctdk.madk and ctdk.magtc = g.magtc 
                    and kh.makh = dk.makh ;", mapdk);

            string cmdString2 = String.Format(@"select distinct dk.madk, tenvacxin
                from phieudangkytiemchung dk, ct_dangki_goitiem ctdk, goitiemchung g,
                    ct_goitiemchung ctg, vacxin vx
                where dk.madk = '{0}' and dk.madk = ctdk.madk and ctdk.magtc = g.magtc 
                    and g.magtc = ctg.magtc and ctg.mavx = vx.mavx ;", mapdk);
            try
            {
                string padding = "";
                DataTable dt = getDataTable(cmdString);
                //vaccinePackage_txt.Text = padding + dt.Rows[0]["TenGoiTiem"].ToString();
                injectDay_txt.Text = padding + get_date(dt.Rows[0]["ThoiGianTiem"].ToString());
                paymentDay_txt.Text = injectDay_txt.Text;
                paymentDay3_txt.Text = injectDay_txt.Text;
                clientName_txt.Text = dt.Rows[0]["hoten"].ToString();

                DateTime dueDate;
                DateTime.TryParse(injectDay_txt.Text, out dueDate);

                TimeSpan diff = (dueDate - DateTime.Now) / 3;

                clientCode_txt.Text = padding + dt.Rows[0]["MaKH"].ToString();

                paymentDay2_txt.Text = padding + get_date((dueDate - diff).ToString());
                paymentDay1_txt.Text = padding + get_date((dueDate - diff * 2).ToString());

                int totalPayment = 0;
                string goitiem = "";
                foreach( DataRow row in dt.Rows)
                {
                    totalPayment += int.Parse(row["GiaTien"].ToString());
                    goitiem += row["TenGoiTiem"].ToString() + "  ";
                }

                vaccinePackage_txt.Text = goitiem;

                totalPayment_txt.Text = padding + totalPayment.ToString();
                totalPayment2_txt.Text = padding + totalPayment.ToString();
                paymentAmount1_txt.Text = padding + (totalPayment / 2).ToString();
                paymentAmount2_txt.Text = padding + (totalPayment / 4).ToString();
                paymentAmount3_txt.Text = padding + (totalPayment / 4).ToString();

                DataTable dt2 = getDataTable(cmdString2);
                string vaccine = "";
                foreach(DataRow row in dt2.Rows)
                {
                    vaccine += row["TenVacXin"].ToString() +  "  ";
                }
                vaccine_txt.Text = vaccine;
            }
            catch
            {
                MessageBox.Show("Mã phiếu đăng ký không đúng");
            }            
        }
    }
}
