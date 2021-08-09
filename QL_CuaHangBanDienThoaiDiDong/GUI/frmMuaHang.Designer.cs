namespace GUI
{
    partial class frmMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuaHang));
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnXoaDH = new System.Windows.Forms.Button();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemDH = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaoHoaDonMoi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cl_HD_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_TenHangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_Ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_BoNhoTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HD_XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_TenHangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_Ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_BoNhoTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SP_XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(720, 455);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(185, 19);
            this.lbMaNV.TabIndex = 74;
            this.lbMaNV.Text = "Mã nhân viên lập hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(605, 456);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 73;
            this.label10.Text = "Mã Nhân Viên:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(1031, 478);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(83, 19);
            this.lbMaHD.TabIndex = 72;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(721, 496);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(190, 19);
            this.lbTenNV.TabIndex = 71;
            this.lbTenNV.Text = "Tên nhân viên lập hóa đơn";
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDH.Image")));
            this.btnXoaDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDH.Location = new System.Drawing.Point(367, 468);
            this.btnXoaDH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(114, 41);
            this.btnXoaDH.TabIndex = 69;
            this.btnXoaDH.Text = "Xóa Đơn Hàng";
            this.btnXoaDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDH.UseVisualStyleBackColor = true;
            this.btnXoaDH.Visible = false;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToAddRows = false;
            this.dtgvSanPham.AllowUserToOrderColumns = true;
            this.dtgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_SP_MaSP,
            this.cl_SP_TenSP,
            this.cl_SP_TenHangSX,
            this.cl_SP_Ram,
            this.cl_SP_BoNhoTrong,
            this.cl_SP_Gia,
            this.cl_SP_SoLuong,
            this.cl_SP_XuatXu});
            this.dtgvSanPham.Location = new System.Drawing.Point(4, 38);
            this.dtgvSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvSanPham.MultiSelect = false;
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.ReadOnly = true;
            this.dtgvSanPham.RowHeadersVisible = false;
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSanPham.Size = new System.Drawing.Size(551, 320);
            this.dtgvSanPham.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(11, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(559, 363);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(935, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Số Hóa Đơn:";
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_HD_MaSP,
            this.cl_HD_TenSP,
            this.cl_HD_TenHangSX,
            this.cl_HD_Ram,
            this.cl_HD_BoNhoTrong,
            this.cl_HD_SoLuong,
            this.cl_HD_DonGia,
            this.cl_HD_ThanhTien,
            this.cl_HD_XuatXu});
            this.dtgvHoaDon.Location = new System.Drawing.Point(5, 23);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowHeadersVisible = false;
            this.dtgvHoaDon.RowTemplate.Height = 28;
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.Size = new System.Drawing.Size(706, 267);
            this.dtgvHoaDon.TabIndex = 60;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(1151, 385);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(114, 41);
            this.btnThanhToan.TabIndex = 59;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(908, 387);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 25);
            this.txtTongTien.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(822, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tổng tiền:";
            // 
            // btnThemDH
            // 
            this.btnThemDH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDH.Image")));
            this.btnThemDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDH.Location = new System.Drawing.Point(216, 468);
            this.btnThemDH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(114, 41);
            this.btnThemDH.TabIndex = 55;
            this.btnThemDH.Text = "Thêm Đơn Hàng";
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Visible = false;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsl.Location = new System.Drawing.Point(116, 474);
            this.txtsl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsl.Multiline = true;
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(86, 26);
            this.txtsl.TabIndex = 65;
            this.txtsl.Text = "0";
            this.txtsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1151, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 64;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(606, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tên Nhân Viên:";
            // 
            // btnTaoHoaDonMoi
            // 
            this.btnTaoHoaDonMoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoHoaDonMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHoaDonMoi.Image")));
            this.btnTaoHoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoaDonMoi.Location = new System.Drawing.Point(609, 385);
            this.btnTaoHoaDonMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTaoHoaDonMoi.Name = "btnTaoHoaDonMoi";
            this.btnTaoHoaDonMoi.Size = new System.Drawing.Size(114, 41);
            this.btnTaoHoaDonMoi.TabIndex = 61;
            this.btnTaoHoaDonMoi.Text = "Tạo Hóa Đơn Mới";
            this.btnTaoHoaDonMoi.UseVisualStyleBackColor = true;
            this.btnTaoHoaDonMoi.Click += new System.EventHandler(this.btnTaoHoaDonMoi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(29, 474);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1067, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Mua hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(582, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 294);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm khách hàng chọn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(934, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Ngày và giờ hiện tại:";
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGio.Location = new System.Drawing.Point(1066, 27);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(82, 19);
            this.lbNgayGio.TabIndex = 78;
            this.lbNgayGio.Text = "Ngày và giờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cl_HD_MaSP
            // 
            this.cl_HD_MaSP.DataPropertyName = "MaSP";
            this.cl_HD_MaSP.HeaderText = "Mã sản phẩm";
            this.cl_HD_MaSP.Name = "cl_HD_MaSP";
            this.cl_HD_MaSP.ReadOnly = true;
            // 
            // cl_HD_TenSP
            // 
            this.cl_HD_TenSP.DataPropertyName = "TenSP";
            this.cl_HD_TenSP.HeaderText = "Tên sản phẩm";
            this.cl_HD_TenSP.Name = "cl_HD_TenSP";
            this.cl_HD_TenSP.ReadOnly = true;
            // 
            // cl_HD_TenHangSX
            // 
            this.cl_HD_TenHangSX.DataPropertyName = "HangSX";
            this.cl_HD_TenHangSX.HeaderText = "Tên hãng SX";
            this.cl_HD_TenHangSX.Name = "cl_HD_TenHangSX";
            this.cl_HD_TenHangSX.ReadOnly = true;
            // 
            // cl_HD_Ram
            // 
            this.cl_HD_Ram.DataPropertyName = "Ram";
            this.cl_HD_Ram.HeaderText = "Ram";
            this.cl_HD_Ram.Name = "cl_HD_Ram";
            this.cl_HD_Ram.ReadOnly = true;
            // 
            // cl_HD_BoNhoTrong
            // 
            this.cl_HD_BoNhoTrong.DataPropertyName = "BoNhoTrong";
            this.cl_HD_BoNhoTrong.HeaderText = "Bộ nhớ trong";
            this.cl_HD_BoNhoTrong.Name = "cl_HD_BoNhoTrong";
            this.cl_HD_BoNhoTrong.ReadOnly = true;
            // 
            // cl_HD_SoLuong
            // 
            this.cl_HD_SoLuong.DataPropertyName = "SoLuong";
            this.cl_HD_SoLuong.HeaderText = "Số Lượng";
            this.cl_HD_SoLuong.Name = "cl_HD_SoLuong";
            this.cl_HD_SoLuong.ReadOnly = true;
            // 
            // cl_HD_DonGia
            // 
            this.cl_HD_DonGia.DataPropertyName = "DonGia";
            this.cl_HD_DonGia.HeaderText = "Đơn giá";
            this.cl_HD_DonGia.Name = "cl_HD_DonGia";
            this.cl_HD_DonGia.ReadOnly = true;
            // 
            // cl_HD_ThanhTien
            // 
            this.cl_HD_ThanhTien.DataPropertyName = "ThanhTien";
            this.cl_HD_ThanhTien.HeaderText = "Thành tiền";
            this.cl_HD_ThanhTien.Name = "cl_HD_ThanhTien";
            this.cl_HD_ThanhTien.ReadOnly = true;
            // 
            // cl_HD_XuatXu
            // 
            this.cl_HD_XuatXu.DataPropertyName = "XUATXU";
            this.cl_HD_XuatXu.HeaderText = "Xuất xứ";
            this.cl_HD_XuatXu.Name = "cl_HD_XuatXu";
            this.cl_HD_XuatXu.ReadOnly = true;
            // 
            // cl_SP_MaSP
            // 
            this.cl_SP_MaSP.DataPropertyName = "MASP";
            this.cl_SP_MaSP.FillWeight = 80F;
            this.cl_SP_MaSP.HeaderText = "Mã Sản Phẩm";
            this.cl_SP_MaSP.MinimumWidth = 6;
            this.cl_SP_MaSP.Name = "cl_SP_MaSP";
            this.cl_SP_MaSP.ReadOnly = true;
            // 
            // cl_SP_TenSP
            // 
            this.cl_SP_TenSP.DataPropertyName = "TenSP";
            this.cl_SP_TenSP.FillWeight = 170F;
            this.cl_SP_TenSP.HeaderText = "Tên sản phẩm";
            this.cl_SP_TenSP.Name = "cl_SP_TenSP";
            this.cl_SP_TenSP.ReadOnly = true;
            // 
            // cl_SP_TenHangSX
            // 
            this.cl_SP_TenHangSX.DataPropertyName = "TENHANGSX";
            this.cl_SP_TenHangSX.HeaderText = "Tên hãng SX";
            this.cl_SP_TenHangSX.Name = "cl_SP_TenHangSX";
            this.cl_SP_TenHangSX.ReadOnly = true;
            // 
            // cl_SP_Ram
            // 
            this.cl_SP_Ram.DataPropertyName = "RAM";
            this.cl_SP_Ram.FillWeight = 70.70061F;
            this.cl_SP_Ram.HeaderText = "Ram";
            this.cl_SP_Ram.Name = "cl_SP_Ram";
            this.cl_SP_Ram.ReadOnly = true;
            // 
            // cl_SP_BoNhoTrong
            // 
            this.cl_SP_BoNhoTrong.DataPropertyName = "BONHOTRONG";
            this.cl_SP_BoNhoTrong.FillWeight = 72.20485F;
            this.cl_SP_BoNhoTrong.HeaderText = "Bộ nhớ trong";
            this.cl_SP_BoNhoTrong.Name = "cl_SP_BoNhoTrong";
            this.cl_SP_BoNhoTrong.ReadOnly = true;
            // 
            // cl_SP_Gia
            // 
            this.cl_SP_Gia.DataPropertyName = "DONGIA";
            this.cl_SP_Gia.FillWeight = 68.72621F;
            this.cl_SP_Gia.HeaderText = "Giá";
            this.cl_SP_Gia.Name = "cl_SP_Gia";
            this.cl_SP_Gia.ReadOnly = true;
            // 
            // cl_SP_SoLuong
            // 
            this.cl_SP_SoLuong.DataPropertyName = "SOLUONG";
            this.cl_SP_SoLuong.FillWeight = 69.44162F;
            this.cl_SP_SoLuong.HeaderText = "Số lượng";
            this.cl_SP_SoLuong.Name = "cl_SP_SoLuong";
            this.cl_SP_SoLuong.ReadOnly = true;
            // 
            // cl_SP_XuatXu
            // 
            this.cl_SP_XuatXu.DataPropertyName = "XUATXU";
            this.cl_SP_XuatXu.HeaderText = "Xuất xứ";
            this.cl_SP_XuatXu.Name = "cl_SP_XuatXu";
            this.cl_SP_XuatXu.ReadOnly = true;
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 558);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.btnXoaDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemDH);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTaoHoaDonMoi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Name = "frmMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btnXoaDH;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTaoHoaDonMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNgayGio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_TenHangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_Ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_BoNhoTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SP_XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_TenHangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_Ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_BoNhoTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HD_XuatXu;
    }
}