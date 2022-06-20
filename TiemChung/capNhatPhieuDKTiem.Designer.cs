namespace PTTKHTTT
{
    partial class capNhatPhieuDKTiem
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
            this.titleCapNhat = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTgTiem = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTgTiem = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.chkDuocTiem = new System.Windows.Forms.CheckBox();
            this.chkDaTiem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleCapNhat
            // 
            this.titleCapNhat.AutoSize = true;
            this.titleCapNhat.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleCapNhat.Location = new System.Drawing.Point(58, 34);
            this.titleCapNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleCapNhat.Name = "titleCapNhat";
            this.titleCapNhat.Size = new System.Drawing.Size(221, 30);
            this.titleCapNhat.TabIndex = 0;
            this.titleCapNhat.Text = "Phiếu đăng ký tiêm";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(58, 86);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(89, 15);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblTgTiem
            // 
            this.lblTgTiem.AutoSize = true;
            this.lblTgTiem.Location = new System.Drawing.Point(58, 232);
            this.lblTgTiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTgTiem.Name = "lblTgTiem";
            this.lblTgTiem.Size = new System.Drawing.Size(83, 15);
            this.lblTgTiem.TabIndex = 3;
            this.lblTgTiem.Text = "Thời gian tiêm";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(58, 111);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(217, 23);
            this.txtMaKH.TabIndex = 6;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtTgTiem
            // 
            this.txtTgTiem.Location = new System.Drawing.Point(58, 257);
            this.txtTgTiem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTgTiem.Name = "txtTgTiem";
            this.txtTgTiem.Size = new System.Drawing.Size(217, 23);
            this.txtTgTiem.TabIndex = 8;
            this.txtTgTiem.ValueChanged += new System.EventHandler(this.txtTgTiem_ValueChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(112, 303);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(108, 28);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // chkDuocTiem
            // 
            this.chkDuocTiem.AutoSize = true;
            this.chkDuocTiem.Location = new System.Drawing.Point(58, 156);
            this.chkDuocTiem.Name = "chkDuocTiem";
            this.chkDuocTiem.Size = new System.Drawing.Size(81, 19);
            this.chkDuocTiem.TabIndex = 14;
            this.chkDuocTiem.Text = "Được tiêm";
            this.chkDuocTiem.UseVisualStyleBackColor = true;
            // 
            // chkDaTiem
            // 
            this.chkDaTiem.AutoSize = true;
            this.chkDaTiem.Location = new System.Drawing.Point(58, 192);
            this.chkDaTiem.Name = "chkDaTiem";
            this.chkDaTiem.Size = new System.Drawing.Size(67, 19);
            this.chkDaTiem.TabIndex = 15;
            this.chkDaTiem.Text = "Đã tiêm";
            this.chkDaTiem.UseVisualStyleBackColor = true;
            // 
            // capNhatPhieuDKTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 343);
            this.Controls.Add(this.chkDaTiem);
            this.Controls.Add(this.chkDuocTiem);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtTgTiem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblTgTiem);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.titleCapNhat);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "capNhatPhieuDKTiem";
            this.Text = "Cập nhật phiếu đăng ký tiêm";
            this.Load += new System.EventHandler(this.capNhatPhieuDKTiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleCapNhat;
        private Label lblMaKH;
        private Label lblTgTiem;
        private TextBox txtMaKH;
        private DateTimePicker txtTgTiem;
        private Button btnXacNhan;
        private CheckBox chkDuocTiem;
        private CheckBox chkDaTiem;
    }
}