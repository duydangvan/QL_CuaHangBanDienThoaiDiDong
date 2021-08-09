using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSuaSanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        static string fileImageSP = Environment.CurrentDirectory + @"\ImageSanPham\";
        static string fileName="default.jpg";
        static Image img;
        public frmSuaSanPham()
        {
            InitializeComponent();
            ganDL = new tinHieuLoadDL(NhanDL);
        }
        string tinhieu;

        public delegate void tinHieuLoadDL(string tinnhan);
         public tinHieuLoadDL ganDL;
        void NhanDL(string tinNhan)
        {
             tinhieu=tinNhan;
        }
        

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh";
            open.Filter = "Image File (*.JPG)|*.jpg| All Files (*.*)|*.*";
            if(open.ShowDialog()==DialogResult.OK)
            {
                ptbSanPham.Image.Dispose();
                ptbSanPham.Image = Image.FromFile(open.FileName);
                fileName = txtMaSP.Text.Trim() + "_" + convertStringVN_into_English(txtXuatXu.Text.Trim()).Replace(" ", "") + ".jpg";
            }
        }

        void loadCbbTenHangSX()
        {
            cbbMaSX.DataSource = sp.loadCbbHangSX();
            cbbMaSX.DisplayMember = "TENHANGSX";
            cbbMaSX.ValueMember = "MAHANGSX";
        }

        private void frmSuaSanPham_Load(object sender, EventArgs e)
        {
            if (tinhieu == "All")
            {
                txtMaSP.Text = sp.tuDongTaoMaSPKhongTrung();
                loaddtgvSP();
                loadCbbTenHangSX();
            }
            else
            {
                dtgvThemSP.DataSource = sp.loadChiTiepSPTheoMaSP(tinhieu);
                txtMaSP.Text = dtgvThemSP.CurrentRow.Cells["clMaSP"].Value.ToString().Trim();
                loadCbbTenHangSX();
            }
        }

        private void btnLoadMa_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = sp.tuDongTaoMaSPKhongTrung();
        }

        private void cbbMaSX_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CbbThoiGian_BH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void loaddtgvSP()
        {
            dtgvThemSP.DataSource = sp.loadSP_ChiTiepSP();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnSuaSP.Visible = false;
            txtBoNhoTrong.Enabled = true;
            txtChieuDai.Enabled = true;
            txtChieuRong.Enabled = true;
            txtDoDay.Enabled = true;
            txtDonGia.Enabled = true;
            txtHeDieuHanh.Enabled = true;
            txtManHinh.Enabled = true;
            txtMoTa.Enabled = true;
            txtRam.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTenSP.Enabled = true;
            txtThoiGian_BH.Enabled = true;
            txtTrongLuong.Enabled = true;
            txtXuatXu.Enabled = false;
            btnBrowser.Enabled = true;
            cbbMaSX.Enabled = true;
        }
        void reSet()
        {
            txtBoNhoTrong.Text = string.Empty;
            txtChieuDai.Text = string.Empty;
            txtChieuRong.Text = string.Empty;
            txtDoDay.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtHeDieuHanh.Text = string.Empty;
            txtManHinh.Text = string.Empty;
            txtMaSP.Text = sp.tuDongTaoMaSPKhongTrung(); 
            txtMoTa.Text = string.Empty;
            txtRam.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtThoiGian_BH.Text = string.Empty;
            txtTrongLuong.Text = string.Empty;
            txtXuatXu.Text = string.Empty;
            fileName = "default.jpg";
            ptbSanPham.Image = Image.FromFile(fileImageSP + fileName);
        }

        void hienTrangLucDau()
        {
            btnSuaSP.Visible = true;
            btnSave.Visible = false;
            cbbMaSX.Enabled = false;
            cbbMaSX.SelectedIndex = 0;
            btnLoadMa.Visible = false;
            txtBoNhoTrong.Enabled = false;
            txtChieuDai.Enabled = false;
            txtChieuRong.Enabled = false;
            txtDoDay.Enabled = false;
            txtDonGia.Enabled = false;
            txtHeDieuHanh.Enabled = false;
            txtManHinh.Enabled = false;
            txtMoTa.Enabled = false;
            txtRam.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenSP.Enabled = false;
            txtThoiGian_BH.Enabled = false;
            txtTrongLuong.Enabled = false;
            txtXuatXu.Enabled = false;
            btnBrowser.Enabled = false;
        }


        bool kiemTraRong()
        {
            if (txtBoNhoTrong.Text == string.Empty || txtChieuDai.Text == string.Empty || txtChieuRong.Text == string.Empty || txtDoDay.Text == string.Empty ||
                txtDonGia.Text == string.Empty || txtHeDieuHanh.Text == string.Empty || txtManHinh.Text == string.Empty || txtMoTa.Text == string.Empty ||
                txtRam.Text == string.Empty || txtSoLuong.Text == string.Empty || txtTenSP.Text == string.Empty || txtTrongLuong.Text == string.Empty ||
                txtXuatXu.Text == string.Empty|| txtThoiGian_BH.Text==string.Empty)
                return true;
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemTraRong())
                {
                    if (fileName != "default.jpg")
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sản phẩm " + txtTenSP.Text.Trim() + " chưa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (!sp.kiemTraTrungTenSP(txtTenSP.Text.Trim()))
                            {
                                fileName = txtMaSP.Text.Trim() + "_" + convertStringVN_into_English(txtXuatXu.Text.Trim()).Replace(" ", "") + ".jpg";

                                string fileDalete = fileImageSP + fileName;
                                MemoryStream ms = new MemoryStream();
                                img = ptbSanPham.Image;
                                img.Save(ms, img.RawFormat);
                                ptbSanPham.Image.Dispose();
                                File.Delete(fileDalete);
                                Image newImage = Image.FromStream(ms);
                                newImage.Save(fileDalete);
                                sp.UpdateSP(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), float.Parse(txtDonGia.Text.Trim()), int.Parse(txtSoLuong.Text.Trim()), txtXuatXu.Text.Trim(), fileName,
                                    cbbMaSX.SelectedValue.ToString().Trim(), int.Parse(txtThoiGian_BH.Text.Trim()), double.Parse(txtChieuDai.Text.Trim()), double.Parse(txtChieuRong.Text.Trim()),
                                    double.Parse(txtDoDay.Text.Trim()), double.Parse(txtTrongLuong.Text.Trim()),
                                    double.Parse(txtManHinh.Text.Trim()), txtRam.Text.Trim(), txtBoNhoTrong.Text.Trim(),
                                    txtHeDieuHanh.Text.Trim(), txtMoTa.Text.Trim());

                                dtgvThemSP.DataSource = sp.loadChiTiepSPTheoMaSP(tinhieu);
                                MessageBox.Show("Đã sửa thông tin thành công", "Thông báo");
                                reSet();
                                hienTrangLucDau();
                            }
                            else
                                MessageBox.Show("Tên sản phẩm bạn sửa đã bị trùng tên trong cửa hàng","Thông báo");
                        }
                    }
                    else
                        MessageBox.Show("Bạn chưa chọn sản phẩm cần sửa", "Thông báo");
                }
                else
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin sản phẩm", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
            }
        }

        public static string convertStringVN_into_English(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }  

      
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm " + txtTenSP.Text.Trim() + " vào hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fileName = txtMaSP.Text.Trim() + "_" + convertStringVN_into_English(txtXuatXu.Text.Trim()).Replace(" ", "") + ".jpg";
                    int kq = sp.insertSanPham(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), float.Parse(txtDonGia.Text.Trim()), int.Parse(txtSoLuong.Text.Trim()), txtXuatXu.Text.Trim(), fileName,
                        cbbMaSX.SelectedValue.ToString().Trim(), int.Parse(txtThoiGian_BH.Text.Trim()), double.Parse(txtChieuDai.Text.Trim()), double.Parse(txtChieuRong.Text.Trim()),
                        double.Parse(txtDoDay.Text.Trim()), double.Parse(txtTrongLuong.Text.Trim()),
                        double.Parse(txtManHinh.Text.Trim()), txtRam.Text.Trim(), txtBoNhoTrong.Text.Trim(),
                        txtHeDieuHanh.Text.Trim(), txtMoTa.Text.Trim());
                    if (kq == 1)//Thêm sản phẩm mới thành công
                    {
                        img = ptbSanPham.Image;
                        img.Save(fileImageSP + fileName);
                        loaddtgvSP();
                        MessageBox.Show("Đã thêm sản phẩm thành công", "Thông báo");
                        txtMaSP.Text = sp.tuDongTaoMaSPKhongTrung();
                        reSet();

                    }//còn 0, -1, -2
                    else
                    {
                        if (kq == -2)//trùng mã sản phẩm, trùng nơi xuất xứ
                        {
                            MessageBox.Show("Đã tồn tại mã sản phẩm trong cửa hàng", "Thông báo");
                        }
                        else
                        {
                            if (kq == -1)//trùng mã nhưng khác chi tiết 
                            {
                                img = ptbSanPham.Image;
                                img.Save(fileImageSP + fileName);
                                loaddtgvSP();
                                MessageBox.Show("Đã thên chi tiết mới thành công", "Thông báo");
                                reSet();
                            }
                            else
                                if(kq==3)
                                {
                                    MessageBox.Show("Đã tồn tại "+txtTenSP.Text.Trim()+" trong cửa hàng", "Thông báo");
                                }
                                else
                                MessageBox.Show("Đã tồn tại sản phẩm " + txtTenSP.Text.Trim() + " xuất xứ ở " + txtXuatXu.Text.Trim() + " rồi", "Thông báo");//khác mã sản phẩm nhưng trùng chi tiết
                        }
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin sản phẩm", "Thông báo");
        }

        private void dtgvThemSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaSP.Text = dtgvThemSP.CurrentRow.Cells["clMaSP"].Value.ToString().Trim();
            cbbMaSX.ValueMember = "TENHANGSX";
                cbbMaSX.SelectedValue = dtgvThemSP.CurrentRow.Cells["clHangSX"].Value.ToString();
                string tenHA = sp.loadImageSP(txtMaSP.Text.Trim(), dtgvThemSP.CurrentRow.Cells["clXuatXu"].Value.ToString().Trim());
            ptbSanPham.Image.Dispose();
            ptbSanPham.Image = Image.FromFile(fileImageSP+tenHA);
            txtTenSP.Text = dtgvThemSP.CurrentRow.Cells["clTenSP"].Value.ToString().Trim();
            txtMoTa.Text = dtgvThemSP.CurrentRow.Cells["clMoTa"].Value.ToString().Trim();
            txtBoNhoTrong.Text = dtgvThemSP.CurrentRow.Cells["clBoNhoTrong"].Value.ToString().Trim();
            txtChieuDai.Text = dtgvThemSP.CurrentRow.Cells["clChieuDai"].Value.ToString().Trim();
            txtChieuRong.Text = dtgvThemSP.CurrentRow.Cells["clChieuRong"].Value.ToString().Trim();
            txtDoDay.Text = dtgvThemSP.CurrentRow.Cells["clDoDay"].Value.ToString().Trim();
            txtDonGia.Text = dtgvThemSP.CurrentRow.Cells["clDonGia"].Value.ToString().Trim();
            txtHeDieuHanh.Text = dtgvThemSP.CurrentRow.Cells["clHeDieuHanh"].Value.ToString().Trim();
            txtManHinh.Text = dtgvThemSP.CurrentRow.Cells["clManHinh"].Value.ToString().Trim();
            txtSoLuong.Text = dtgvThemSP.CurrentRow.Cells["clSoLuong"].Value.ToString().Trim();
            txtManHinh.Text = dtgvThemSP.CurrentRow.Cells["clManHinh"].Value.ToString().Trim();
            txtRam.Text = dtgvThemSP.CurrentRow.Cells["clRam"].Value.ToString().Trim();
            txtTrongLuong.Text = dtgvThemSP.CurrentRow.Cells["clTrongLuong"].Value.ToString().Trim();
            txtXuatXu.Text = dtgvThemSP.CurrentRow.Cells["clXuatXu"].Value.ToString().Trim();
            txtThoiGian_BH.Text = dtgvThemSP.CurrentRow.Cells["clThoiGian_BH"].Value.ToString();
            fileName = txtMaSP.Text.Trim() + ".jpg";
            cbbMaSX.ValueMember = "MAHANGSX";
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmSuaSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn thoát khỏi màn hình này chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar=='.')
            {
                e.Handled = true;
            }
        }




    }
}
