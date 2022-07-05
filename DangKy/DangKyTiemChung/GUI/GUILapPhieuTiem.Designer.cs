
namespace DangKyTiemChung.GUI
{
    partial class GUILapPhieuTiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.them = new System.Windows.Forms.Button();
            this.view_danhsach = new System.Windows.Forms.DataGridView();
            this.radio_le = new System.Windows.Forms.RadioButton();
            this.radio_goi = new System.Windows.Forms.RadioButton();
            this.thoigian = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.makh = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.huy = new System.Windows.Forms.Button();
            this.xacnhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(370, 183);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(99, 37);
            this.them.TabIndex = 31;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.Them_Click);
            // 
            // view_danhsach
            // 
            this.view_danhsach.AllowUserToAddRows = false;
            this.view_danhsach.AllowUserToDeleteRows = false;
            this.view_danhsach.AllowUserToResizeColumns = false;
            this.view_danhsach.AllowUserToResizeRows = false;
            this.view_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_danhsach.Location = new System.Drawing.Point(37, 237);
            this.view_danhsach.Name = "view_danhsach";
            this.view_danhsach.RowHeadersWidth = 51;
            this.view_danhsach.RowTemplate.Height = 24;
            this.view_danhsach.Size = new System.Drawing.Size(564, 192);
            this.view_danhsach.TabIndex = 30;
            this.view_danhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_danhsach_CellClick);
            // 
            // radio_le
            // 
            this.radio_le.AutoSize = true;
            this.radio_le.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_le.Location = new System.Drawing.Point(176, 188);
            this.radio_le.Name = "radio_le";
            this.radio_le.Size = new System.Drawing.Size(92, 24);
            this.radio_le.TabIndex = 29;
            this.radio_le.TabStop = true;
            this.radio_le.Text = "Tiêm lẻ";
            this.radio_le.UseVisualStyleBackColor = true;
            this.radio_le.CheckedChanged += new System.EventHandler(this.radio_le_CheckedChanged);
            // 
            // radio_goi
            // 
            this.radio_goi.AutoSize = true;
            this.radio_goi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_goi.Location = new System.Drawing.Point(33, 188);
            this.radio_goi.Name = "radio_goi";
            this.radio_goi.Size = new System.Drawing.Size(102, 24);
            this.radio_goi.TabIndex = 28;
            this.radio_goi.TabStop = true;
            this.radio_goi.Text = "Tiêm gói";
            this.radio_goi.UseVisualStyleBackColor = true;
            this.radio_goi.CheckedChanged += new System.EventHandler(this.radio_goi_CheckedChanged);
            // 
            // thoigian
            // 
            this.thoigian.CustomFormat = "hh:mm dd/MM/yyyy";
            this.thoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thoigian.Location = new System.Drawing.Point(278, 448);
            this.thoigian.Name = "thoigian";
            this.thoigian.Size = new System.Drawing.Size(200, 27);
            this.thoigian.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Thời gian:";
            // 
            // makh
            // 
            this.makh.AutoSize = true;
            this.makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makh.Location = new System.Drawing.Point(196, 115);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(184, 20);
            this.makh.TabIndex = 25;
            this.makh.Text = "Mã Khách Hàng: 00001";
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(196, 77);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(214, 20);
            this.ten.TabIndex = 24;
            this.ten.Text = "Bệnh nhân: Nguyễn Văn An";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phiếu đăng ký tiêm vắc xin";
            // 
            // huy
            // 
            this.huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy.Location = new System.Drawing.Point(381, 554);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(110, 53);
            this.huy.TabIndex = 22;
            this.huy.Text = "Hủy ";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // xacnhan
            // 
            this.xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacnhan.Location = new System.Drawing.Point(189, 554);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(109, 53);
            this.xacnhan.TabIndex = 21;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã khách hàng:";
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(502, 183);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(99, 37);
            this.xoa.TabIndex = 34;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // GUILapPhieuTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 619);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.them);
            this.Controls.Add(this.view_danhsach);
            this.Controls.Add(this.radio_le);
            this.Controls.Add(this.radio_goi);
            this.Controls.Add(this.thoigian);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.makh);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.xacnhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUILapPhieuTiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapPhieuTiem";
            this.Load += new System.EventHandler(this.LapPhieuTiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_danhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView view_danhsach;
        private System.Windows.Forms.RadioButton radio_le;
        private System.Windows.Forms.RadioButton radio_goi;
        private System.Windows.Forms.DateTimePicker thoigian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label makh;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button xacnhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xoa;
    }
}