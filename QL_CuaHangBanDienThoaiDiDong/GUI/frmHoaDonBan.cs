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
    public partial class frmHoaDonBan : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void rdbTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTenNV.Checked)
            {
                rdbMaHD.Checked = false;
                dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoTenNV(txtThongTinCanTim.Text.Trim());
            }
        }

        private void rdbMaHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaHD.Checked)
            {
                rdbTenNV.Checked = false;
                dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoMaHD(txtThongTinCanTim.Text.Trim());
            }
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        
        void loadHoaDon()
        {
            dtgvDanhSachHoaDon.DataSource = hd.loadHDLenHD();
            dtgvDanhSachHoaDon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dtgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dtgvDanhSachHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtgvChiTietHD.DataSource = hd.loadChiTietHD_TheoMaHD(mahd);
        }

        private void txtThongTinSanPham_TextChanged(object sender, EventArgs e)
        {
            if(rdbMaHD.Checked)
            {
                dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoMaHD(txtThongTinCanTim.Text.Trim());
            }
            else
            if(rdbTenNV.Checked)
                dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoTenNV(txtThongTinCanTim.Text.Trim());
            else
                loadHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbMaHD.Checked)
            {
                dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoMaHD(txtThongTinCanTim.Text.Trim());
            }
            else
                if (rdbTenNV.Checked)
                    dtgvDanhSachHoaDon.DataSource = hd.loadHD_TheoTenNV(txtThongTinCanTim.Text.Trim());
                else
                    loadHoaDon();
            dtgvChiTietHD.DataSource = new DataTable();
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ","Thông báo", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
