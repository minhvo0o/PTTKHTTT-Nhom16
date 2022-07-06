namespace DangKyTiemChung.GUI
{
    partial class GUICapNhatPhieuDKTiem
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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.chkDuocTiem = new System.Windows.Forms.CheckBox();
            this.chkDaTiem = new System.Windows.Forms.CheckBox();
            this.lblTgTiem = new System.Windows.Forms.Label();
            this.timeTgTiem = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleCapNhat
            // 
            this.titleCapNhat.AutoSize = true;
            this.titleCapNhat.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCapNhat.Location = new System.Drawing.Point(79, 38);
            this.titleCapNhat.Name = "titleCapNhat";
            this.titleCapNhat.Size = new System.Drawing.Size(211, 30);
            this.titleCapNhat.TabIndex = 0;
            this.titleCapNhat.Text = "Phiếu đăng ký tiêm";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(61, 91);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(89, 15);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(64, 115);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(226, 23);
            this.txtMaKH.TabIndex = 2;
            // 
            // chkDuocTiem
            // 
            this.chkDuocTiem.AutoSize = true;
            this.chkDuocTiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuocTiem.Location = new System.Drawing.Point(64, 165);
            this.chkDuocTiem.Name = "chkDuocTiem";
            this.chkDuocTiem.Size = new System.Drawing.Size(81, 19);
            this.chkDuocTiem.TabIndex = 3;
            this.chkDuocTiem.Text = "Được tiêm";
            this.chkDuocTiem.UseVisualStyleBackColor = true;
            // 
            // chkDaTiem
            // 
            this.chkDaTiem.AutoSize = true;
            this.chkDaTiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDaTiem.Location = new System.Drawing.Point(64, 206);
            this.chkDaTiem.Name = "chkDaTiem";
            this.chkDaTiem.Size = new System.Drawing.Size(67, 19);
            this.chkDaTiem.TabIndex = 4;
            this.chkDaTiem.Text = "Đã tiêm";
            this.chkDaTiem.UseVisualStyleBackColor = true;
            // 
            // lblTgTiem
            // 
            this.lblTgTiem.AutoSize = true;
            this.lblTgTiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgTiem.Location = new System.Drawing.Point(61, 249);
            this.lblTgTiem.Name = "lblTgTiem";
            this.lblTgTiem.Size = new System.Drawing.Size(83, 15);
            this.lblTgTiem.TabIndex = 5;
            this.lblTgTiem.Text = "Thời gian tiêm";
            // 
            // timeTgTiem
            // 
            this.timeTgTiem.Enabled = false;
            this.timeTgTiem.Location = new System.Drawing.Point(64, 272);
            this.timeTgTiem.Name = "timeTgTiem";
            this.timeTgTiem.Size = new System.Drawing.Size(226, 20);
            this.timeTgTiem.TabIndex = 6;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXacNhan.Location = new System.Drawing.Point(112, 320);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(122, 28);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // GUICapNhatPhieuDKTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 381);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.timeTgTiem);
            this.Controls.Add(this.lblTgTiem);
            this.Controls.Add(this.chkDaTiem);
            this.Controls.Add(this.chkDuocTiem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.titleCapNhat);
            this.Name = "GUICapNhatPhieuDKTiem";
            this.Text = "Cập nhật phiếu đăng ký tiêm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleCapNhat;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.CheckBox chkDuocTiem;
        private System.Windows.Forms.CheckBox chkDaTiem;
        private System.Windows.Forms.Label lblTgTiem;
        private System.Windows.Forms.DateTimePicker timeTgTiem;
        private System.Windows.Forms.Button btnXacNhan;
    }
}