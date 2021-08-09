namespace GUI
{
    partial class frmHoaDonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.rdbTenNV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMaHD = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtThongTinCanTim = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.te = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hóa đơn bán";
            // 
            // dtgvDanhSachHoaDon
            // 
            this.dtgvDanhSachHoaDon.AllowUserToAddRows = false;
            this.dtgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ck,
            this.Column2,
            this.Ng,
            this.Column3});
            this.dtgvDanhSachHoaDon.Location = new System.Drawing.Point(6, 98);
            this.dtgvDanhSachHoaDon.MultiSelect = false;
            this.dtgvDanhSachHoaDon.Name = "dtgvDanhSachHoaDon";
            this.dtgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dtgvDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachHoaDon.Size = new System.Drawing.Size(659, 285);
            this.dtgvDanhSachHoaDon.TabIndex = 0;
            this.dtgvDanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachHoaDon_CellClick);
            // 
            // rdbTenNV
            // 
            this.rdbTenNV.AutoSize = true;
            this.rdbTenNV.Location = new System.Drawing.Point(17, 65);
            this.rdbTenNV.Name = "rdbTenNV";
            this.rdbTenNV.Size = new System.Drawing.Size(134, 17);
            this.rdbTenNV.TabIndex = 10;
            this.rdbTenNV.TabStop = true;
            this.rdbTenNV.Text = "Tìm theo tên nhân viên";
            this.rdbTenNV.UseVisualStyleBackColor = true;
            this.rdbTenNV.CheckedChanged += new System.EventHandler(this.rdbTenNV_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMaHD);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtThongTinCanTim);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtgvDanhSachHoaDon);
            this.groupBox1.Controls.Add(this.rdbTenNV);
            this.groupBox1.Location = new System.Drawing.Point(11, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 394);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục hóa đơn";
            // 
            // rdbMaHD
            // 
            this.rdbMaHD.AutoSize = true;
            this.rdbMaHD.Checked = true;
            this.rdbMaHD.Location = new System.Drawing.Point(17, 30);
            this.rdbMaHD.Name = "rdbMaHD";
            this.rdbMaHD.Size = new System.Drawing.Size(126, 17);
            this.rdbMaHD.TabIndex = 15;
            this.rdbMaHD.TabStop = true;
            this.rdbMaHD.Text = "Tìm theo mã hóa đơn";
            this.rdbMaHD.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(436, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 32);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtThongTinCanTim
            // 
            this.txtThongTinCanTim.Location = new System.Drawing.Point(231, 64);
            this.txtThongTinCanTim.Name = "txtThongTinCanTim";
            this.txtThongTinCanTim.Size = new System.Drawing.Size(121, 20);
            this.txtThongTinCanTim.TabIndex = 13;
            this.txtThongTinCanTim.TextChanged += new System.EventHandler(this.txtThongTinSanPham_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Nhập thông tin cần tìm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietHD);
            this.groupBox2.Location = new System.Drawing.Point(721, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 394);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi TIết hóa đơn";
            // 
            // dtgvChiTietHD
            // 
            this.dtgvChiTietHD.AllowUserToAddRows = false;
            this.dtgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.te,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column5});
            this.dtgvChiTietHD.Location = new System.Drawing.Point(6, 36);
            this.dtgvChiTietHD.Name = "dtgvChiTietHD";
            this.dtgvChiTietHD.RowHeadersVisible = false;
            this.dtgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietHD.Size = new System.Drawing.Size(525, 347);
            this.dtgvChiTietHD.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaSP";
            this.Column4.HeaderText = "Mã sản phẩm";
            this.Column4.Name = "Column4";
            // 
            // te
            // 
            this.te.DataPropertyName = "TenSP";
            this.te.HeaderText = "Tên sản phẩm";
            this.te.Name = "te";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonGia";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TongTien";
            this.Column8.HeaderText = "Tổng tiền";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "XUATXU";
            this.Column5.HeaderText = "Xuất xứ";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // ck
            // 
            this.ck.DataPropertyName = "HoTen";
            this.ck.FillWeight = 130F;
            this.ck.HeaderText = "Tên NV";
            this.ck.Name = "ck";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.Name = "Column2";
            // 
            // Ng
            // 
            this.Ng.DataPropertyName = "NGAYLAPHD";
            this.Ng.HeaderText = "Ngày lập";
            this.Ng.Name = "Ng";
            this.Ng.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TONGTIEN";
            this.Column3.HeaderText = "Tổng tiền";
            this.Column3.Name = "Column3";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1290, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDon;
        private System.Windows.Forms.RadioButton rdbTenNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtThongTinCanTim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietHD;
        private System.Windows.Forms.RadioButton rdbMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn te;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}