namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripDropDownButton();
            this.DangNhapTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DoiMatKhauTool = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLy = new System.Windows.Forms.ToolStripDropDownButton();
            this.SanPhamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.HangSXTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.KhachHangTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.HoaDonBanTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ThemHoaDonBanTool = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripDropDownButton();
            this.DoanhThuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachKhacHangTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachNhanVienTool = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMaNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTenNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 462);
            this.panel1.TabIndex = 0;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lbMaNV.ForeColor = System.Drawing.Color.Crimson;
            this.lbMaNV.Location = new System.Drawing.Point(590, 433);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(84, 21);
            this.lbMaNV.TabIndex = 11;
            this.lbMaNV.Text = "Không có";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lbTenNV.ForeColor = System.Drawing.Color.Crimson;
            this.lbTenNV.Location = new System.Drawing.Point(283, 432);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(84, 21);
            this.lbTenNV.TabIndex = 9;
            this.lbTenNV.Text = "Không có";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Người dùng đang đăng nhập là:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 385);
            this.panel2.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHeThong,
            this.btnQuanLy,
            this.btnThongKe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhapTool,
            this.DangXuatTool,
            this.toolStripSeparator1,
            this.DoiMatKhauTool,
            this.thoátToolStripMenuItem});
            this.btnHeThong.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(114, 25);
            this.btnHeThong.Text = "Hệ Thống";
            // 
            // DangNhapTool
            // 
            this.DangNhapTool.Name = "DangNhapTool";
            this.DangNhapTool.Size = new System.Drawing.Size(180, 26);
            this.DangNhapTool.Text = "Đăng Nhập";
            this.DangNhapTool.Click += new System.EventHandler(this.DangNhapTool_Click);
            // 
            // DangXuatTool
            // 
            this.DangXuatTool.Name = "DangXuatTool";
            this.DangXuatTool.Size = new System.Drawing.Size(180, 26);
            this.DangXuatTool.Text = "Đăng Xuất";
            this.DangXuatTool.Visible = false;
            this.DangXuatTool.Click += new System.EventHandler(this.DangXuatTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // DoiMatKhauTool
            // 
            this.DoiMatKhauTool.Name = "DoiMatKhauTool";
            this.DoiMatKhauTool.Size = new System.Drawing.Size(180, 26);
            this.DoiMatKhauTool.Text = "Đổi mật khẩu";
            this.DoiMatKhauTool.Click += new System.EventHandler(this.DoiMatKhauTool_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPhamTool,
            this.HangSXTool,
            this.toolStripSeparator2,
            this.KhachHangTool,
            this.NhanVienTool,
            this.toolStripSeparator3,
            this.HoaDonBanTool,
            this.toolStripSeparator4,
            this.ThemHoaDonBanTool});
            this.btnQuanLy.Enabled = false;
            this.btnQuanLy.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(104, 25);
            this.btnQuanLy.Text = "Quản Lý";
            // 
            // SanPhamTool
            // 
            this.SanPhamTool.Name = "SanPhamTool";
            this.SanPhamTool.Size = new System.Drawing.Size(221, 26);
            this.SanPhamTool.Text = "Sản Phẩm";
            this.SanPhamTool.Click += new System.EventHandler(this.SanPhamTool_Click);
            // 
            // HangSXTool
            // 
            this.HangSXTool.Name = "HangSXTool";
            this.HangSXTool.Size = new System.Drawing.Size(221, 26);
            this.HangSXTool.Text = "Hãng sản xuất";
            this.HangSXTool.Click += new System.EventHandler(this.HangSXTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // KhachHangTool
            // 
            this.KhachHangTool.Name = "KhachHangTool";
            this.KhachHangTool.Size = new System.Drawing.Size(221, 26);
            this.KhachHangTool.Text = "Khách Hàng";
            this.KhachHangTool.Click += new System.EventHandler(this.KhachHangTool_Click);
            // 
            // NhanVienTool
            // 
            this.NhanVienTool.Name = "NhanVienTool";
            this.NhanVienTool.Size = new System.Drawing.Size(221, 26);
            this.NhanVienTool.Text = "Nhân Viên";
            this.NhanVienTool.Click += new System.EventHandler(this.NhanVienTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // HoaDonBanTool
            // 
            this.HoaDonBanTool.Name = "HoaDonBanTool";
            this.HoaDonBanTool.Size = new System.Drawing.Size(221, 26);
            this.HoaDonBanTool.Text = "Hóa đơn bán";
            this.HoaDonBanTool.Click += new System.EventHandler(this.HoaDonBanTool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // ThemHoaDonBanTool
            // 
            this.ThemHoaDonBanTool.Name = "ThemHoaDonBanTool";
            this.ThemHoaDonBanTool.Size = new System.Drawing.Size(221, 26);
            this.ThemHoaDonBanTool.Text = "Thêm hóa đơn bán";
            this.ThemHoaDonBanTool.Click += new System.EventHandler(this.ThemHoaDonBanTool_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoanhThuTool,
            this.DanhSachKhacHangTool,
            this.DanhSachNhanVienTool});
            this.btnThongKe.Enabled = false;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(114, 25);
            this.btnThongKe.Text = "Thống Kê";
            // 
            // DoanhThuTool
            // 
            this.DoanhThuTool.Name = "DoanhThuTool";
            this.DoanhThuTool.Size = new System.Drawing.Size(258, 26);
            this.DoanhThuTool.Text = "Doanh Thu";
            this.DoanhThuTool.Click += new System.EventHandler(this.DoanhThuTool_Click);
            // 
            // DanhSachKhacHangTool
            // 
            this.DanhSachKhacHangTool.Name = "DanhSachKhacHangTool";
            this.DanhSachKhacHangTool.Size = new System.Drawing.Size(258, 26);
            this.DanhSachKhacHangTool.Text = "Danh Sách Khách Hàng";
            this.DanhSachKhacHangTool.Click += new System.EventHandler(this.DanhSachKhacHangTool_Click);
            // 
            // DanhSachNhanVienTool
            // 
            this.DanhSachNhanVienTool.Name = "DanhSachNhanVienTool";
            this.DanhSachNhanVienTool.Size = new System.Drawing.Size(258, 26);
            this.DanhSachNhanVienTool.Text = "Danh Sách nhân viên";
            this.DanhSachNhanVienTool.Click += new System.EventHandler(this.DanhSachNhanVienTool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG BÁN ĐIỆN THOẠI DI ĐỘNG";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 478);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Bán Điện Thoại Di Động";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnHeThong;
        public System.Windows.Forms.ToolStripMenuItem DangNhapTool;
        public System.Windows.Forms.ToolStripMenuItem DangXuatTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauTool;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem SanPhamTool;
        private System.Windows.Forms.ToolStripMenuItem HangSXTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem KhachHangTool;
        private System.Windows.Forms.ToolStripMenuItem NhanVienTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem HoaDonBanTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ThemHoaDonBanTool;
        private System.Windows.Forms.ToolStripDropDownButton btnThongKe;
        private System.Windows.Forms.ToolStripMenuItem DoanhThuTool;
        private System.Windows.Forms.ToolStripMenuItem DanhSachKhacHangTool;
        private System.Windows.Forms.ToolStripMenuItem DanhSachNhanVienTool;
        private System.Windows.Forms.Label label1;

    }
}

