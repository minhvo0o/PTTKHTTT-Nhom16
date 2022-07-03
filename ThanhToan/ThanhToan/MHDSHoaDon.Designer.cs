namespace WinFormsApp1
{
    partial class MHDSHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHDSHoaDon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengoitiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchBtn = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(137, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(300, 188);
            this.dataGridView2.TabIndex = 0;
            // 
            // dtgv1
            // 
            this.dtgv1.AccessibleName = "";
            this.dtgv1.AllowUserToResizeColumns = false;
            this.dtgv1.AllowUserToResizeRows = false;
            this.dtgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.hoten,
            this.tengoitiem,
            this.Tongtien,
            this.Trangthai});
            this.dtgv1.Location = new System.Drawing.Point(54, 197);
            this.dtgv1.MultiSelect = false;
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.ReadOnly = true;
            this.dtgv1.RowHeadersVisible = false;
            this.dtgv1.RowHeadersWidth = 50;
            this.dtgv1.RowTemplate.Height = 100;
            this.dtgv1.RowTemplate.ReadOnly = true;
            this.dtgv1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv1.Size = new System.Drawing.Size(719, 257);
            this.dtgv1.TabIndex = 0;
            this.dtgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellDoubleClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.FillWeight = 45F;
            this.mahd.HeaderText = "Mã hoá đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên khách hàng";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // tengoitiem
            // 
            this.tengoitiem.DataPropertyName = "tengoitiem";
            this.tengoitiem.HeaderText = "Gói Tiêm";
            this.tengoitiem.MinimumWidth = 6;
            this.tengoitiem.Name = "tengoitiem";
            this.tengoitiem.ReadOnly = true;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.FillWeight = 70F;
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.FillWeight = 50F;
            this.Trangthai.HeaderText = "Hoàn Tất Thanh Toán";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(119, 81);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(579, 36);
            this.searchBox.TabIndex = 1;
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBox_MouseClick);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown_1);
            // 
            // searchText
            // 
            this.searchText.AutoSize = true;
            this.searchText.BackColor = System.Drawing.Color.White;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchText.ForeColor = System.Drawing.Color.Silver;
            this.searchText.Location = new System.Drawing.Point(120, 83);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(485, 30);
            this.searchText.TabIndex = 2;
            this.searchText.Text = "  Nhập mã hoá đơn, hoặc tên khách hàng cần tìm";
            this.searchText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(626, 85);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(67, 28);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "           ";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.White;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(54, 138);
            this.createBtn.Margin = new System.Windows.Forms.Padding(0);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(255, 44);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Tạo Hoá Đơn Mới";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title2.Location = new System.Drawing.Point(213, 15);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(391, 46);
            this.title2.TabIndex = 5;
            this.title2.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // MHDSHoaDon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 466);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dtgv1);
            this.Name = "MHDSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hoá Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dtgv1;
        private TextBox searchBox;
        private Label searchText;
        private ImageList imageList1;
        private Label searchBtn;
        private Button createBtn;
        private Label title2;
        private DataGridViewTextBoxColumn mahd;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn tengoitiem;
        private DataGridViewTextBoxColumn Tongtien;
        private DataGridViewCheckBoxColumn Trangthai;
    }
}