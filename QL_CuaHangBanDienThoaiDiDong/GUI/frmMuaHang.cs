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
    public partial class frmMuaHang : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        HoaDonBLL hd = new HoaDonBLL();
        public frmMuaHang()
        {
            InitializeComponent();
            nhanDL = new layDL(ganDL);
        }

        public delegate void layDL(string pMaNV, string pTenNV);
        public layDL nhanDL;
        void ganDL(string pMaNV,string pTenNV)
        {
            lbMaNV.Text=pMaNV;
            lbTenNV.Text=pTenNV;
        }

        DataTable table = new DataTable();
        DataTable tblHoaDon = new DataTable();

        DataTable tblSanPham()
        {
            table=  sp.loadSanPhamLenMuaHang();
            return table;
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = tblSanPham();
            lbMaHD.Text = hd.tuDongTaoMaHDKhongTrung();
            taoViewHoaDon();
            timer1.Start();
            lbNgayGio.Text = DateTime.Now.ToLongTimeString()+", "+DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnTaoHoaDonMoi_Click(object sender, EventArgs e)
        {
            btnThemDH.Visible = true;
            btnXoaDH.Visible = true;
            btnThanhToan.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (tblHoaDon.Rows.Count > 0)
            {
                frmThanhToan f = new frmThanhToan();
                f.nhanDL(tblHoaDon, lbMaHD.Text.Trim(), lbMaNV.Text.Trim(),txtTongTien.Text.Trim());
                f.ShowDialog();
                if(hd.kiemTraTrungHD(lbMaHD.Text.Trim()))
                {
                    lbMaHD.Text = hd.tuDongTaoMaHDKhongTrung();
                    dtgvSanPham.DataSource = tblSanPham();
                    tblHoaDon.Clear();
                    dtgvHoaDon.DataSource = tblHoaDon;
                }
            }
            else
                MessageBox.Show("Bạn chưa có sản phẩm nào cần thanh toán","Thông báo");
        }

        public void taoViewHoaDon()
        {
            tblHoaDon.Columns.Add("MaSP");
            tblHoaDon.Columns.Add("TenSP");
            tblHoaDon.Columns.Add("HangSX");
            tblHoaDon.Columns.Add("Ram");
            tblHoaDon.Columns.Add("BoNhoTrong");
            tblHoaDon.Columns.Add("SoLuong");
            tblHoaDon.Columns.Add("DonGia");
            tblHoaDon.Columns.Add("ThanhTien");
            tblHoaDon.Columns.Add("XuatXu");
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            if (txtsl.Text != string.Empty)
            {
                int soLuongMua = int.Parse(txtsl.Text.Trim());
                if (soLuongMua > 0)
                {
                    int SoLuong_HD = int.Parse(dtgvSanPham.CurrentRow.Cells["cl_SP_SoLuong"].Value.ToString().Trim());
                    if (SoLuong_HD > 0)
                    {
                        if (SoLuong_HD >= soLuongMua)
                        {
                            string MaSP_HD = dtgvSanPham.CurrentRow.Cells["cl_SP_MaSP"].Value.ToString().Trim();
                            string TenSP_HD = dtgvSanPham.CurrentRow.Cells["cl_SP_TenSP"].Value.ToString().Trim();
                            string HangSX_HD = dtgvSanPham.CurrentRow.Cells["cl_SP_TenHangSX"].Value.ToString().Trim();
                            string Ram_HD = dtgvSanPham.CurrentRow.Cells["cl_SP_Ram"].Value.ToString().Trim();
                            string BoNhoTrong_HD = dtgvSanPham.CurrentRow.Cells["cl_SP_BoNhoTrong"].Value.ToString().Trim();
                            int DonGia_HD = int.Parse(dtgvSanPham.CurrentRow.Cells["cl_SP_Gia"].Value.ToString().Trim());
                            string pXuatXu = dtgvSanPham.CurrentRow.Cells["cl_SP_XuatXu"].Value.ToString().Trim();
                            int tongTien = 0;
                            int tt = soLuongMua * DonGia_HD;

                            DataRow row = tblHoaDon.NewRow();
                            row[0] = MaSP_HD;
                            row[1] = TenSP_HD;
                            row[2] = HangSX_HD;
                            row[3] = Ram_HD;
                            row[4] = BoNhoTrong_HD;
                            row[5] = soLuongMua;
                            row[6] = DonGia_HD;
                            row[7] = tt;
                            row[8] = pXuatXu;

                            int soLuongConLai = SoLuong_HD - soLuongMua;
                            if (SoLuong_HD >= soLuongMua)
                            {
                                tblHoaDon.Rows.Add(row);
                                dtgvSanPham.CurrentRow.Cells["cl_SP_SoLuong"].Value = soLuongConLai;
                            }
                            else
                            {
                                MessageBox.Show("Số lượng hàng muốn mua đã vượt quá số lượng hàng trong kho", "Thông báo");
                            }

                            for (int i = 0; i < tblHoaDon.Rows.Count - 1; i++)
                            {
                                string masp1 = tblHoaDon.Rows[i][0].ToString();
                                string hangSX1 = tblHoaDon.Rows[i][2].ToString();
                                int soLuong1 = int.Parse(tblHoaDon.Rows[i][5].ToString());
                                string xuatXu1 = tblHoaDon.Rows[i][8].ToString();

                                for (int j = i + 1; j < tblHoaDon.Rows.Count; j++)
                                {
                                    string masp2 = tblHoaDon.Rows[j][0].ToString();
                                    string hangSX2 = tblHoaDon.Rows[j][2].ToString();
                                    int soLuong2 = int.Parse(tblHoaDon.Rows[j][5].ToString());
                                    string xuatXu2 = tblHoaDon.Rows[j][8].ToString();

                                    if (masp1 == masp2 && hangSX1 == hangSX2 && xuatXu1==xuatXu2)
                                    {
                                        soLuong1 += soLuong2;
                                        tblHoaDon.Rows[i][5] = soLuong1;
                                        tt = soLuong1 * DonGia_HD;
                                        tblHoaDon.Rows[i][7] = tt;
                                        tblHoaDon.Rows.RemoveAt(j);
                                    }
                                }
                            }

                            for (int i = 0; i < tblHoaDon.Rows.Count; i++)
                            {
                                tongTien += int.Parse(tblHoaDon.Rows[i][7].ToString());
                            }
                            txtTongTien.Text = String.Format("{0:#,##0.##}", tongTien);
                            tblHoaDon.AcceptChanges();
                            dtgvHoaDon.DataSource = tblHoaDon;
                        }

                        else
                            MessageBox.Show("Số lượng hàng hóa còn lại trong cửa hàng hiện tại nhỏ hơn số lương mà khách hàng muốn mua", "Thông báo");
                    }
                    else
                        MessageBox.Show("Hiện tại đã hết hàng trong kho","Thông báo");
                }
                else
                    MessageBox.Show("Số lượng phải lớn hơn 0 bạn nhé", "Thông báo");
            }
            else
                MessageBox.Show("Số lượng không được để trống","Thông báo");
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.Rows.Count > 0)
            {
                if (txtsl.Text != string.Empty)
                {
                    if (int.Parse(txtsl.Text.Trim()) > 0)
                    {
                        int soLuong_HD = int.Parse(dtgvHoaDon.CurrentRow.Cells["cl_HD_SoLuong"].Value.ToString());
                        string xuatxuHuy = dtgvHoaDon.CurrentRow.Cells["cl_HD_XuatXu"].Value.ToString();
                        int soLuongHuy = int.Parse(txtsl.Text.Trim());
                        if (soLuong_HD >= soLuongHuy)
                        {
                            string ten_SP = dtgvHoaDon.CurrentRow.Cells["cl_HD_TenSP"].Value.ToString();
                            if (MessageBox.Show("Bạn có chắc chắn không mua " + soLuongHuy + " điện thoại " + ten_SP + " nữa chứ","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string MaSP_HD = dtgvHoaDon.CurrentRow.Cells["cl_HD_MaSP"].Value.ToString();
                                string hangSX_HD = dtgvHoaDon.CurrentRow.Cells["cl_HD_TenHangSX"].Value.ToString();

                                int vt = dtgvHoaDon.CurrentRow.Index;
                                int tongTien = 0;
                                int donGia = int.Parse(dtgvHoaDon.CurrentRow.Cells[6].Value.ToString());
                                int ttt = soLuong_HD * donGia;

                                for (int i = 0; i < dtgvSanPham.Rows.Count; i++)
                                {
                                    string maSP_SP = dtgvSanPham.Rows[i].Cells["cl_SP_MaSP"].Value.ToString().Trim();
                                    string hangSX_SP = dtgvSanPham.Rows[i].Cells["cl_SP_TenHangSX"].Value.ToString().Trim();
                                    int soLuong_SP = int.Parse(dtgvSanPham.Rows[i].Cells["cl_SP_SoLuong"].Value.ToString());
                                    string xuatxuSP = dtgvSanPham.Rows[i].Cells["cl_SP_XuatXu"].Value.ToString();

                                    if (maSP_SP == MaSP_HD && hangSX_HD == hangSX_SP && xuatxuHuy==xuatxuSP)
                                    {
                                        soLuong_SP += soLuongHuy;
                                        dtgvSanPham.Rows[i].Cells["cl_SP_SoLuong"].Value = soLuong_SP;
                                        soLuong_HD -= soLuongHuy;
                                        dtgvHoaDon.CurrentRow.Cells["cl_HD_SoLuong"].Value = soLuong_HD;
                                        ttt = soLuong_HD * donGia;
                                        dtgvHoaDon.CurrentRow.Cells["cl_HD_ThanhTien"].Value = ttt;
                                        if (soLuong_HD <= 0)
                                        {
                                            dtgvHoaDon.Rows.RemoveAt(vt);
                                        }
                                    }
                                }

                                tblHoaDon.AcceptChanges();
                                dtgvHoaDon.DataSource = tblHoaDon;

                                for (int i = 0; i < dtgvHoaDon.Rows.Count; i++)
                                    tongTien += int.Parse(dtgvHoaDon.Rows[i].Cells[7].Value.ToString());
                                txtTongTien.Text = String.Format("{0:#,##0.##}", tongTien);
                            }
                        }
                        else
                            MessageBox.Show("Số lượng trong bảng đơn hàng hiện tại nhỏ hơn số lượng muốn thu hồi", "Thông báo");
                    }
                    else
                        MessageBox.Show("Số lượng hủy hiện tại đang là 0", "Thông báo");
                }
                else
                    MessageBox.Show("Số lượng hiện tại không được để trống","Thông báo");
            }
            else
                MessageBox.Show("Chưa có sản phẩm nào bên hóa đơn", "Thông báo");
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNgayGio.Text = DateTime.Now.ToLongTimeString() +", "+ DateTime.Now.ToString("dd/MM/yyyy");
        }

        
    }
}
