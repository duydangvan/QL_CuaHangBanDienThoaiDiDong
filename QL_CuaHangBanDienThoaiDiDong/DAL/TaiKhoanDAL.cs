using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();

        public TaiKhoanDAL()
        {

        }

        public bool kiemTraDangNhap(string pTenDN, string pMatKhau)
        {
            int kq = qlCH.TAIKHOANs.Where(t=>t.TENDANGNHAP==pTenDN).Where(t=>t.MATKHAU==pMatKhau).Count();
            if(kq>=1)
                return true;
            return false;
        }

        public void updateTK(string pTenDN, string pMatKhau)
        {
            TAIKHOAN taiKhoa = qlCH.TAIKHOANs.Where(t => t.TENDANGNHAP == pTenDN).FirstOrDefault();
            taiKhoa.MATKHAU = pMatKhau;
            qlCH.SubmitChanges();
        }

        public string TenNV_TaiKhoan(string pTenDN, string pMatKhau)
        {
            NHANVIEN nhanVien = (from n in qlCH.NHANVIENs
                                from t in qlCH.TAIKHOANs
                                where n.MANV == t.MANV
                                where t.TENDANGNHAP == pTenDN
                                where t.MATKHAU == pMatKhau
                                select n).FirstOrDefault();
                                
            return nhanVien.HOTEN.ToString();
        }

        public string loadMaNV(string pTenDN, string pMatKhau)
        {
            NHANVIEN nhanVien = (from n in qlCH.NHANVIENs
                                 from t in qlCH.TAIKHOANs
                                 where n.MANV == t.MANV
                                 where t.TENDANGNHAP == pTenDN
                                 where t.MATKHAU == pMatKhau
                                 select n).FirstOrDefault();

            return nhanVien.MANV.ToString();
        }

        public bool kiemTraTaiKhoanTonTai(string pMaNV)
        {
            int kq = qlCH.TAIKHOANs.Where(n => n.MANV == pMaNV).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public void insertTK(TAIKHOAN tk)
        {
            qlCH.TAIKHOANs.InsertOnSubmit(tk);
            qlCH.SubmitChanges();
        }

        public bool kiemTraTrungTDN(string pTenDN)
        {
            int kq = qlCH.TAIKHOANs.Where(s=>s.TENDANGNHAP==pTenDN).Count();
            if (kq >= 1)
                return true;
            return false;
        }
        public string ChucVu(string pTDN, string pMatKhau)
        {
            NHANVIEN t = (from n in qlCH.NHANVIENs
                         from tk in qlCH.TAIKHOANs
                         where n.MANV == tk.MANV
                         where tk.TENDANGNHAP == pTDN
                         where tk.MATKHAU == pMatKhau
                             select n).FirstOrDefault();
            string chucvu = t.CHUCVU;
            return chucvu;
        }
    }
}
