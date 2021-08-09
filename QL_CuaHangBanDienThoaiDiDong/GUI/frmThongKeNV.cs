using BLL;
using BLL.giayKhenNV;
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
    public partial class frmThongKeNV : Form
    {

        NhanVienBLL nv = new NhanVienBLL();
        public frmThongKeNV()
        {
            InitializeComponent();
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text != "Null")
            {
                if (txtLyDo.Text != string.Empty && txtTienThuong.Text != string.Empty)
                {
                    WordExport w = new WordExport();
                    string ngay = DateTime.Now.Day.ToString();
                    string thang = DateTime.Now.Month.ToString();
                    string nam = DateTime.Now.Year.ToString();
                    string pTenNV = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                    Random rd = new Random();
                    string soQD = "" + rd.Next(0, 500);
                    w.QuyetDinhKhenThuong(ngay, thang, nam, pTenNV, soQD, lbMaNV.Text, txtLyDo.Text.Trim(), DateTime.Now.ToString("dd/MM/yyyy"), txtTienThuong.Text.Trim());
                }
                else
                    MessageBox.Show("Bạn chưa điền lý do khen thưởng và số tiền khen thưởng","Thông báo");
            }
            else
                MessageBox.Show("Bạn chưa thống kê doanh thu để khen thưởng", "Thông báo");
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = nv.loadNVLenThongKe();
            dtgvNhanVien.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau=dPFrom.Value;
                DateTime ngayKetThuc=dPTo.Value;
            dtgvNhanVien.DataSource = nv.loadNVTheoNgaylapHD(ngayBatDau,ngayKetThuc);
            DataTable dsNV = new DataTable();
            dsNV = nv.dsNVTrongThongKe(ngayBatDau, ngayKetThuc);
            if (dsNV.Rows.Count > 0)
            {
                List<int> dsKQ = new List<int>();
                Int64 tt = 0;
                for (int i = 0; i < dtgvNhanVien.Rows.Count; i++)
                {
                    tt += Int64.Parse(dtgvNhanVien.Rows[i].Cells[7].Value.ToString());
                }

                lbTongTien.Text = string.Format("{0:#,##0.##}", tt);
                if (rdb_TK_Theo_SLHD.Checked)
                {
                    for (int a = 0; a < dsNV.Rows.Count; a++)
                    {
                        int dem = 0;
                        for (int i = 0; i < dtgvNhanVien.Rows.Count; i++)
                        {
                            string pMaNV = dtgvNhanVien.Rows[i].Cells[0].Value.ToString().Trim();
                            if (dsNV.Rows[a][0].ToString().Trim() == pMaNV)
                            {
                                dem++;
                            }
                        }
                        dsKQ.Add(dem);
                    }

                    int max = dsKQ[0];
                    for (int i = 0; i < dsKQ.Count; i++)
                    {
                        if (dsKQ[i] >= max)
                        {
                            max = dsKQ[i];
                            lbMaNV.Text = dsNV.Rows[i][0].ToString().Trim();
                            lbTenNV.Text = dsNV.Rows[i][1].ToString().Trim();
                            lbDiaChi.Text = dsNV.Rows[i][2].ToString().Trim();
                        }
                    }
                }
                else
                {
                    List<Int64> dsTongTien = new List<Int64>();

                    for (int i = 0; i < dsNV.Rows.Count; i++)
                    {
                        Int64 tongTien = 0;
                        for (int a = 0; a < dtgvNhanVien.Rows.Count; a++)
                        {
                            if (dsNV.Rows[i][0].ToString().Trim() == dtgvNhanVien.Rows[a].Cells[0].Value.ToString().Trim())
                            {
                                tongTien += Int64.Parse(dtgvNhanVien.Rows[a].Cells[7].Value.ToString());
                            }
                        }
                        dsTongTien.Add(tongTien);
                    }
                    Int64 max = dsTongTien[0];
                    for (int i = 0; i < dsTongTien.Count; i++)
                    {
                        if (dsTongTien[i] >= max)
                        {
                            max = dsTongTien[i];
                            lbMaNV.Text = dsNV.Rows[i][0].ToString().Trim();
                            lbTenNV.Text = dsNV.Rows[i][1].ToString().Trim();
                            lbDiaChi.Text = dsNV.Rows[i][2].ToString().Trim();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Không có nhân viên nào bán được hóa đơn trong những ngày đó","Thông báo");
        }

        private void txtTienThuong_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThuong.Text != string.Empty)
            {
                string pTien = txtTienThuong.Text.Trim();
                if (pTien.Contains(","))
                {
                    pTien = pTien.Replace(",", "");
                }
                txtTienThuong.Text = string.Format("{0:#,##0.##}", int.Parse(pTien));
                txtTienThuong.SelectionStart = txtTienThuong.Text.Length;
            }
        }

        private void rdb_TK_Theo_SLHD_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_TK_Theo_SLHD.Checked)
            {
                rdbTK_Theo_TongTien.Checked = false;
            }
        }

        private void rdbTK_Theo_TongTien_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTK_Theo_TongTien.Checked)
            {
                rdb_TK_Theo_SLHD.Checked = false;
            }
        }
    }
}
