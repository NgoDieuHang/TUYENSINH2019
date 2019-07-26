namespace TS_2018.View
{
    partial class ListOfSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfSV));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDaNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkGT7 = new System.Windows.Forms.CheckBox();
            this.checkGT4 = new System.Windows.Forms.CheckBox();
            this.checkGT9 = new System.Windows.Forms.CheckBox();
            this.checkGT10 = new System.Windows.Forms.CheckBox();
            this.checkGT3 = new System.Windows.Forms.CheckBox();
            this.checkGT6 = new System.Windows.Forms.CheckBox();
            this.checkGT8 = new System.Windows.Forms.CheckBox();
            this.checkGT2 = new System.Windows.Forms.CheckBox();
            this.checkGT11 = new System.Windows.Forms.CheckBox();
            this.checkGT5 = new System.Windows.Forms.CheckBox();
            this.checkGT1 = new System.Windows.Forms.CheckBox();
            this.gb_BL = new System.Windows.Forms.GroupBox();
            this.cbb_nganh = new System.Windows.Forms.ComboBox();
            this.cbb_CT = new System.Windows.Forms.ComboBox();
            this.checkDaNopHocPhi = new System.Windows.Forms.CheckBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.cbb_BHYT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_PNH = new System.Windows.Forms.GroupBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Print = new System.Windows.Forms.Button();
            this.but_Can = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_BL.SuspendLayout();
            this.gb_PNH.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SBD,
            this.HoTen,
            this.Lop,
            this.Tel,
            this.CMND,
            this.Address,
            this.TenNganh,
            this.TienDaNop});
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 686);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // SBD
            // 
            this.SBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SBD.DataPropertyName = "SBD";
            this.SBD.HeaderText = "SBD";
            this.SBD.Name = "SBD";
            this.SBD.ReadOnly = true;
            this.SBD.Width = 54;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTen.DataPropertyName = "Name";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 79;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Số điện thoại";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 95;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 80;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // TenNganh
            // 
            this.TenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Ngành trúng tuyển";
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            // 
            // TienDaNop
            // 
            this.TienDaNop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienDaNop.DataPropertyName = "TienDaNop";
            this.TienDaNop.HeaderText = "Tiền đã nộp";
            this.TienDaNop.Name = "TienDaNop";
            this.TienDaNop.ReadOnly = true;
            this.TienDaNop.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(551, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkGT7);
            this.groupBox1.Controls.Add(this.checkGT4);
            this.groupBox1.Controls.Add(this.checkGT9);
            this.groupBox1.Controls.Add(this.checkGT10);
            this.groupBox1.Controls.Add(this.checkGT3);
            this.groupBox1.Controls.Add(this.checkGT6);
            this.groupBox1.Controls.Add(this.checkGT8);
            this.groupBox1.Controls.Add(this.checkGT2);
            this.groupBox1.Controls.Add(this.checkGT11);
            this.groupBox1.Controls.Add(this.checkGT5);
            this.groupBox1.Controls.Add(this.checkGT1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÁC LOẠI GIẤY TỜ";
            // 
            // checkGT7
            // 
            this.checkGT7.AutoSize = true;
            this.checkGT7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT7.Location = new System.Drawing.Point(19, 183);
            this.checkGT7.Name = "checkGT7";
            this.checkGT7.Size = new System.Drawing.Size(260, 17);
            this.checkGT7.TabIndex = 0;
            this.checkGT7.Text = "Hồ sơ chuyển sinh hoạt Đoàn - đối với Đoàn viên";
            this.checkGT7.UseVisualStyleBackColor = true;
            // 
            // checkGT4
            // 
            this.checkGT4.AutoSize = true;
            this.checkGT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT4.Location = new System.Drawing.Point(19, 114);
            this.checkGT4.Name = "checkGT4";
            this.checkGT4.Size = new System.Drawing.Size(427, 17);
            this.checkGT4.TabIndex = 0;
            this.checkGT4.Text = "Giấy chứng nhận liên quan đến đối tượng ưu tiên tuyển sinh, nếu là đối tượng ưu t" +
    "iên";
            this.checkGT4.UseVisualStyleBackColor = true;
            // 
            // checkGT9
            // 
            this.checkGT9.AutoSize = true;
            this.checkGT9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT9.Location = new System.Drawing.Point(316, 72);
            this.checkGT9.Name = "checkGT9";
            this.checkGT9.Size = new System.Drawing.Size(190, 17);
            this.checkGT9.TabIndex = 0;
            this.checkGT9.Text = "03 bản photo CMND(công chứng).";
            this.checkGT9.UseVisualStyleBackColor = true;
            // 
            // checkGT10
            // 
            this.checkGT10.AutoSize = true;
            this.checkGT10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT10.Location = new System.Drawing.Point(19, 92);
            this.checkGT10.Name = "checkGT10";
            this.checkGT10.Size = new System.Drawing.Size(223, 17);
            this.checkGT10.TabIndex = 0;
            this.checkGT10.Text = "04 ảnh thẻ 3x4(chụp trong vòng 6 tháng).";
            this.checkGT10.UseVisualStyleBackColor = true;
            // 
            // checkGT3
            // 
            this.checkGT3.AutoSize = true;
            this.checkGT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT3.Location = new System.Drawing.Point(19, 72);
            this.checkGT3.Name = "checkGT3";
            this.checkGT3.Size = new System.Drawing.Size(183, 17);
            this.checkGT3.TabIndex = 0;
            this.checkGT3.Text = "01 bản sao hợp lệ Giấy khai sinh.";
            this.checkGT3.UseVisualStyleBackColor = true;
            // 
            // checkGT6
            // 
            this.checkGT6.AutoSize = true;
            this.checkGT6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT6.Location = new System.Drawing.Point(19, 160);
            this.checkGT6.Name = "checkGT6";
            this.checkGT6.Size = new System.Drawing.Size(341, 17);
            this.checkGT6.TabIndex = 0;
            this.checkGT6.Text = "Bản chính Quyết định cử đi học - đối với thí sinh là cán bộ, bộ đội";
            this.checkGT6.UseVisualStyleBackColor = true;
            // 
            // checkGT8
            // 
            this.checkGT8.AutoSize = true;
            this.checkGT8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT8.Location = new System.Drawing.Point(316, 49);
            this.checkGT8.Name = "checkGT8";
            this.checkGT8.Size = new System.Drawing.Size(272, 17);
            this.checkGT8.TabIndex = 0;
            this.checkGT8.Text = "Bản sao công chứng bằng TN THPT hay BTVHTH.";
            this.checkGT8.UseVisualStyleBackColor = true;
            // 
            // checkGT2
            // 
            this.checkGT2.AutoSize = true;
            this.checkGT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT2.Location = new System.Drawing.Point(19, 49);
            this.checkGT2.Name = "checkGT2";
            this.checkGT2.Size = new System.Drawing.Size(285, 17);
            this.checkGT2.TabIndex = 0;
            this.checkGT2.Text = "Bản chính Giấy chứng nhận tốt nghiệp THPT tạm thời.";
            this.checkGT2.UseVisualStyleBackColor = true;
            // 
            // checkGT11
            // 
            this.checkGT11.AutoSize = true;
            this.checkGT11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT11.Location = new System.Drawing.Point(316, 137);
            this.checkGT11.Name = "checkGT11";
            this.checkGT11.Size = new System.Drawing.Size(285, 17);
            this.checkGT11.TabIndex = 0;
            this.checkGT11.Text = "Giấy xác nhận đăng ký vắng mặt - đối với thí sinh nam";
            this.checkGT11.UseVisualStyleBackColor = true;
            // 
            // checkGT5
            // 
            this.checkGT5.AutoSize = true;
            this.checkGT5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT5.Location = new System.Drawing.Point(19, 137);
            this.checkGT5.Name = "checkGT5";
            this.checkGT5.Size = new System.Drawing.Size(240, 17);
            this.checkGT5.TabIndex = 0;
            this.checkGT5.Text = "Giấy chứng nhận đăng ký nghĩa vụ quân sự.";
            this.checkGT5.UseVisualStyleBackColor = true;
            // 
            // checkGT1
            // 
            this.checkGT1.AutoSize = true;
            this.checkGT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT1.Location = new System.Drawing.Point(19, 27);
            this.checkGT1.Name = "checkGT1";
            this.checkGT1.Size = new System.Drawing.Size(193, 17);
            this.checkGT1.TabIndex = 0;
            this.checkGT1.Text = "Bản sao công chứng học bạ THPT";
            this.checkGT1.UseVisualStyleBackColor = true;
            // 
            // gb_BL
            // 
            this.gb_BL.Controls.Add(this.cbb_nganh);
            this.gb_BL.Controls.Add(this.cbb_CT);
            this.gb_BL.Controls.Add(this.checkDaNopHocPhi);
            this.gb_BL.Controls.Add(this.txtTien);
            this.gb_BL.Controls.Add(this.cbb_BHYT);
            this.gb_BL.Controls.Add(this.label8);
            this.gb_BL.Controls.Add(this.label7);
            this.gb_BL.Controls.Add(this.label2);
            this.gb_BL.Controls.Add(this.label6);
            this.gb_BL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_BL.Location = new System.Drawing.Point(3, 414);
            this.gb_BL.Name = "gb_BL";
            this.gb_BL.Size = new System.Drawing.Size(607, 228);
            this.gb_BL.TabIndex = 4;
            this.gb_BL.TabStop = false;
            this.gb_BL.Text = "BIÊN LAI";
            // 
            // cbb_nganh
            // 
            this.cbb_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nganh.Enabled = false;
            this.cbb_nganh.FormattingEnabled = true;
            this.cbb_nganh.Location = new System.Drawing.Point(134, 24);
            this.cbb_nganh.Name = "cbb_nganh";
            this.cbb_nganh.Size = new System.Drawing.Size(282, 21);
            this.cbb_nganh.TabIndex = 2;
            // 
            // cbb_CT
            // 
            this.cbb_CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_CT.Enabled = false;
            this.cbb_CT.FormattingEnabled = true;
            this.cbb_CT.Location = new System.Drawing.Point(134, 60);
            this.cbb_CT.Name = "cbb_CT";
            this.cbb_CT.Size = new System.Drawing.Size(282, 21);
            this.cbb_CT.TabIndex = 2;
            this.cbb_CT.SelectedIndexChanged += new System.EventHandler(this.cbb_CT_SelectedIndexChanged);
            // 
            // checkDaNopHocPhi
            // 
            this.checkDaNopHocPhi.AutoSize = true;
            this.checkDaNopHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDaNopHocPhi.ForeColor = System.Drawing.Color.Red;
            this.checkDaNopHocPhi.Location = new System.Drawing.Point(19, 177);
            this.checkDaNopHocPhi.Name = "checkDaNopHocPhi";
            this.checkDaNopHocPhi.Size = new System.Drawing.Size(252, 24);
            this.checkDaNopHocPhi.TabIndex = 3;
            this.checkDaNopHocPhi.Text = "Đã nộp đầy đủ phí nhập học";
            this.checkDaNopHocPhi.UseVisualStyleBackColor = true;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(134, 136);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(282, 20);
            this.txtTien.TabIndex = 3;
            // 
            // cbb_BHYT
            // 
            this.cbb_BHYT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BHYT.FormattingEnabled = true;
            this.cbb_BHYT.Location = new System.Drawing.Point(134, 98);
            this.cbb_BHYT.Name = "cbb_BHYT";
            this.cbb_BHYT.Size = new System.Drawing.Size(282, 21);
            this.cbb_BHYT.TabIndex = 2;
            this.cbb_BHYT.SelectedIndexChanged += new System.EventHandler(this.cbb_BHYT_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số tiền tạm tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bảo hiểm y tế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngành trúng tuyển";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chương trình";
            // 
            // gb_PNH
            // 
            this.gb_PNH.Controls.Add(this.txtLop);
            this.gb_PNH.Controls.Add(this.label11);
            this.gb_PNH.Controls.Add(this.txtAddress);
            this.gb_PNH.Controls.Add(this.txtCMND);
            this.gb_PNH.Controls.Add(this.txtTel);
            this.gb_PNH.Controls.Add(this.txtSBD);
            this.gb_PNH.Controls.Add(this.txtName);
            this.gb_PNH.Controls.Add(this.label10);
            this.gb_PNH.Controls.Add(this.label5);
            this.gb_PNH.Controls.Add(this.label4);
            this.gb_PNH.Controls.Add(this.label3);
            this.gb_PNH.Controls.Add(this.label9);
            this.gb_PNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PNH.Location = new System.Drawing.Point(3, 16);
            this.gb_PNH.Name = "gb_PNH";
            this.gb_PNH.Size = new System.Drawing.Size(607, 168);
            this.gb_PNH.TabIndex = 5;
            this.gb_PNH.TabStop = false;
            this.gb_PNH.Text = "PHIẾU NHẬP HỌC";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(72, 102);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(181, 20);
            this.txtLop.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lớp";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(516, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(407, 31);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(181, 20);
            this.txtCMND.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(407, 70);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 20);
            this.txtTel.TabIndex = 1;
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(72, 31);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.ReadOnly = true;
            this.txtSBD.Size = new System.Drawing.Size(181, 20);
            this.txtSBD.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SBD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên";
            // 
            // but_OK
            // 
            this.but_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_OK.Location = new System.Drawing.Point(162, 669);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(145, 36);
            this.but_OK.TabIndex = 7;
            this.but_OK.Text = "LƯU VÀ IN";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Print
            // 
            this.but_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Print.Location = new System.Drawing.Point(469, 694);
            this.but_Print.Name = "but_Print";
            this.but_Print.Size = new System.Drawing.Size(135, 23);
            this.but_Print.TabIndex = 7;
            this.but_Print.Text = "NỢ HỌC PHÍ VÀ IN";
            this.but_Print.UseVisualStyleBackColor = true;
            this.but_Print.Visible = false;
            this.but_Print.Click += new System.EventHandler(this.but_Print_Click);
            // 
            // but_Can
            // 
            this.but_Can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Can.BackColor = System.Drawing.Color.Red;
            this.but_Can.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Can.ForeColor = System.Drawing.Color.Yellow;
            this.but_Can.Location = new System.Drawing.Point(364, 669);
            this.but_Can.Name = "but_Can";
            this.but_Can.Size = new System.Drawing.Size(99, 36);
            this.but_Can.TabIndex = 7;
            this.but_Can.Text = "HỦY HỒ SƠ";
            this.but_Can.UseVisualStyleBackColor = false;
            this.but_Can.Click += new System.EventHandler(this.but_Can_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 729);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.lblCount);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.cbbFilter);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.gb_PNH);
            this.splitContainer1.Panel2.Controls.Add(this.but_Can);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.but_Print);
            this.splitContainer1.Panel2.Controls.Add(this.gb_BL);
            this.splitContainer1.Panel2.Controls.Add(this.but_OK);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 729);
            this.splitContainer1.SplitterDistance = 733;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(416, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(76, 24);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(242, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(53, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "lblCount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Filter";
            // 
            // cbbFilter
            // 
            this.cbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Đã hoàn thành thủ tục",
            "Chưa hoàn thành thủ tục"});
            this.cbbFilter.Location = new System.Drawing.Point(53, 12);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(173, 21);
            this.cbbFilter.TabIndex = 4;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(3, 703);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // ListOfSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "ListOfSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUYỂN SINH 2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListOfSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_BL.ResumeLayout(false);
            this.gb_BL.PerformLayout();
            this.gb_PNH.ResumeLayout(false);
            this.gb_PNH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_BL;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox cbb_BHYT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_PNH;
        private System.Windows.Forms.ComboBox cbb_CT;
        private System.Windows.Forms.ComboBox cbb_nganh;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Print;
        private System.Windows.Forms.Button but_Can;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkDaNopHocPhi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkGT7;
        private System.Windows.Forms.CheckBox checkGT4;
        private System.Windows.Forms.CheckBox checkGT3;
        private System.Windows.Forms.CheckBox checkGT6;
        private System.Windows.Forms.CheckBox checkGT2;
        private System.Windows.Forms.CheckBox checkGT5;
        private System.Windows.Forms.CheckBox checkGT1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkGT8;
        private System.Windows.Forms.CheckBox checkGT9;
        private System.Windows.Forms.CheckBox checkGT10;
        private System.Windows.Forms.CheckBox checkGT11;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDaNop;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExport;
    }
}