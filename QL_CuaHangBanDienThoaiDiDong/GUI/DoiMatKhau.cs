using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanBLL tk = new TaiKhoanBLL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txtMaBaoVe_Click(object sender, EventArgs e)
        {
            txtMaBaoVe.Text=string.Empty;
        }

        void tuDongTaoMa()
        {
            string tam=string.Empty;
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                 tam += Convert.ToString((char)rd.Next(65, 90))+" ";
            }
            lbMaBaoVe.Text = tam;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text != string.Empty)
            {
                if (kiemTra2MKTrung())
                {
                    lbTrungMK.Visible = false;
                    if (tk.kiemTraDangNhap(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim()))
                    {
                        lbCanhBao.Visible = false;
                        if (kiemTraTrungMaBaoVe())
                        {
                            lbCanhBaoMaBaoVe.Visible = false;
                            tk.updateTK(txtTenDangNhap.Text.Trim(), txtMKMoi.Text.Trim());
                            MessageBox.Show("Đã thay đổi mật khẩu mới thành công", "Thông báo");
                            reset();
                        }
                        else
                        {
                            lbCanhBaoMaBaoVe.Visible = true;
                        }
                    }
                    else
                    {
                        lbCanhBao.Visible = true;
                    }
                }
                else
                {
                    lbTrungMK.Visible = true;
                }
            }
            else
                MessageBox.Show("Không được để trống mật khẩu","Thông báo");
        }

        void reset()
        {
            txtTenDangNhap.Text = "Tên đăng nhập";
            txtMatKhau.Text = "Mật Khẩu cũ";
            txtMKMoi.Text = "Mật khẩu mới";
            txtNhapLaiMK.Text = "Nhập lại mật khẩu mới";
            tuDongTaoMa();
            txtMaBaoVe.Text = "Nhập mã bảo vệ";
        }

        bool kiemTraTrungMaBaoVe()
        {
            string maBaoVe = lbMaBaoVe.Text.Trim().Replace(" ","");
            if (maBaoVe.Equals(txtMaBaoVe.Text.Trim()))
                return true;
            return false;
        }

        bool kiemTra2MKTrung()
        {
            if(txtMKMoi.Text.Trim().Equals(txtNhapLaiMK.Text.Trim()))
            {
                return true;
            }
            return false;

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            lbMaBaoVe.Text = string.Empty;
            tuDongTaoMa();
        }


        private void txtNhapLaiMK_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK.Text = string.Empty;
        }


        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = string.Empty;
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = string.Empty;
        }

        private void txtMKMoi_Click(object sender, EventArgs e)
        {
            txtMKMoi.Text = string.Empty;
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
