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
    public partial class frmThanhToan : Form
    {

        KhachHangBLL kh = new KhachHangBLL();
        HoaDonBLL hd = new HoaDonBLL();
        SanPhamBLL sp = new SanPhamBLL();

        public frmThanhToan()
        {
            InitializeComponent();
            ganDL = new laydl(nhanDL);
        }

        DataTable tblHoaDon = new DataTable();
        List<string> dsMaSP = new List<string>();

        public delegate void laydl(DataTable hoaDon, string maHD,string pMaNV,string pTongTien);
        public laydl ganDL;

        public void nhanDL(DataTable hoaDon, string maHD, string pMaNV, string pTongTien)
        {
            tblHoaDon = hoaDon;
            lbMaHD.Text = maHD;
            lbMaNV.Text = pMaNV;
            txtTongTien.Text = pTongTien;
        }

        void hienDSSP()
        {
            List<string> dsTenSP = new List<string>();
            List<int> dsSoLuong = new List<int>();
            lbTenSP.Text = string.Empty;
            lbSoLuong.Text = string.Empty;

            for (int i = 0; i < tblHoaDon.Rows.Count;i++)
            {
                dsTenSP.Add(tblHoaDon.Rows[i][1].ToString());
                dsSoLuong.Add(int.Parse(tblHoaDon.Rows[i][5].ToString()));
                dsMaSP.Add(tblHoaDon.Rows[i][0].ToString());
            }

            foreach(string item in dsTenSP)
            {
                lbTenSP.Text += item + "\n";
            }

            foreach(int item in dsSoLuong)
            {
                lbSoLuong.Text += item + "\n";
            }
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            loadcbbKH();
            hienDSSP();
            lbMaKH.Text = string.Empty;
        }

        void loadcbbKH()
        {
            cbbKhachHang.DataSource = kh.loadKH_LenThanhToan();
            cbbKhachHang.DisplayMember = "TENKH";
            cbbKhachHang.ValueMember = "MAKH";
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMaKH.Text = cbbKhachHang.SelectedValue.ToString().Trim();
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text != string.Empty)
            {
                string pTien = txtTienKhachTra.Text.Trim();
                if (pTien.Contains(","))
                {
                    pTien = pTien.Replace(",", "");
                }

                int tongTien = int.Parse(txtTongTien.Text.Trim().Replace(",", ""));
                Int64 tienTra = Int64.Parse(pTien);
                txtTienTraLai.Text = string.Format("{0:#,##0.##}",(tienTra - tongTien));
                txtTienKhachTra.Text = string.Format("{0:#,##0.##}", Int64.Parse(pTien));
                txtTienKhachTra.SelectionStart = txtTienKhachTra.Text.Length;
            }
        }


        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (lbMaKH.Text != string.Empty)
            {
                if (txtTienKhachTra.Text != string.Empty)
                {
                    int tienTraLai;
                    if (txtTienTraLai.Text.Contains(","))
                    {
                        tienTraLai = int.Parse(txtTienTraLai.Text.Trim().Replace(",", ""));
                    }
                    else
                    {
                        tienTraLai = int.Parse(txtTienTraLai.Text.Trim());
                    }
                    if (tienTraLai >= 0)
                    {
                        hd.insert_HD(lbMaHD.Text.Trim(), lbMaNV.Text.Trim(), lbMaKH.Text.Trim(), DateTime.Now, int.Parse(txtTongTien.Text.Trim().Replace(",", "")));

                        for (int i = 0; i < tblHoaDon.Rows.Count; i++)
                        {
                            string pMaSP = tblHoaDon.Rows[i][0].ToString();
                            int pSoLuong = int.Parse(tblHoaDon.Rows[i][5].ToString());
                            int pDonGia = int.Parse(tblHoaDon.Rows[i][6].ToString());
                            int pTongTien = int.Parse(tblHoaDon.Rows[i][7].ToString());
                            string pXuatXu = tblHoaDon.Rows[i][8].ToString();
                            hd.insert_CTHD(lbMaHD.Text.Trim(), pMaSP.Trim(), pSoLuong, pDonGia, pTongTien, pXuatXu);
                            sp.updateSoLuong_SP(pMaSP.Trim(), pXuatXu.Trim(), pSoLuong);
                            btnXuatHD.Enabled = false;
                            txtTienKhachTra.Enabled = false;
                            cbbKhachHang.Enabled = false;
                            txtTienTraLai.Enabled = false;
                        }
                        MessageBox.Show("Đã thanh toán thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Khách hàng chưa trả đủ tiền thanh toán", "Thông báo");
                }
                else
                    MessageBox.Show("Bạn chưa nhập tiền để thanh toán","Thông báo");
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng nào để thanh toán", "Thông báo");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
