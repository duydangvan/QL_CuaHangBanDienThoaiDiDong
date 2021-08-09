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
    public partial class frmHangSanXuat : Form
    {
        HangSX_BLL hangSX = new HangSX_BLL();
        SanPhamBLL sp = new SanPhamBLL();
        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            loadHangSX();
            txtMaHangSX.Text = hangSX.loadMaHangSXTuDong();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaHangSX.Text = hangSX.loadMaHangSXTuDong();
        }

        bool kiemTraRong()
        {
            if (txtMaHangSX.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSDT.Text == string.Empty || txtTenHangSX.Text == string.Empty)
                return true;
            return false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        void loadHangSX()
        {
            dtgvDSHSX.DataSource = hangSX.loadHangSX();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắc muốn lưu lại thông tin của hãng " + txtTenHangSX.Text.Trim() + " vào hệ thống chưa", "Thông báo",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    hangSX.updateHSX(txtMaHangSX.Text.Trim(), txtTenHangSX.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
                    loadHangSX();
                    MessageBox.Show("Đã sửa thông tin nhà sản xuất thành công", "Thông báo");
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;

                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin của hãng sản xuất", "Thông báo");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm thông tin hãng " + txtTenHangSX.Text.Trim() + " vào hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int kq = hangSX.insertHSX_BLL(txtMaHangSX.Text.Trim(), txtTenHangSX.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
                    if (kq == 1)
                    {
                        loadHangSX();
                        MessageBox.Show("Đã thêm hãng sản xuất mới thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Đã bị trùng mã với hãng sản xuất khác trong hệ thống", "Thông báo");
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin của hãng sản xuất", "Thông báo");
        }

        private void dtgvDSHSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHangSX.Text = dtgvDSHSX.CurrentRow.Cells[0].Value.ToString().Trim();
            txtTenHangSX.Text = dtgvDSHSX.CurrentRow.Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dtgvDSHSX.CurrentRow.Cells[2].Value.ToString().Trim();
            txtSDT.Text = dtgvDSHSX.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        void reset()
        {
            txtTenHangSX.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHangSX.Text = hangSX.loadMaHangSXTuDong();
            reset();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void rdbMaHangSX_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaHangSX.Checked)
                rdbTenHangSX.Checked = false;
            if (rdbMaHangSX.Checked)
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoMaHangSX(txtThongTinHangSX.Text.Trim());
            else
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoTenHangSX(txtThongTinHangSX.Text.Trim());
        }

        private void rdbTenHangSX_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTenHangSX.Checked)
                rdbMaHangSX.Checked = false;
            if (rdbMaHangSX.Checked)
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoMaHangSX(txtThongTinHangSX.Text.Trim());
            else
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoTenHangSX(txtThongTinHangSX.Text.Trim());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbMaHangSX.Checked)
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoMaHangSX(txtThongTinHangSX.Text.Trim());
            else
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoTenHangSX(txtThongTinHangSX.Text.Trim());
        }

        private void txtThongTinHangSX_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaHangSX.Checked)
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoMaHangSX(txtThongTinHangSX.Text.Trim());
            else
                dtgvDSHSXTimKien.DataSource = sp.loadSP_TheoTenHangSX(txtThongTinHangSX.Text.Trim());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangSanXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
