
namespace DangKyTiemChung.GUI
{
    partial class GUIKhachHang
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
            this.XemThongTin = new System.Windows.Forms.Button();
            this.DangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XemThongTin
            // 
            this.XemThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemThongTin.Location = new System.Drawing.Point(73, 108);
            this.XemThongTin.Name = "XemThongTin";
            this.XemThongTin.Size = new System.Drawing.Size(180, 67);
            this.XemThongTin.TabIndex = 0;
            this.XemThongTin.Text = "Xem thông tin";
            this.XemThongTin.UseVisualStyleBackColor = true;
            this.XemThongTin.Click += new System.EventHandler(this.XemThongTin_Click);
            // 
            // DangKy
            // 
            this.DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKy.Location = new System.Drawing.Point(384, 108);
            this.DangKy.Name = "DangKy";
            this.DangKy.Size = new System.Drawing.Size(180, 67);
            this.DangKy.TabIndex = 1;
            this.DangKy.Text = "Đăng ký phiếu tiêm";
            this.DangKy.UseVisualStyleBackColor = true;
            this.DangKy.Click += new System.EventHandler(this.DangKy_Click);
            // 
            // GUIKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 302);
            this.Controls.Add(this.DangKy);
            this.Controls.Add(this.XemThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "GUIKhachHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XemThongTin;
        private System.Windows.Forms.Button DangKy;
    }
}