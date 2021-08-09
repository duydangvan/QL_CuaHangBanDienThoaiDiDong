using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDSSanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        
        public frmDSSanPham()
        {
            InitializeComponent();
        }

        private void frnDSSanPham_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = sp.loadSanPham();
        }

        private void rdbTenSP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTenSP.Checked)
            {
                rdbNoiXuatXu.Checked = false;

            }
        }

        private void rdbNoiXuatXu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNoiXuatXu.Checked)
            {
                rdbTenSP.Checked = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdbNoiXuatXu.Checked == false && rdbTenSP.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo cái gì","Thông báo");
            }
            else
            {
                if (txtTimKiem.Text == string.Empty)
                {
                    dtgvSanPham.DataSource = sp.loadSanPham();
                }
                else
                {
                    if (rdbTenSP.Checked)
                        dtgvSanPham.DataSource = sp.timKiemTenSP(txtTimKiem.Text.Trim());
                    else
                        dtgvSanPham.DataSource = sp.timKiemXuatXu(txtTimKiem.Text.Trim());
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmSuaSanPham f = new frmSuaSanPham();
            f.ganDL("All");
            f.btnSuaSP.Visible = false;
            f.ShowDialog();
            dtgvSanPham.DataSource = sp.loadSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaSanPham s = new frmSuaSanPham();
            s.ganDL(dtgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
            s.cbbMaSX.Enabled = false;
            s.btnLoadMa.Visible = false;
            s.txtBoNhoTrong.Enabled = false;
            s.txtChieuDai.Enabled = false;
            s.txtChieuRong.Enabled = false;
            s.txtDoDay.Enabled = false;
            s.txtDonGia.Enabled = false;
            s.txtHeDieuHanh.Enabled = false;
            s.txtManHinh.Enabled = false;
            s.txtMoTa.Enabled = false;
            s.txtRam.Enabled = false;
            s.txtSoLuong.Enabled = false;
            s.txtTenSP.Enabled = false;
            s.txtThoiGian_BH.Enabled = false;
            s.txtTrongLuong.Enabled = false;
            s.txtXuatXu.Enabled = false;
            s.btnBrowser.Enabled = false;
            s.ShowDialog();
            dtgvSanPham.DataSource = sp.loadSanPham();
        }

        private void btnXemCTSP_Click(object sender, EventArgs e)
        {
            frmChiTietSanPham f = new frmChiTietSanPham();
            f.ganDL(dtgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim(), dtgvSanPham.CurrentRow.Cells[1].Value.ToString().Trim());
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDSSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ","Thông báo", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
