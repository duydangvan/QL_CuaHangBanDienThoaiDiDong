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
    public partial class frmDanhNhap : Form
    {
        TaiKhoanBLL tk = new TaiKhoanBLL();
        NhanVienBLL nv = new NhanVienBLL();

        public frmDanhNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(tk.kiemTraDangNhap(txtTenDangNhap.Text.Trim(),txtMatKhau.Text.Trim()))
            {
                frmMain f = new frmMain();
                frmMain.kiemTraDangNhap = true;
                f.lbTenNV.Text = tk.TenNV_TaiKhoan(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                f.lbMaNV.Text = tk.loadMaNV_TaiKhoan(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                f.DangXuatTool.Visible = true;
                f.DangNhapTool.Visible = false;
                string chucVu = tk.ChucVu(txtTenDangNhap.Text.Trim(),txtMatKhau.Text.Trim());
                if (chucVu == "Chủ")
                {
                    frmMain.isChu = true;
                    frmMain.isNV = false;
                }
                else
                {
                    frmMain.isNV = true;
                    frmMain.isChu = false;
                }
                f.ShowDialog();
          
            }
            else
            {
                lbCanhBao.Visible = true;
            }
        }
    }
}
