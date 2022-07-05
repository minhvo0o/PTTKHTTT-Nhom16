
namespace DangKyTiemChung.GUI
{
    partial class GUITraCuu
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
            this.view_dskhachhang = new System.Windows.Forms.DataGridView();
            this.bt_xem = new System.Windows.Forms.Button();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.bt_lapphieu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.thongtintimkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_dskhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // view_dskhachhang
            // 
            this.view_dskhachhang.AllowUserToAddRows = false;
            this.view_dskhachhang.AllowUserToDeleteRows = false;
            this.view_dskhachhang.AllowUserToResizeColumns = false;
            this.view_dskhachhang.AllowUserToResizeRows = false;
            this.view_dskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_dskhachhang.Location = new System.Drawing.Point(275, 148);
            this.view_dskhachhang.Name = "view_dskhachhang";
            this.view_dskhachhang.RowHeadersWidth = 51;
            this.view_dskhachhang.RowTemplate.Height = 24;
            this.view_dskhachhang.Size = new System.Drawing.Size(500, 384);
            this.view_dskhachhang.TabIndex = 0;
            this.view_dskhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_dskhachhang_CellClick);
            // 
            // bt_xem
            // 
            this.bt_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xem.Location = new System.Drawing.Point(55, 183);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(129, 81);
            this.bt_xem.TabIndex = 1;
            this.bt_xem.Text = "Xem thông tin";
            this.bt_xem.UseVisualStyleBackColor = true;
            this.bt_xem.Click += new System.EventHandler(this.xem_Click);
            // 
            // bt_dangky
            // 
            this.bt_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangky.Location = new System.Drawing.Point(55, 425);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(129, 81);
            this.bt_dangky.TabIndex = 2;
            this.bt_dangky.Text = "Dăng ký KH";
            this.bt_dangky.UseVisualStyleBackColor = true;
            this.bt_dangky.Click += new System.EventHandler(this.dangky_Click);
            // 
            // bt_lapphieu
            // 
            this.bt_lapphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lapphieu.Location = new System.Drawing.Point(55, 302);
            this.bt_lapphieu.Name = "bt_lapphieu";
            this.bt_lapphieu.Size = new System.Drawing.Size(129, 81);
            this.bt_lapphieu.TabIndex = 3;
            this.bt_lapphieu.Text = "Lập phiếu tiêm";
            this.bt_lapphieu.UseVisualStyleBackColor = true;
            this.bt_lapphieu.Click += new System.EventHandler(this.lapphieu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tra cứu khách hàng:";
            // 
            // thongtintimkiem
            // 
            this.thongtintimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtintimkiem.Location = new System.Drawing.Point(423, 105);
            this.thongtintimkiem.Name = "thongtintimkiem";
            this.thongtintimkiem.Size = new System.Drawing.Size(312, 28);
            this.thongtintimkiem.TabIndex = 7;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackgroundImage = global::DangKyTiemChung.Properties.Resources.fa0e7b992eff03c576727e95c746005c;
            this.bt_timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Location = new System.Drawing.Point(741, 95);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(56, 44);
            this.bt_timkiem.TabIndex = 8;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // GUITraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 544);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.thongtintimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_lapphieu);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.bt_xem);
            this.Controls.Add(this.view_dskhachhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUITraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_dskhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_dskhachhang;
        private System.Windows.Forms.Button bt_xem;
        private System.Windows.Forms.Button bt_dangky;
        private System.Windows.Forms.Button bt_lapphieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thongtintimkiem;
        private System.Windows.Forms.Button bt_timkiem;
    }
}