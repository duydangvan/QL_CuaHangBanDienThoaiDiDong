using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tk = new TaiKhoanDAL();

        public TaiKhoanBLL()
        { }

        public bool kiemTraDangNhap(string pTenDN, string pMatKhau)
        {
            return tk.kiemTraDangNhap(pTenDN,pMatKhau);
        }

        public void updateTK(string pTenDN, string pMatKhau)
        {
            tk.updateTK(pTenDN, pMatKhau);
        }

        public string TenNV_TaiKhoan(string pTenDN, string pMatKhau)
        {
            return tk.TenNV_TaiKhoan(pTenDN, pMatKhau);
        }

        public string loadMaNV_TaiKhoan(string pTenDN, string pMatKhau)
        {
            return tk.loadMaNV(pTenDN, pMatKhau);
        }

        public bool kiemTraTaiKhoanTonTai(string pMaNV)
        {
            return tk.kiemTraTaiKhoanTonTai(pMaNV);
        }

        public void insertTK(string pTenDN, string pMatKhau, string pMaNV)
        {
            TAIKHOAN t = new TAIKHOAN();
            t.TENDANGNHAP = pTenDN;
            t.MANV = pMaNV;
            t.MATKHAU = pMatKhau;
            tk.insertTK(t);
        }

        public bool kiemTraTrungTDN(string pTDN)
        {
            return tk.kiemTraTrungTDN(pTDN);
        }

        public string ChucVu(string pTDN, string pMatKhau)
        {
            return tk.ChucVu(pTDN, pMatKhau);
        }
    }
}
