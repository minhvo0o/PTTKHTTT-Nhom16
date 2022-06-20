namespace PTTKHTTT
{
    partial class traCuuPhieuDKTiem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleTraCuu = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lsTiem = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lsTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTraCuu
            // 
            this.titleTraCuu.AutoSize = true;
            this.titleTraCuu.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleTraCuu.Location = new System.Drawing.Point(174, 19);
            this.titleTraCuu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleTraCuu.Name = "titleTraCuu";
            this.titleTraCuu.Size = new System.Drawing.Size(310, 30);
            this.titleTraCuu.TabIndex = 0;
            this.titleTraCuu.Text = "Tra cứu phiếu đăng ký tiêm";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(41, 70);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(494, 23);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // lsTiem
            // 
            this.lsTiem.AllowUserToAddRows = false;
            this.lsTiem.AllowUserToDeleteRows = false;
            this.lsTiem.BackgroundColor = System.Drawing.Color.White;
            this.lsTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lsTiem.Location = new System.Drawing.Point(41, 116);
            this.lsTiem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lsTiem.Name = "lsTiem";
            this.lsTiem.ReadOnly = true;
            this.lsTiem.RowHeadersWidth = 82;
            this.lsTiem.RowTemplate.Height = 41;
            this.lsTiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.lsTiem.Size = new System.Drawing.Size(585, 204);
            this.lsTiem.TabIndex = 2;
            this.lsTiem.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lsTiem_CellContentDoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiem.Location = new System.Drawing.Point(551, 70);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // traCuuPhieuDKTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 342);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lsTiem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.titleTraCuu);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "traCuuPhieuDKTiem";
            this.Text = "Tra cứu phiếu đăng ký tiêm";
            this.Load += new System.EventHandler(this.traCuuPhieuDKTiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lsTiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleTraCuu;
        private TextBox txtMaKH;
        private DataGridView lsTiem;
        private Button btnTimKiem;
    }
}