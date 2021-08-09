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
using BLL;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        TaiKhoanBLL tk = new TaiKhoanBLL();

        public static string fileName;
        string ImageFileNV =Environment.CurrentDirectory+ @"\ImageNhanVien\";
        string ImageFileSP =Environment.CurrentDirectory+ @"\ImageSanPham\";
        static Image img;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
            cbbChucVu.DataSource = nv.loadChucVu();
            txtMaNV.Text = nv.layMaTuDongKhongTrung("NV");
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh";
            open.Filter = "Image file (*.JPG)|*.jpg| All file (*.*)|*.*";
            if(open.ShowDialog()==DialogResult.OK)
            {
                ptbAnhNV.Image.Dispose();
                ptbAnhNV.Image = Image.FromFile(open.FileName); 
                fileName = txtMaNV.Text+".jpg";
                
            }
            open.Dispose();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim();
            fileName = nv.loadHinhAnh(txtMaNV.Text.Trim()).ToString();
            txtHoTen.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString().Trim();
            txtNgaySinh.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dtgvNhanVien.CurrentRow.Cells[5].Value.ToString().Trim();
            txtEmail.Text = dtgvNhanVien.CurrentRow.Cells[6].Value.ToString().Trim();
            cbbChucVu.SelectedItem = dtgvNhanVien.CurrentRow.Cells[7].Value.ToString().Trim();
            txtCMND.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            ptbAnhNV.Image.Dispose();
            ptbAnhNV.Image = Image.FromFile(ImageFileNV + fileName);
            Image.FromFile(ImageFileNV + fileName).Dispose();
            if (!tk.kiemTraTaiKhoanTonTai(dtgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                DangKyTool.Visible = true;
            }
            else
                DangKyTool.Visible = false;
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            btnLuuNV.Visible = true;
        }

        void loadNV()
        {
            dtgvNhanVien.DataSource = nv.loadNV();
            dtgvNhanVien.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        bool kiemTraDinhDangEmail()
        {
            if(txtEmail.Text.Contains("@gmail.com"))
            {
                return true;
            }
            return false;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (!nv.kiemTraMaNVTrung(txtMaNV.Text.Trim()))
                {
                    if (kiemTraDuTuoi())
                    {
                        if (kiemDinhDangTraSDT())
                        {
                            if (kiemTraDinhDangEmail())
                            {
                                Image img = ptbAnhNV.Image;
                                if (img == null)
                                    return;
                                if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên " + txtHoTen.Text.Trim() + " vào hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    string ImageNV = txtMaNV.Text.Trim() + ".jpg";
                                    string finalFile = ImageFileNV + ImageNV;
                                    img.Save(finalFile);

                                    nv.themNhanVien(txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtCMND.Text.Trim(),
                                        txtNgaySinh.Value, txtSDT.Text.Trim(), txtEmail.Text.Trim(),
                                        cbbChucVu.SelectedItem.ToString(), ImageNV);
                                    loadNV();
                                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                                    reset();
                                }
                            }
                            else
                                MessageBox.Show("Email chưa đúng định dạng @gmail.com", "Thông báo");
                        }
                        else
                            MessageBox.Show("Số điện thoại từ 10 đến 12 số bạn nhé","Thông báo");
                    }
                    else
                        MessageBox.Show("Nhân viên chưa đủ 18 tuổi để đi làm","Thông báo");
                }
                else
                    MessageBox.Show("Mã nhân viên đã bị trùng. Vui lòng làm mới để được thêm nhân viên", "Thông báo");
            }
            else
                MessageBox.Show("Chưa điền đầy đủ thông tin nhân viên","Thông báo");
        }

        bool kiemTraRong()
        {
            if(txtHoTen.Text==string.Empty || txtCMND.Text==string.Empty || txtDiaChi.Text==string.Empty || 
                txtEmail.Text==string.Empty || txtSDT.Text ==string.Empty )
            {
                return true;
            }
            return false;
        }

        bool kiemTraDuTuoi()
        {
            int tuoi = DateTime.Now.Year - txtNgaySinh.Value.Year;
            if (DateTime.Now.DayOfYear < txtNgaySinh.Value.DayOfYear)
                tuoi -= 1;
            if(tuoi>=18)
                return true;
            return false;
        }

        bool kiemDinhDangTraSDT()
        {
            if (txtSDT.Text.Trim().Length > 9 && txtSDT.Text.Trim().Length < 12)
                return true;
            return false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }
        


        void reset()
        {
            if (cbbChucVu.SelectedIndex == 0)
            {
                txtMaNV.Text = nv.layMaTuDongKhongTrung("CH");
            }
            else
            {
                txtMaNV.Text = nv.layMaTuDongKhongTrung("NV");
            }
            txtHoTen.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            ptbAnhNV.Image = Image.FromFile(ImageFileNV + "default.jpg");
            cbbChucVu.SelectedIndex = 0;
            DangKyTool.Visible = false;
            
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            try
            {
            if (kiemTraDuTuoi())
            {
                if (kiemTraDinhDangEmail())
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhân viên " + txtHoTen.Text.Trim() + " vào hệ thống chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string fileDelete = ImageFileNV + fileName;
                        img = ptbAnhNV.Image;
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, ImageFormat.Jpeg);
                        Image newImage = Image.FromStream(ms);
                        ptbAnhNV.Image.Dispose();
                        File.Delete(fileDelete);
                        string fileSave = Path.Combine(ImageFileNV + fileName);

                        newImage.Save(fileSave);
                        nv.UpdateNV(txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(),
                            txtCMND.Text.Trim(), txtNgaySinh.Value, txtSDT.Text.Trim(), txtEmail.Text.Trim(),
                            cbbChucVu.SelectedItem.ToString(), fileName);
                        MessageBox.Show("Đã sửa thông tin thành công", "Thông báo");
                        loadNV();
                        reset();
                        btnLuuNV.Visible = false;
                    }
                }
                else
                    MessageBox.Show("Email chưa đúng định dạng @gmail.com", "Thông báo");
            }
            else
                MessageBox.Show("Nhân viên chưa đủ tuổi đi làm bạn nhé","Thông báo");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
            }
        }
        

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void DangKyTool_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.nhanDL(dtgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim());
            f.ShowDialog();
            if (!tk.kiemTraTaiKhoanTonTai(dtgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                DangKyTool.Visible = true;
            }
            else
                DangKyTool.Visible = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi màn hình này chứ","Thông báo", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}