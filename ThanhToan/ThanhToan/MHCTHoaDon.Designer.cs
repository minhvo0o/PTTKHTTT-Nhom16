namespace WinFormsApp1
{
    partial class MHCTHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHCTHoaDon));
            this.grandTitle = new System.Windows.Forms.Label();
            this.contractArea = new System.Windows.Forms.Panel();
            this.billAreaTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.billCode_label = new System.Windows.Forms.Label();
            this.billCode_txt = new System.Windows.Forms.TextBox();
            this.clientCode_txt = new System.Windows.Forms.TextBox();
            this.registerCode_txt = new System.Windows.Forms.TextBox();
            this.clientName_txt = new System.Windows.Forms.TextBox();
            this.clientCode_label = new System.Windows.Forms.Label();
            this.registerCode_label = new System.Windows.Forms.Label();
            this.clientName_label = new System.Windows.Forms.Label();
            this.vaccineArea = new System.Windows.Forms.Panel();
            this.vaccineAreaTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.vaccinePackage_label = new System.Windows.Forms.Label();
            this.vaccinePackage_txt = new System.Windows.Forms.TextBox();
            this.injectDay_txt = new System.Windows.Forms.TextBox();
            this.vaccine_txt = new System.Windows.Forms.TextBox();
            this.injectDay_label = new System.Windows.Forms.Label();
            this.vaccine_label = new System.Windows.Forms.Label();
            this.installmentPayment_CB = new System.Windows.Forms.ComboBox();
            this.paymentMethod_label = new System.Windows.Forms.Label();
            this.paymentArea = new System.Windows.Forms.Panel();
            this.paymentStatus = new System.Windows.Forms.Label();
            this.fullPayment_TB = new System.Windows.Forms.TableLayoutPanel();
            this.totalPayment_txt = new System.Windows.Forms.TextBox();
            this.paymentDay_label = new System.Windows.Forms.Label();
            this.totalPayment_label = new System.Windows.Forms.Label();
            this.paymentDay_txt = new System.Windows.Forms.TextBox();
            this.installmentPayment_TB = new System.Windows.Forms.TableLayoutPanel();
            this.paymentAmount2_txt = new System.Windows.Forms.TextBox();
            this.paymentAmount2_label = new System.Windows.Forms.Label();
            this.paymentAmount1_label = new System.Windows.Forms.Label();
            this.paymentAmount1_txt = new System.Windows.Forms.TextBox();
            this.paymentDay1_label = new System.Windows.Forms.Label();
            this.paymentDay2_label = new System.Windows.Forms.Label();
            this.paymentDay2_txt = new System.Windows.Forms.TextBox();
            this.paymentAmount3_label = new System.Windows.Forms.Label();
            this.paymentDay3_label = new System.Windows.Forms.Label();
            this.paymentDay1_txt = new System.Windows.Forms.TextBox();
            this.paymentAmount3_txt = new System.Windows.Forms.TextBox();
            this.paymentDay3_txt = new System.Windows.Forms.TextBox();
            this.totalPayment2_label = new System.Windows.Forms.Label();
            this.paymentProgress_label = new System.Windows.Forms.Label();
            this.totalPayment2_txt = new System.Windows.Forms.TextBox();
            this.paymentProgress_txt = new System.Windows.Forms.TextBox();
            this.paymentTitle = new System.Windows.Forms.Label();
            this.payment_TablePannel = new System.Windows.Forms.TableLayoutPanel();
            this.installmentPayment_label = new System.Windows.Forms.Label();
            this.paymentMethod_CB = new System.Windows.Forms.ComboBox();
            this.finishBtn = new System.Windows.Forms.Button();
            this.goback = new System.Windows.Forms.Button();
            this.contractArea.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.vaccineArea.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.paymentArea.SuspendLayout();
            this.fullPayment_TB.SuspendLayout();
            this.installmentPayment_TB.SuspendLayout();
            this.payment_TablePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grandTitle
            // 
            this.grandTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grandTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grandTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grandTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grandTitle.Location = new System.Drawing.Point(0, 0);
            this.grandTitle.Name = "grandTitle";
            this.grandTitle.Size = new System.Drawing.Size(796, 46);
            this.grandTitle.TabIndex = 1;
            this.grandTitle.Text = "TITLE";
            this.grandTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contractArea
            // 
            this.contractArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractArea.BackColor = System.Drawing.Color.White;
            this.contractArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractArea.Controls.Add(this.billAreaTitle);
            this.contractArea.Controls.Add(this.tableLayoutPanel1);
            this.contractArea.ForeColor = System.Drawing.Color.Black;
            this.contractArea.Location = new System.Drawing.Point(94, 66);
            this.contractArea.Name = "contractArea";
            this.contractArea.Size = new System.Drawing.Size(606, 186);
            this.contractArea.TabIndex = 3;
            // 
            // billAreaTitle
            // 
            this.billAreaTitle.AutoSize = true;
            this.billAreaTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billAreaTitle.Location = new System.Drawing.Point(3, 0);
            this.billAreaTitle.Name = "billAreaTitle";
            this.billAreaTitle.Size = new System.Drawing.Size(225, 32);
            this.billAreaTitle.TabIndex = 1;
            this.billAreaTitle.Text = "Thông Tin Hoá Đơn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.Controls.Add(this.billCode_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.billCode_txt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientCode_txt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.registerCode_txt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientName_txt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.clientCode_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.registerCode_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientName_label, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // billCode_label
            // 
            this.billCode_label.AutoSize = true;
            this.billCode_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billCode_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billCode_label.Location = new System.Drawing.Point(3, 0);
            this.billCode_label.Name = "billCode_label";
            this.billCode_label.Size = new System.Drawing.Size(208, 28);
            this.billCode_label.TabIndex = 0;
            this.billCode_label.Text = "Mã Hoá Đơn";
            this.billCode_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // billCode_txt
            // 
            this.billCode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billCode_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billCode_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billCode_txt.Location = new System.Drawing.Point(3, 31);
            this.billCode_txt.Name = "billCode_txt";
            this.billCode_txt.Size = new System.Drawing.Size(208, 34);
            this.billCode_txt.TabIndex = 4;
            // 
            // clientCode_txt
            // 
            this.clientCode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientCode_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientCode_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientCode_txt.Location = new System.Drawing.Point(3, 101);
            this.clientCode_txt.Name = "clientCode_txt";
            this.clientCode_txt.Size = new System.Drawing.Size(208, 34);
            this.clientCode_txt.TabIndex = 6;
            // 
            // registerCode_txt
            // 
            this.registerCode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerCode_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerCode_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerCode_txt.Location = new System.Drawing.Point(286, 31);
            this.registerCode_txt.Name = "registerCode_txt";
            this.registerCode_txt.Size = new System.Drawing.Size(209, 34);
            this.registerCode_txt.TabIndex = 5;
            this.registerCode_txt.Leave += new System.EventHandler(this.registerCode_txt_Leave);
            // 
            // clientName_txt
            // 
            this.clientName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientName_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientName_txt.Location = new System.Drawing.Point(286, 101);
            this.clientName_txt.Name = "clientName_txt";
            this.clientName_txt.Size = new System.Drawing.Size(209, 34);
            this.clientName_txt.TabIndex = 7;
            // 
            // clientCode_label
            // 
            this.clientCode_label.AutoSize = true;
            this.clientCode_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientCode_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientCode_label.Location = new System.Drawing.Point(3, 70);
            this.clientCode_label.Name = "clientCode_label";
            this.clientCode_label.Size = new System.Drawing.Size(208, 28);
            this.clientCode_label.TabIndex = 8;
            this.clientCode_label.Text = "Mã Khách Hàng";
            this.clientCode_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // registerCode_label
            // 
            this.registerCode_label.AutoSize = true;
            this.registerCode_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerCode_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerCode_label.Location = new System.Drawing.Point(286, 0);
            this.registerCode_label.Name = "registerCode_label";
            this.registerCode_label.Size = new System.Drawing.Size(209, 28);
            this.registerCode_label.TabIndex = 9;
            this.registerCode_label.Text = "Mã Phiếu Đăng Ký";
            this.registerCode_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // clientName_label
            // 
            this.clientName_label.AutoSize = true;
            this.clientName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientName_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientName_label.Location = new System.Drawing.Point(286, 70);
            this.clientName_label.Name = "clientName_label";
            this.clientName_label.Size = new System.Drawing.Size(209, 28);
            this.clientName_label.TabIndex = 10;
            this.clientName_label.Text = "Họ Tên Khách Hàng";
            this.clientName_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // vaccineArea
            // 
            this.vaccineArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vaccineArea.BackColor = System.Drawing.Color.White;
            this.vaccineArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaccineArea.Controls.Add(this.vaccineAreaTitle);
            this.vaccineArea.Controls.Add(this.tableLayoutPanel6);
            this.vaccineArea.ForeColor = System.Drawing.Color.Black;
            this.vaccineArea.Location = new System.Drawing.Point(94, 262);
            this.vaccineArea.Name = "vaccineArea";
            this.vaccineArea.Size = new System.Drawing.Size(606, 186);
            this.vaccineArea.TabIndex = 5;
            // 
            // vaccineAreaTitle
            // 
            this.vaccineAreaTitle.AutoSize = true;
            this.vaccineAreaTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccineAreaTitle.Location = new System.Drawing.Point(3, 0);
            this.vaccineAreaTitle.Name = "vaccineAreaTitle";
            this.vaccineAreaTitle.Size = new System.Drawing.Size(210, 32);
            this.vaccineAreaTitle.TabIndex = 1;
            this.vaccineAreaTitle.Text = "Thông Tin Vaccine";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel6.Controls.Add(this.vaccinePackage_label, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.vaccinePackage_txt, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.injectDay_txt, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.vaccine_txt, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.injectDay_label, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.vaccine_label, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(52, 43);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(498, 140);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // vaccinePackage_label
            // 
            this.vaccinePackage_label.AutoSize = true;
            this.vaccinePackage_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaccinePackage_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccinePackage_label.Location = new System.Drawing.Point(3, 0);
            this.vaccinePackage_label.Name = "vaccinePackage_label";
            this.vaccinePackage_label.Size = new System.Drawing.Size(208, 28);
            this.vaccinePackage_label.TabIndex = 0;
            this.vaccinePackage_label.Text = "Gói Vaccine";
            this.vaccinePackage_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // vaccinePackage_txt
            // 
            this.vaccinePackage_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaccinePackage_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaccinePackage_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccinePackage_txt.Location = new System.Drawing.Point(3, 31);
            this.vaccinePackage_txt.Name = "vaccinePackage_txt";
            this.vaccinePackage_txt.Size = new System.Drawing.Size(208, 34);
            this.vaccinePackage_txt.TabIndex = 4;
            // 
            // injectDay_txt
            // 
            this.injectDay_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.injectDay_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.injectDay_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.injectDay_txt.Location = new System.Drawing.Point(3, 101);
            this.injectDay_txt.Name = "injectDay_txt";
            this.injectDay_txt.Size = new System.Drawing.Size(208, 34);
            this.injectDay_txt.TabIndex = 6;
            // 
            // vaccine_txt
            // 
            this.vaccine_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaccine_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaccine_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccine_txt.Location = new System.Drawing.Point(286, 31);
            this.vaccine_txt.Name = "vaccine_txt";
            this.vaccine_txt.Size = new System.Drawing.Size(209, 34);
            this.vaccine_txt.TabIndex = 5;
            // 
            // injectDay_label
            // 
            this.injectDay_label.AutoSize = true;
            this.injectDay_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.injectDay_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.injectDay_label.Location = new System.Drawing.Point(3, 70);
            this.injectDay_label.Name = "injectDay_label";
            this.injectDay_label.Size = new System.Drawing.Size(208, 28);
            this.injectDay_label.TabIndex = 8;
            this.injectDay_label.Text = "Ngày Tiêm";
            this.injectDay_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // vaccine_label
            // 
            this.vaccine_label.AutoSize = true;
            this.vaccine_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaccine_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccine_label.Location = new System.Drawing.Point(286, 0);
            this.vaccine_label.Name = "vaccine_label";
            this.vaccine_label.Size = new System.Drawing.Size(209, 28);
            this.vaccine_label.TabIndex = 9;
            this.vaccine_label.Text = "Loại Vaccine";
            this.vaccine_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // installmentPayment_CB
            // 
            this.installmentPayment_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installmentPayment_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.installmentPayment_CB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installmentPayment_CB.ForeColor = System.Drawing.Color.Black;
            this.installmentPayment_CB.FormattingEnabled = true;
            this.installmentPayment_CB.Items.AddRange(new object[] {
            "Thanh toán một lần",
            "Trả góp theo đợt"});
            this.installmentPayment_CB.Location = new System.Drawing.Point(286, 31);
            this.installmentPayment_CB.Name = "installmentPayment_CB";
            this.installmentPayment_CB.Size = new System.Drawing.Size(209, 36);
            this.installmentPayment_CB.TabIndex = 7;
            this.installmentPayment_CB.SelectedIndexChanged += new System.EventHandler(this.paymentInstallment_CB_SelectedIndexChanged);
            // 
            // paymentMethod_label
            // 
            this.paymentMethod_label.AutoSize = true;
            this.paymentMethod_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentMethod_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentMethod_label.Location = new System.Drawing.Point(3, 0);
            this.paymentMethod_label.Name = "paymentMethod_label";
            this.paymentMethod_label.Size = new System.Drawing.Size(208, 28);
            this.paymentMethod_label.TabIndex = 9;
            this.paymentMethod_label.Text = "Phương thức thanh toán";
            this.paymentMethod_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentArea
            // 
            this.paymentArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentArea.BackColor = System.Drawing.Color.White;
            this.paymentArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentArea.Controls.Add(this.paymentStatus);
            this.paymentArea.Controls.Add(this.fullPayment_TB);
            this.paymentArea.Controls.Add(this.installmentPayment_TB);
            this.paymentArea.Controls.Add(this.paymentTitle);
            this.paymentArea.Controls.Add(this.payment_TablePannel);
            this.paymentArea.ForeColor = System.Drawing.Color.Black;
            this.paymentArea.Location = new System.Drawing.Point(94, 459);
            this.paymentArea.Name = "paymentArea";
            this.paymentArea.Size = new System.Drawing.Size(606, 506);
            this.paymentArea.TabIndex = 6;
            // 
            // paymentStatus
            // 
            this.paymentStatus.AutoSize = true;
            this.paymentStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentStatus.Location = new System.Drawing.Point(419, -1);
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.Size = new System.Drawing.Size(180, 32);
            this.paymentStatus.TabIndex = 14;
            this.paymentStatus.Text = "Đang tiến hành";
            // 
            // fullPayment_TB
            // 
            this.fullPayment_TB.ColumnCount = 3;
            this.fullPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.fullPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.fullPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.fullPayment_TB.Controls.Add(this.totalPayment_txt, 0, 1);
            this.fullPayment_TB.Controls.Add(this.paymentDay_label, 2, 0);
            this.fullPayment_TB.Controls.Add(this.totalPayment_label, 0, 0);
            this.fullPayment_TB.Controls.Add(this.paymentDay_txt, 2, 1);
            this.fullPayment_TB.Location = new System.Drawing.Point(55, 116);
            this.fullPayment_TB.Name = "fullPayment_TB";
            this.fullPayment_TB.RowCount = 2;
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fullPayment_TB.Size = new System.Drawing.Size(498, 70);
            this.fullPayment_TB.TabIndex = 11;
            // 
            // totalPayment_txt
            // 
            this.totalPayment_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPayment_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPayment_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPayment_txt.Location = new System.Drawing.Point(3, 31);
            this.totalPayment_txt.Name = "totalPayment_txt";
            this.totalPayment_txt.Size = new System.Drawing.Size(208, 34);
            this.totalPayment_txt.TabIndex = 10;
            // 
            // paymentDay_label
            // 
            this.paymentDay_label.AutoSize = true;
            this.paymentDay_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay_label.Location = new System.Drawing.Point(286, 0);
            this.paymentDay_label.Name = "paymentDay_label";
            this.paymentDay_label.Size = new System.Drawing.Size(209, 28);
            this.paymentDay_label.TabIndex = 11;
            this.paymentDay_label.Text = "Ngày thanh toán";
            this.paymentDay_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalPayment_label
            // 
            this.totalPayment_label.AutoSize = true;
            this.totalPayment_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPayment_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPayment_label.Location = new System.Drawing.Point(3, 0);
            this.totalPayment_label.Name = "totalPayment_label";
            this.totalPayment_label.Size = new System.Drawing.Size(208, 28);
            this.totalPayment_label.TabIndex = 12;
            this.totalPayment_label.Text = "Tổng tiền";
            this.totalPayment_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentDay_txt
            // 
            this.paymentDay_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDay_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay_txt.Location = new System.Drawing.Point(286, 31);
            this.paymentDay_txt.Name = "paymentDay_txt";
            this.paymentDay_txt.Size = new System.Drawing.Size(209, 34);
            this.paymentDay_txt.TabIndex = 13;
            // 
            // installmentPayment_TB
            // 
            this.installmentPayment_TB.ColumnCount = 3;
            this.installmentPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.installmentPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.installmentPayment_TB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.installmentPayment_TB.Controls.Add(this.paymentAmount2_txt, 0, 5);
            this.installmentPayment_TB.Controls.Add(this.paymentAmount2_label, 0, 4);
            this.installmentPayment_TB.Controls.Add(this.paymentAmount1_label, 0, 2);
            this.installmentPayment_TB.Controls.Add(this.paymentAmount1_txt, 0, 3);
            this.installmentPayment_TB.Controls.Add(this.paymentDay1_label, 2, 2);
            this.installmentPayment_TB.Controls.Add(this.paymentDay2_label, 2, 4);
            this.installmentPayment_TB.Controls.Add(this.paymentDay2_txt, 2, 5);
            this.installmentPayment_TB.Controls.Add(this.paymentAmount3_label, 0, 6);
            this.installmentPayment_TB.Controls.Add(this.paymentDay3_label, 2, 6);
            this.installmentPayment_TB.Controls.Add(this.paymentDay1_txt, 2, 3);
            this.installmentPayment_TB.Controls.Add(this.paymentAmount3_txt, 0, 7);
            this.installmentPayment_TB.Controls.Add(this.paymentDay3_txt, 2, 7);
            this.installmentPayment_TB.Controls.Add(this.totalPayment2_label, 0, 0);
            this.installmentPayment_TB.Controls.Add(this.paymentProgress_label, 2, 0);
            this.installmentPayment_TB.Controls.Add(this.totalPayment2_txt, 0, 1);
            this.installmentPayment_TB.Controls.Add(this.paymentProgress_txt, 2, 1);
            this.installmentPayment_TB.Location = new System.Drawing.Point(83, 192);
            this.installmentPayment_TB.Name = "installmentPayment_TB";
            this.installmentPayment_TB.RowCount = 8;
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.installmentPayment_TB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.installmentPayment_TB.Size = new System.Drawing.Size(498, 280);
            this.installmentPayment_TB.TabIndex = 13;
            // 
            // paymentAmount2_txt
            // 
            this.paymentAmount2_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentAmount2_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount2_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount2_txt.Location = new System.Drawing.Point(3, 171);
            this.paymentAmount2_txt.Name = "paymentAmount2_txt";
            this.paymentAmount2_txt.Size = new System.Drawing.Size(208, 34);
            this.paymentAmount2_txt.TabIndex = 6;
            // 
            // paymentAmount2_label
            // 
            this.paymentAmount2_label.AutoSize = true;
            this.paymentAmount2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount2_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount2_label.Location = new System.Drawing.Point(3, 140);
            this.paymentAmount2_label.Name = "paymentAmount2_label";
            this.paymentAmount2_label.Size = new System.Drawing.Size(208, 28);
            this.paymentAmount2_label.TabIndex = 8;
            this.paymentAmount2_label.Text = "Thanh toán lần 2";
            this.paymentAmount2_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentAmount1_label
            // 
            this.paymentAmount1_label.AutoSize = true;
            this.paymentAmount1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount1_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount1_label.Location = new System.Drawing.Point(3, 70);
            this.paymentAmount1_label.Name = "paymentAmount1_label";
            this.paymentAmount1_label.Size = new System.Drawing.Size(208, 28);
            this.paymentAmount1_label.TabIndex = 9;
            this.paymentAmount1_label.Text = "Thanh toán lần 1";
            this.paymentAmount1_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentAmount1_txt
            // 
            this.paymentAmount1_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentAmount1_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount1_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount1_txt.Location = new System.Drawing.Point(3, 101);
            this.paymentAmount1_txt.Name = "paymentAmount1_txt";
            this.paymentAmount1_txt.Size = new System.Drawing.Size(208, 34);
            this.paymentAmount1_txt.TabIndex = 10;
            // 
            // paymentDay1_label
            // 
            this.paymentDay1_label.AutoSize = true;
            this.paymentDay1_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay1_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay1_label.Location = new System.Drawing.Point(286, 70);
            this.paymentDay1_label.Name = "paymentDay1_label";
            this.paymentDay1_label.Size = new System.Drawing.Size(209, 28);
            this.paymentDay1_label.TabIndex = 9;
            this.paymentDay1_label.Text = "Ngày thanh toán lần 1";
            this.paymentDay1_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentDay2_label
            // 
            this.paymentDay2_label.AutoSize = true;
            this.paymentDay2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay2_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay2_label.Location = new System.Drawing.Point(286, 140);
            this.paymentDay2_label.Name = "paymentDay2_label";
            this.paymentDay2_label.Size = new System.Drawing.Size(209, 28);
            this.paymentDay2_label.TabIndex = 11;
            this.paymentDay2_label.Text = "Ngày thanh toán lần 2";
            this.paymentDay2_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentDay2_txt
            // 
            this.paymentDay2_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDay2_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay2_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay2_txt.Location = new System.Drawing.Point(286, 171);
            this.paymentDay2_txt.Name = "paymentDay2_txt";
            this.paymentDay2_txt.Size = new System.Drawing.Size(209, 34);
            this.paymentDay2_txt.TabIndex = 12;
            // 
            // paymentAmount3_label
            // 
            this.paymentAmount3_label.AutoSize = true;
            this.paymentAmount3_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount3_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount3_label.Location = new System.Drawing.Point(3, 210);
            this.paymentAmount3_label.Name = "paymentAmount3_label";
            this.paymentAmount3_label.Size = new System.Drawing.Size(208, 28);
            this.paymentAmount3_label.TabIndex = 13;
            this.paymentAmount3_label.Text = "Thanh toán lần 3";
            this.paymentAmount3_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentDay3_label
            // 
            this.paymentDay3_label.AutoSize = true;
            this.paymentDay3_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay3_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay3_label.Location = new System.Drawing.Point(286, 210);
            this.paymentDay3_label.Name = "paymentDay3_label";
            this.paymentDay3_label.Size = new System.Drawing.Size(209, 28);
            this.paymentDay3_label.TabIndex = 14;
            this.paymentDay3_label.Text = "Ngày thanh toán lần 3";
            this.paymentDay3_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentDay1_txt
            // 
            this.paymentDay1_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDay1_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay1_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay1_txt.Location = new System.Drawing.Point(286, 101);
            this.paymentDay1_txt.Name = "paymentDay1_txt";
            this.paymentDay1_txt.Size = new System.Drawing.Size(209, 34);
            this.paymentDay1_txt.TabIndex = 15;
            // 
            // paymentAmount3_txt
            // 
            this.paymentAmount3_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentAmount3_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentAmount3_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentAmount3_txt.Location = new System.Drawing.Point(3, 241);
            this.paymentAmount3_txt.Name = "paymentAmount3_txt";
            this.paymentAmount3_txt.Size = new System.Drawing.Size(208, 34);
            this.paymentAmount3_txt.TabIndex = 16;
            // 
            // paymentDay3_txt
            // 
            this.paymentDay3_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDay3_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDay3_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentDay3_txt.Location = new System.Drawing.Point(286, 241);
            this.paymentDay3_txt.Name = "paymentDay3_txt";
            this.paymentDay3_txt.Size = new System.Drawing.Size(209, 34);
            this.paymentDay3_txt.TabIndex = 17;
            // 
            // totalPayment2_label
            // 
            this.totalPayment2_label.AutoSize = true;
            this.totalPayment2_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPayment2_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPayment2_label.Location = new System.Drawing.Point(3, 0);
            this.totalPayment2_label.Name = "totalPayment2_label";
            this.totalPayment2_label.Size = new System.Drawing.Size(208, 28);
            this.totalPayment2_label.TabIndex = 18;
            this.totalPayment2_label.Text = "Tổng tiền";
            this.totalPayment2_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentProgress_label
            // 
            this.paymentProgress_label.AutoSize = true;
            this.paymentProgress_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentProgress_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentProgress_label.Location = new System.Drawing.Point(286, 0);
            this.paymentProgress_label.Name = "paymentProgress_label";
            this.paymentProgress_label.Size = new System.Drawing.Size(209, 28);
            this.paymentProgress_label.TabIndex = 19;
            this.paymentProgress_label.Text = "Đang thanh toán lần";
            this.paymentProgress_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalPayment2_txt
            // 
            this.totalPayment2_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPayment2_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPayment2_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPayment2_txt.Location = new System.Drawing.Point(3, 31);
            this.totalPayment2_txt.Name = "totalPayment2_txt";
            this.totalPayment2_txt.Size = new System.Drawing.Size(208, 34);
            this.totalPayment2_txt.TabIndex = 20;
            // 
            // paymentProgress_txt
            // 
            this.paymentProgress_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentProgress_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentProgress_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentProgress_txt.Location = new System.Drawing.Point(286, 31);
            this.paymentProgress_txt.Name = "paymentProgress_txt";
            this.paymentProgress_txt.ReadOnly = true;
            this.paymentProgress_txt.Size = new System.Drawing.Size(209, 34);
            this.paymentProgress_txt.TabIndex = 21;
            // 
            // paymentTitle
            // 
            this.paymentTitle.AutoSize = true;
            this.paymentTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentTitle.Location = new System.Drawing.Point(3, 0);
            this.paymentTitle.Name = "paymentTitle";
            this.paymentTitle.Size = new System.Drawing.Size(139, 32);
            this.paymentTitle.TabIndex = 1;
            this.paymentTitle.Text = "Thanh Toán";
            // 
            // payment_TablePannel
            // 
            this.payment_TablePannel.ColumnCount = 3;
            this.payment_TablePannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.payment_TablePannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.payment_TablePannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.payment_TablePannel.Controls.Add(this.installmentPayment_CB, 2, 1);
            this.payment_TablePannel.Controls.Add(this.paymentMethod_label, 0, 0);
            this.payment_TablePannel.Controls.Add(this.installmentPayment_label, 2, 0);
            this.payment_TablePannel.Controls.Add(this.paymentMethod_CB, 0, 1);
            this.payment_TablePannel.Location = new System.Drawing.Point(57, 40);
            this.payment_TablePannel.Name = "payment_TablePannel";
            this.payment_TablePannel.RowCount = 2;
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payment_TablePannel.Size = new System.Drawing.Size(498, 70);
            this.payment_TablePannel.TabIndex = 0;
            // 
            // installmentPayment_label
            // 
            this.installmentPayment_label.AutoSize = true;
            this.installmentPayment_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installmentPayment_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installmentPayment_label.Location = new System.Drawing.Point(286, 0);
            this.installmentPayment_label.Name = "installmentPayment_label";
            this.installmentPayment_label.Size = new System.Drawing.Size(209, 28);
            this.installmentPayment_label.TabIndex = 9;
            this.installmentPayment_label.Text = "Trả góp";
            this.installmentPayment_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paymentMethod_CB
            // 
            this.paymentMethod_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentMethod_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_CB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentMethod_CB.FormattingEnabled = true;
            this.paymentMethod_CB.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ tín dụng"});
            this.paymentMethod_CB.Location = new System.Drawing.Point(3, 31);
            this.paymentMethod_CB.Name = "paymentMethod_CB";
            this.paymentMethod_CB.Size = new System.Drawing.Size(208, 36);
            this.paymentMethod_CB.TabIndex = 10;
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.Color.Aqua;
            this.finishBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.finishBtn.FlatAppearance.BorderSize = 2;
            this.finishBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.finishBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.finishBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finishBtn.ForeColor = System.Drawing.Color.Red;
            this.finishBtn.Location = new System.Drawing.Point(266, 971);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(249, 53);
            this.finishBtn.TabIndex = 7;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // goback
            // 
            this.goback.AllowDrop = true;
            this.goback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goback.FlatAppearance.BorderSize = 2;
            this.goback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.goback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goback.Image = ((System.Drawing.Image)(resources.GetObject("goback.Image")));
            this.goback.Location = new System.Drawing.Point(691, 972);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(93, 52);
            this.goback.TabIndex = 8;
            this.goback.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // MHCTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 1031);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.paymentArea);
            this.Controls.Add(this.vaccineArea);
            this.Controls.Add(this.contractArea);
            this.Controls.Add(this.grandTitle);
            this.Name = "MHCTHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHCTHoaDon";
            this.Load += new System.EventHandler(this.MHCTHoaDon_Load);
            this.contractArea.ResumeLayout(false);
            this.contractArea.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.vaccineArea.ResumeLayout(false);
            this.vaccineArea.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.paymentArea.ResumeLayout(false);
            this.paymentArea.PerformLayout();
            this.fullPayment_TB.ResumeLayout(false);
            this.fullPayment_TB.PerformLayout();
            this.installmentPayment_TB.ResumeLayout(false);
            this.installmentPayment_TB.PerformLayout();
            this.payment_TablePannel.ResumeLayout(false);
            this.payment_TablePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label grandTitle;
        private Panel contractArea;
        private TableLayoutPanel tableLayoutPanel1;
        private Label billAreaTitle;
        private Label billCode_label;
        private TextBox billCode_txt;
        private TextBox registerCode_txt;
        private TextBox clientCode_txt;
        private TextBox clientName_txt;
        private Label clientCode_label;
        private Label registerCode_label;
        private Label clientName_label;
        private Panel vaccineArea;
        private Label vaccineAreaTitle;
        private TableLayoutPanel tableLayoutPanel6;
        private Label vaccinePackage_label;
        private TextBox vaccinePackage_txt;
        private TextBox injectDay_txt;
        private TextBox vaccine_txt;
        private Label injectDay_label;
        private Label vaccine_label;
        private ComboBox installmentPayment_CB;
        private Label paymentMethod_label;
        private Panel paymentArea;
        private Label paymentTitle;
        private TableLayoutPanel payment_TablePannel;
        private Label installmentPayment_label;
        private TextBox paymentAmount2_txt;
        private Label paymentAmount2_label;
        private Label paymentAmount1_label;
        private TextBox paymentAmount1_txt;
        private Label paymentDay1_label;
        private Label paymentDay2_label;
        private TextBox paymentDay2_txt;
        private Label paymentAmount3_label;
        private Label paymentDay3_label;
        private TextBox paymentDay1_txt;
        private TextBox paymentAmount3_txt;
        private TextBox paymentDay3_txt;
        private TableLayoutPanel fullPayment_TB;
        private TextBox totalPayment_txt;
        internal TableLayoutPanel installmentPayment_TB;
        private Label paymentStatus;
        private Label paymentDay_label;
        private Label totalPayment_label;
        private TextBox paymentDay_txt;
        private Button finishBtn;
        private Button goback;
        internal ComboBox paymentMethod_CB;
        private Label totalPayment2_label;
        private Label paymentProgress_label;
        private TextBox totalPayment2_txt;
        private TextBox paymentProgress_txt;
    }
}