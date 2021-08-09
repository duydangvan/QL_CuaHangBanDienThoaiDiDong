using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        TaiKhoanBLL tk = new TaiKhoanBLL();

        public frmDangKy()
        {
            InitializeComponent();
            nhanDL = new layDL(ganDL);
        }

        string fileImage = Environment.CurrentDirectory + @"\ImageNhanVien\";

        public delegate void layDL(string pMaNV);
        public layDL nhanDL;

        void ganDL(string pMaNV)
        {
            lbMaNV.Text = pMaNV;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            lbTenNV.Text = nv.loadTenNV(lbMaNV.Text.Trim());
            ptbNhanVien.Image.Dispose();
            string ImageNhanVien=fileImage+nv.loadAnhLen_Tk(lbMaNV.Text.Trim());
            ptbNhanVien.Image = Image.FromFile(ImageNhanVien);
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            txtTK.Text = string.Empty;
        }

        bool kiemTraTrungMK()
        {
            if (txtMK.Text.Trim().Equals(txtNhapLaiMK.Text.Trim()))
                return true;
            return false;
        }
        bool kiemTraRong()
        {
            if(txtTK.Text==string.Empty || txtMK.Text==string.Empty)
            {
                return true;
            }
            return false;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (kiemTraTrungMK())
                {
                    if (!tk.kiemTraTrungTDN(txtTK.Text.Trim()))
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí tài khoản chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            tk.insertTK(txtTK.Text.Trim(), txtMK.Text.Trim(), lbMaNV.Text.Trim());
                            MessageBox.Show("Đã đăng kí tài khoản thành công", "Thông báo");
                            lbCanhBao.Visible = false;
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Tên đăng nhập đã tồn tại","Thông báo");
                }
                else
                {
                    lbCanhBao.Text = "Hai mật khẩu chưa trùng khớp";
                    lbCanhBao.Visible = true;
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin","Thông báo");
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Text = string.Empty;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK.Text = string.Empty;
        }
    }
}
