namespace GUI
{
    partial class frmHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangSanXuat));
            this.label1 = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.PictureBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenHangSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHangSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvDSHSX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Te = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvDSHSXTimKien = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbTenHangSX = new System.Windows.Forms.RadioButton();
            this.rdbMaHangSX = new System.Windows.Forms.RadioButton();
            this.txtThongTinHangSX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSX)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSXTimKien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng Sản Xuất";
            // 
            // xx
            // 
            this.xx.Controls.Add(this.btnCapNhat);
            this.xx.Controls.Add(this.txtDiaChi);
            this.xx.Controls.Add(this.label8);
            this.xx.Controls.Add(this.txtSDT);
            this.xx.Controls.Add(this.label9);
            this.xx.Controls.Add(this.txtTenHangSX);
            this.xx.Controls.Add(this.label3);
            this.xx.Controls.Add(this.txtMaHangSX);
            this.xx.Controls.Add(this.label2);
            this.xx.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.xx.Location = new System.Drawing.Point(12, 60);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(608, 133);
            this.xx.TabIndex = 0;
            this.xx.TabStop = false;
            this.xx.Text = "Thông tin hãng sản xuất";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(282, 34);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(24, 20);
            this.btnCapNhat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCapNhat.TabIndex = 50;
            this.btnCapNhat.TabStop = false;
            this.btnCapNhat.Tag = "Cập nhật mã hóa đơn";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(420, 34);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 25);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(420, 81);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(172, 25);
            this.txtSDT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtTenHangSX
            // 
            this.txtTenHangSX.Location = new System.Drawing.Point(134, 81);
            this.txtTenHangSX.Name = "txtTenHangSX";
            this.txtTenHangSX.Size = new System.Drawing.Size(172, 25);
            this.txtTenHangSX.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tên hãng sản xuất:";
            // 
            // txtMaHangSX
            // 
            this.txtMaHangSX.Enabled = false;
            this.txtMaHangSX.Location = new System.Drawing.Point(134, 34);
            this.txtMaHangSX.Name = "txtMaHangSX";
            this.txtMaHangSX.Size = new System.Drawing.Size(142, 25);
            this.txtMaHangSX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã hãng sản xuất";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(134, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "        Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(385, 227);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "   Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(258, 228);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(511, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 30);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(10, 264);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 314);
            this.tabControl1.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgvDSHSX);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách hãng sản xuất";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvDSHSX
            // 
            this.dtgvDSHSX.AllowUserToAddRows = false;
            this.dtgvDSHSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Te,
            this.Column2,
            this.Column3});
            this.dtgvDSHSX.Location = new System.Drawing.Point(3, 6);
            this.dtgvDSHSX.MultiSelect = false;
            this.dtgvDSHSX.Name = "dtgvDSHSX";
            this.dtgvDSHSX.RowHeadersVisible = false;
            this.dtgvDSHSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSHSX.Size = new System.Drawing.Size(602, 272);
            this.dtgvDSHSX.TabIndex = 0;
            this.dtgvDSHSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHSX_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHANGSX";
            this.Column1.HeaderText = "Mã hãng sản suất";
            this.Column1.Name = "Column1";
            // 
            // Te
            // 
            this.Te.DataPropertyName = "TENHANGSX";
            this.Te.HeaderText = "Tên hãng sản xuất";
            this.Te.Name = "Te";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DIACHI";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dtgvDSHSXTimKien);
            this.tabPage2.Controls.Add(this.btnTimKiem);
            this.tabPage2.Controls.Add(this.rdbTenHangSX);
            this.tabPage2.Controls.Add(this.rdbMaHangSX);
            this.tabPage2.Controls.Add(this.txtThongTinHangSX);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm thông tin";
            // 
            // dtgvDSHSXTimKien
            // 
            this.dtgvDSHSXTimKien.AllowUserToAddRows = false;
            this.dtgvDSHSXTimKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHSXTimKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHSXTimKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvDSHSXTimKien.Location = new System.Drawing.Point(204, 6);
            this.dtgvDSHSXTimKien.MultiSelect = false;
            this.dtgvDSHSXTimKien.Name = "dtgvDSHSXTimKien";
            this.dtgvDSHSXTimKien.RowHeadersVisible = false;
            this.dtgvDSHSXTimKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSHSXTimKien.Size = new System.Drawing.Size(402, 272);
            this.dtgvDSHSXTimKien.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(13, 203);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 30);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "     Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbTenHangSX
            // 
            this.rdbTenHangSX.AutoSize = true;
            this.rdbTenHangSX.Location = new System.Drawing.Point(13, 74);
            this.rdbTenHangSX.Name = "rdbTenHangSX";
            this.rdbTenHangSX.Size = new System.Drawing.Size(185, 21);
            this.rdbTenHangSX.TabIndex = 16;
            this.rdbTenHangSX.TabStop = true;
            this.rdbTenHangSX.Text = "Tìm theo tên hãng sản xuất";
            this.rdbTenHangSX.UseVisualStyleBackColor = true;
            this.rdbTenHangSX.CheckedChanged += new System.EventHandler(this.rdbTenHangSX_CheckedChanged);
            // 
            // rdbMaHangSX
            // 
            this.rdbMaHangSX.AutoSize = true;
            this.rdbMaHangSX.Checked = true;
            this.rdbMaHangSX.Location = new System.Drawing.Point(13, 35);
            this.rdbMaHangSX.Name = "rdbMaHangSX";
            this.rdbMaHangSX.Size = new System.Drawing.Size(185, 21);
            this.rdbMaHangSX.TabIndex = 15;
            this.rdbMaHangSX.TabStop = true;
            this.rdbMaHangSX.Text = "Tìm theo mã hãng sản xuất";
            this.rdbMaHangSX.UseVisualStyleBackColor = true;
            this.rdbMaHangSX.CheckedChanged += new System.EventHandler(this.rdbMaHangSX_CheckedChanged);
            // 
            // txtThongTinHangSX
            // 
            this.txtThongTinHangSX.Location = new System.Drawing.Point(13, 154);
            this.txtThongTinHangSX.Name = "txtThongTinHangSX";
            this.txtThongTinHangSX.Size = new System.Drawing.Size(171, 25);
            this.txtThongTinHangSX.TabIndex = 14;
            this.txtThongTinHangSX.TextChanged += new System.EventHandler(this.txtThongTinHangSX_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nhập thông tin cần tìm:";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MASP";
            this.Column4.HeaderText = "Mã sản phẩm";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENSP";
            this.Column5.HeaderText = "Tên sản phẩm";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Dongia";
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.Name = "Column6";
            // 
            // frmHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(642, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.label1);
            this.Name = "frmHangSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hãng Sản Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangSanXuat_FormClosing);
            this.Load += new System.EventHandler(this.frmHangSanXuat_Load);
            this.xx.ResumeLayout(false);
            this.xx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHSXTimKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox xx;
        private System.Windows.Forms.PictureBox btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenHangSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHangSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvDSHSX;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvDSHSXTimKien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbTenHangSX;
        private System.Windows.Forms.RadioButton rdbMaHangSX;
        private System.Windows.Forms.TextBox txtThongTinHangSX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Te;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}