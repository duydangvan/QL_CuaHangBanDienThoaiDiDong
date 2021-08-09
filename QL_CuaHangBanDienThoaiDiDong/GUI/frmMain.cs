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
    public partial class frmMain : Form
    {

        public static bool kiemTraDangNhap = false;
        public static bool nhanVien = false;
        public static bool Chu = false;
        public static bool isChu = false;
        public static bool isNV = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNguiowifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DangNhapTool_Click(object sender, EventArgs e)
        {
            frmDanhNhap f = new frmDanhNhap();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (kiemTraDangNhap)
            {
                btnQuanLy.Enabled = true;
                btnThongKe.Enabled = true;
                if (isChu)
                {
                    NhanVienTool.Visible = true;
                }
                else
                {
                    NhanVienTool.Visible = false;
                    btnThongKe.Visible = false;
                }
            }
        }


        private void DangXuatTool_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn đăng xuất chứ","Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                btnQuanLy.Enabled = false;
                btnThongKe.Visible = true;
                btnThongKe.Enabled = false;
                kiemTraDangNhap = false;
                lbTenNV.Text = "Không có";
                lbMaNV.Text = "Không có";
                DangNhapTool.Visible = true;
                DangXuatTool.Visible = false;
                
            }
        }

        private void DoiMatKhauTool_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }

        private void SanPhamTool_Click(object sender, EventArgs e)
        {
            frmDSSanPham f = new frmDSSanPham();
            f.ShowDialog();
        }

        private void KhachHangTool_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void NhanVienTool_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void HoaDonBanTool_Click(object sender, EventArgs e)
        {
            frmHoaDonBan f = new frmHoaDonBan();
            f.ShowDialog();
        }

        private void ThemHoaDonBanTool_Click(object sender, EventArgs e)
        {
            frmMuaHang f = new frmMuaHang();
            f.nhanDL(lbMaNV.Text.Trim(),lbTenNV.Text.Trim());
            f.ShowDialog();
        }

        private void DoanhThuTool_Click(object sender, EventArgs e)
        {
            frmThongKeNV f = new frmThongKeNV();
            f.ShowDialog();
        }

        private void DanhSachKhacHangTool_Click(object sender, EventArgs e)
        {
            frmDSKH f = new frmDSKH();
            f.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HangSXTool_Click(object sender, EventArgs e)
        {
            frmHangSanXuat f = new frmHangSanXuat();
            f.ShowDialog();
        }

        private void DanhSachNhanVienTool_Click(object sender, EventArgs e)
        {
            frmDSNV f = new frmDSNV();
            f.ShowDialog();
        }
    }
}
