using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();
        public HoaDonDAL()
        { }

        public bool kiemTraTrungMaHD(string pMaHD)
        {
            int kq = qlCH.HOADONs.Where(hd => hd.MAHD == pMaHD).Count();
            if (kq >= 1)
                return true;
            return false;
        }


        public IQueryable loadHoaDon()
        {
            var hoaDon = from h in qlCH.HOADONs
                         from n in qlCH.NHANVIENs
                         from k in qlCH.KHACHHANGs
                         where h.MAKH == k.MAKH
                         where h.MANV == n.MANV
                         select new
                         {
                             h.MAHD, n.HOTEN,k.TENKH,h.NGAYLAPHD, h.TONGTIEN
                         };
            return hoaDon;
        }

        public IQueryable loadHDLenKH()
        {
            var hoaDon = from hd in qlCH.HOADONs
                         from k in qlCH.KHACHHANGs
                         where hd.MAKH == k.MAKH
                         select new
                         {
                             hd.MAHD,
                             hd.TONGTIEN,
                             hd.NGAYLAPHD
                         };
            return hoaDon;
        }

        public IQueryable loadChiTietHD_TheoMaHD(string pMaHD)
        {
            var ct = from c in qlCH.CHITIET_HDs
                     from s in qlCH.SANPHAMs
                     where c.MASP == s.MASP
                     where c.MAHD == pMaHD
                     select new
                     {
                         s.MASP, s.TENSP, c.SOLUONG, c.DONGIA, c.TONGTIEN, c.XUATXU
                     };
            return ct;
        }

        public IQueryable loadHD_TheoMaHD(string pMHD)
        {
            var hoaDon1 = from h in qlCH.HOADONs
                         from n in qlCH.NHANVIENs
                         from k in qlCH.KHACHHANGs
                         where h.MAKH == k.MAKH
                         where h.MANV == n.MANV
                         where h.MAHD.Contains(pMHD)
                         select new
                         {
                             h.MAHD,
                             n.HOTEN,
                             k.TENKH,
                             h.NGAYLAPHD,
                             h.TONGTIEN
                         };
            return hoaDon1;
        }

        public IQueryable loadHD_TheoTenNV(string pTenNV)
        {
            var hoaDon = from h in qlCH.HOADONs
                         from n in qlCH.NHANVIENs
                         from k in qlCH.KHACHHANGs
                         where h.MAKH == k.MAKH
                         where h.MANV == n.MANV
                         where n.HOTEN.Contains(pTenNV)
                         select new
                         {
                             h.MAHD,
                             n.HOTEN,
                             k.TENKH,
                             h.NGAYLAPHD,
                             h.TONGTIEN
                         };
            return hoaDon;
        }

        public void insertHD(HOADON hd)
        {
            qlCH.HOADONs.InsertOnSubmit(hd);
            qlCH.SubmitChanges();
        }

        public void insert_CTHD(CHITIET_HD ct)
        {
            qlCH.CHITIET_HDs.InsertOnSubmit(ct);
            qlCH.SubmitChanges();
        }


    }
}
