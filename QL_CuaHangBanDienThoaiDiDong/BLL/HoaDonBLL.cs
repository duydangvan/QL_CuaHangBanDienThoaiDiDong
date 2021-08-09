using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
        public HoaDonBLL()
        {

        }

        public string tuDongTaoMaHDKhongTrung()
        {
            
            Random rd = new Random();
            string maHD = "HD0"+rd.Next(0,500);
            while (hd.kiemTraTrungMaHD(maHD))
            {
                maHD = "HD0" + rd.Next(0, 500);
            }
            return maHD;
        }

        public IQueryable loadHDLenKH()
        {
            return hd.loadHDLenKH();
        }

        public IQueryable loadHDLenHD()
        {
            return hd.loadHoaDon();
        }

        public IQueryable loadChiTietHD_TheoMaHD(string pMaHD)
        {
            return hd.loadChiTietHD_TheoMaHD(pMaHD);
        }
        public IQueryable loadHD_TheoMaHD(string pMaHD)
        {
            return hd.loadHD_TheoMaHD(pMaHD);
        }

        public IQueryable loadHD_TheoTenNV(string pTenNV)
        {
            return hd.loadHD_TheoTenNV(pTenNV);
        }

        public void insert_HD(string pMaHD, string pMaNV, string pMaKH, DateTime pNgayLap, int pTongTien)
        {
            HOADON h = new HOADON();
            h.MAHD = pMaHD;
            h.MANV = pMaNV;
            h.MAKH = pMaKH;
            h.NGAYLAPHD = pNgayLap;
            h.TONGTIEN = pTongTien;
            hd.insertHD(h);
        }

        public void  insert_CTHD(string pMaHD,string pMaSP, int pSoLuong, int pDonGia, int pTongTien,string pXuatXu)
        {
            CHITIET_HD c = new CHITIET_HD();
            c.MAHD = pMaHD;
            c.MASP = pMaSP;
            c.SOLUONG = pSoLuong;
            c.DONGIA = pDonGia;
            c.TONGTIEN = pTongTien;
            c.XUATXU = pXuatXu;
            hd.insert_CTHD(c);
        }
            public bool kiemTraTrungHD(string pMaHD)
        {
            return hd.kiemTraTrungMaHD(pMaHD);
        }
    }
}
