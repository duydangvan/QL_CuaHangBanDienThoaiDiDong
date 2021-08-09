namespace GUI
{
    partial class frmThongKeNV
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
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTK_Theo_TongTien = new System.Windows.Forms.RadioButton();
            this.rdb_TK_Theo_SLHD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKhenThuong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dPTo = new System.Windows.Forms.DateTimePicker();
            this.dPFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thống kê nhân viên";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AllowUserToAddRows = false;
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.t,
            this.Column2,
            this.Column3,
            this.Column4,
            this.E,
            this.Column5,
            this.Column6});
            this.dtgvNhanVien.Location = new System.Drawing.Point(24, 159);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersVisible = false;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(786, 311);
            this.dtgvNhanVien.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // t
            // 
            this.t.DataPropertyName = "HOTEN";
            this.t.FillWeight = 130F;
            this.t.HeaderText = "Tên nhân viên";
            this.t.Name = "t";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DIACHI";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYSINH";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "SDT";
            this.Column4.Name = "Column4";
            // 
            // E
            // 
            this.E.DataPropertyName = "EMAIL";
            this.E.FillWeight = 130F;
            this.E.HeaderText = "Email";
            this.E.Name = "E";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAHD";
            this.Column5.FillWeight = 70F;
            this.Column5.HeaderText = "Mã hóa đơn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TONGTIEN";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdbTK_Theo_TongTien);
            this.groupBox1.Controls.Add(this.rdb_TK_Theo_SLHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKhenThuong);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.dPTo);
            this.groupBox1.Controls.Add(this.dPFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 76);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // rdbTK_Theo_TongTien
            // 
            this.rdbTK_Theo_TongTien.AutoSize = true;
            this.rdbTK_Theo_TongTien.Location = new System.Drawing.Point(400, 17);
            this.rdbTK_Theo_TongTien.Name = "rdbTK_Theo_TongTien";
            this.rdbTK_Theo_TongTien.Size = new System.Drawing.Size(94, 17);
            this.rdbTK_Theo_TongTien.TabIndex = 8;
            this.rdbTK_Theo_TongTien.Text = "Theo tổng tiền";
            this.rdbTK_Theo_TongTien.UseVisualStyleBackColor = true;
            this.rdbTK_Theo_TongTien.CheckedChanged += new System.EventHandler(this.rdbTK_Theo_TongTien_CheckedChanged);
            // 
            // rdb_TK_Theo_SLHD
            // 
            this.rdb_TK_Theo_SLHD.AutoSize = true;
            this.rdb_TK_Theo_SLHD.Checked = true;
            this.rdb_TK_Theo_SLHD.Location = new System.Drawing.Point(215, 17);
            this.rdb_TK_Theo_SLHD.Name = "rdb_TK_Theo_SLHD";
            this.rdb_TK_Theo_SLHD.Size = new System.Drawing.Size(136, 17);
            this.rdb_TK_Theo_SLHD.TabIndex = 7;
            this.rdb_TK_Theo_SLHD.TabStop = true;
            this.rdb_TK_Theo_SLHD.Text = "Theo số lượng hóa đơn";
            this.rdb_TK_Theo_SLHD.UseVisualStyleBackColor = true;
            this.rdb_TK_Theo_SLHD.CheckedChanged += new System.EventHandler(this.rdb_TK_Theo_SLHD_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thống kê doanh thu theo:";
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Location = new System.Drawing.Point(684, 16);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Size = new System.Drawing.Size(87, 23);
            this.btnKhenThuong.TabIndex = 5;
            this.btnKhenThuong.Text = "Khen thưởng";
            this.btnKhenThuong.UseVisualStyleBackColor = true;
            this.btnKhenThuong.Click += new System.EventHandler(this.btnKhenThuong_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(552, 15);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(87, 23);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dPTo
            // 
            this.dPTo.CustomFormat = "dd/MM/yyyy";
            this.dPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPTo.Location = new System.Drawing.Point(329, 47);
            this.dPTo.Name = "dPTo";
            this.dPTo.Size = new System.Drawing.Size(182, 20);
            this.dPTo.TabIndex = 3;
            // 
            // dPFrom
            // 
            this.dPFrom.CustomFormat = "dd/MM/yyyy";
            this.dPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPFrom.Location = new System.Drawing.Point(73, 47);
            this.dPFrom.Name = "dPFrom";
            this.dPFrom.Size = new System.Drawing.Size(182, 20);
            this.dPFrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTienThuong);
            this.groupBox2.Controls.Add(this.txtLyDo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbDiaChi);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbTenNV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbMaNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 117);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả thống kê";
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Location = new System.Drawing.Point(596, 67);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(112, 20);
            this.txtTienThuong.TabIndex = 13;
            this.txtTienThuong.TextChanged += new System.EventHandler(this.txtTienThuong_TextChanged);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(194, 67);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(241, 20);
            this.txtLyDo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Số tiền khen thưởng:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(593, 37);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(25, 13);
            this.lbDiaChi.TabIndex = 9;
            this.lbDiaChi.Text = "Null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(553, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Lý do khen thưởng:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(384, 37);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(25, 13);
            this.lbTenNV.TabIndex = 3;
            this.lbTenNV.Text = "Null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên nhân viên:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(98, 37);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(25, 13);
            this.lbMaNV.TabIndex = 1;
            this.lbMaNV.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(636, 50);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(25, 13);
            this.lbTongTien.TabIndex = 10;
            this.lbTongTien.Text = "Null";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(837, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonNhap";
            this.Text = "Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhenThuong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dPTo;
        private System.Windows.Forms.DateTimePicker dPFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtTienThuong;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.RadioButton rdbTK_Theo_TongTien;
        private System.Windows.Forms.RadioButton rdb_TK_Theo_SLHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label6;

    }
}