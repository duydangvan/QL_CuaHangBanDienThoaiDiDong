using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        KhachHangBLL kh = new KhachHangBLL();
        HoaDonBLL hd = new HoaDonBLL();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = kh.tuDongLoadMaKHKhongTrung();
            loadKHLen();
        }

        void reSet()
        {
            txtTenKH.Text =string.Empty;
            txtMaKH.Text = kh.tuDongLoadMaKHKhongTrung();
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtNamSinh.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadKHLen();
            txtMaKH.Text = kh.tuDongLoadMaKHKhongTrung();
            dtgvDSKHTimKien.DataSource = hd.loadHDLenKH();
        }

        public void loadKHLen()
        {
            dtgvDSKH.DataSource = kh.loadKH();
        }

        bool kiemTraRong()
        {
            if (txtDiaChi.Text == string.Empty && txtNamSinh.Text == string.Empty && txtSDT.Text == string.Empty && txtTenKH.Text == string.Empty)
                return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng " + txtTenKH.Text.Trim() + " vào hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int kq = kh.insertKH(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), int.Parse(txtNamSinh.Text.Trim()), txtEmail.Text.Trim());
                    if (kq == 1)
                    {
                        loadKHLen();
                        MessageBox.Show("Đã thêm khách hàng " + txtTenKH.Text.Trim() + " vào hệ thống thành công", "Thông báo");
                        reSet();
                    }
                    else
                        MessageBox.Show("Đã bị trùng mã khách hàng trong hệ thống", "Thông báo");
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin của khách hàng","Thông báo");
        }

        private void dtgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvDSKH.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenKH.Text = dtgvDSKH.CurrentRow.Cells[1].Value.ToString().Trim();
            txtSDT.Text = dtgvDSKH.CurrentRow.Cells[2].Value.ToString().Trim();
            txtNamSinh.Text = dtgvDSKH.CurrentRow.Cells[3].Value.ToString().Trim();
            txtEmail.Text = dtgvDSKH.CurrentRow.Cells[4].Value.ToString().Trim();
            txtDiaChi.Text = dtgvDSKH.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin khách hàng " + txtTenKH.Text.Trim() + " trong hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kh.UpdateKH(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), int.Parse(txtNamSinh.Text.Trim()), txtEmail.Text.Trim());
                    loadKHLen();
                    MessageBox.Show("Đã sửa thông tin thành công", "Thông báo");
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin của khách hàng","Thông báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reSet();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbMaKH.Checked)
                rdbTenKH.Checked = true;
        }

        private void rdbTenKH_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbTenKH.Checked)
                rdbMaKH.Checked = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbMaKH.Checked)
            {
                dtgvDSKHTimKien.DataSource = kh.timKemMaKH(txtThongTinKH.Text.Trim());
            }
            else
                dtgvDSKHTimKien.DataSource = kh.timKiemTenKH(txtThongTinKH.Text.Trim());
        }

        private void txtThongTinKH_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaKH.Checked)
            {

                dtgvDSKHTimKien.DataSource = kh.timKemMaKH(txtThongTinKH.Text.Trim());
            }
            else
                dtgvDSKHTimKien.DataSource = kh.timKiemTenKH(txtThongTinKH.Text.Trim());
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
