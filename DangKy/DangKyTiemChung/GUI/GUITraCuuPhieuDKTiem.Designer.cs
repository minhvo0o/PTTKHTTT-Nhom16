namespace DangKyTiemChung.GUI
{
    partial class GUITraCuuPhieuDKTiem
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
            this.titleTraCuu = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lsTiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lsTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTraCuu
            // 
            this.titleTraCuu.AutoSize = true;
            this.titleTraCuu.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTraCuu.Location = new System.Drawing.Point(327, 49);
            this.titleTraCuu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleTraCuu.Name = "titleTraCuu";
            this.titleTraCuu.Size = new System.Drawing.Size(382, 37);
            this.titleTraCuu.TabIndex = 0;
            this.titleTraCuu.Text = "Tra cứu phiếu đăng ký tiêm";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(60, 116);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(780, 22);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiem.Location = new System.Drawing.Point(875, 113);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lsTiem
            // 
            this.lsTiem.AllowUserToAddRows = false;
            this.lsTiem.AllowUserToDeleteRows = false;
            this.lsTiem.BackgroundColor = System.Drawing.Color.White;
            this.lsTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lsTiem.Location = new System.Drawing.Point(60, 169);
            this.lsTiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsTiem.Name = "lsTiem";
            this.lsTiem.RowHeadersWidth = 51;
            this.lsTiem.Size = new System.Drawing.Size(915, 370);
            this.lsTiem.TabIndex = 3;
            this.lsTiem.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lsTiem_CellContentDoubleClick);
            // 
            // GUITraCuuPhieuDKTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lsTiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.titleTraCuu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUITraCuuPhieuDKTiem";
            this.Text = "Tra cứu phiếu đăng ký tiêm";
            ((System.ComponentModel.ISupportInitialize)(this.lsTiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTraCuu;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView lsTiem;
    }
}