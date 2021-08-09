using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();
        public KhachHangDAL ()
        {

        }

        public IQueryable loadKH()
        {
            var khachHang = qlCH.KHACHHANGs.Select(s => new { s.MAKH, s.TENKH, s.SDT, s.NAMSINH,s.EMAIL, s.DIACHI});
            return khachHang;
        }

        public bool kiemTraTrungMaKH(string pMaKH)
        {
            int kq = qlCH.KHACHHANGs.Where(k=>k.MAKH==pMaKH).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public void insertKH(KHACHHANG k)
        {
            qlCH.KHACHHANGs.InsertOnSubmit(k);
            qlCH.SubmitChanges();
        }

        public void KH_Can_Update(string pMaKH, string pTenKH, string pDiaChi, string pSDT, int pNamSinh, string pEmail)
        {
            KHACHHANG k = qlCH.KHACHHANGs.Where(kh => kh.MAKH == pMaKH).FirstOrDefault();
            k.TENKH = pTenKH;
            k.DIACHI = pDiaChi;
            k.SDT = pSDT;
            k.NAMSINH = pNamSinh;
            k.EMAIL = pEmail;
            qlCH.SubmitChanges();
        }

        public IQueryable timKiemMaKH(string pMaKH)
        {
            var hoaDon = from hd in qlCH.HOADONs
                         from k in qlCH.KHACHHANGs
                         where hd.MAKH == k.MAKH
                         where hd.MAKH.Contains(pMaKH)
                         select new
                         {
                             hd.MAHD,
                             hd.TONGTIEN,
                             hd.NGAYLAPHD
                         };
            return hoaDon;
        }

        public IQueryable timKiemTenKH(string pTenKH)
        {
            var hoaDon = from hd in qlCH.HOADONs
                         from k in qlCH.KHACHHANGs
                         where hd.MAKH == k.MAKH
                         where k.TENKH.Contains(pTenKH)
                         select new
                         {
                             hd.MAHD,
                             hd.TONGTIEN,
                             hd.NGAYLAPHD
                         };
            return hoaDon;
        }

        public IQueryable loadKH_LenThanhToan()
        {
            var k = qlCH.KHACHHANGs.Select(kh=>new { kh.MAKH, kh.TENKH});
            return k;
        }

    }
}
