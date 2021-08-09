using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sp = new SanPhamDAL();
        public SanPhamBLL()
        {

        }

        public IQueryable loadSanPham()
        {
            return sp.loadSanPham();
        }

        public IQueryable timKiemTenSP(string pTenSP)
        {
            return sp.timKiemTenSP(pTenSP);
        }

        public IQueryable timKiemXuatXu(string pXuatXu)
        {
            return sp.timKemXuatXu(pXuatXu);
        }


        public string tuDongTaoMaSPKhongTrung()
        {
            string maSP;
            Random rd = new Random();
            maSP = "SP0" + rd.Next(0, 500).ToString();
            while (sp.kiemTraMaSPTrung(maSP))
            {
                maSP = "SP0" + rd.Next(0, 500).ToString();
            }
            return maSP;
        }

        public IQueryable loadSP_ChiTiepSP()
        {
            return sp.LoadSP_ChiTietSP();
        }

        public IQueryable loadCbbHangSX()
        {
            return sp.loadTenHangSX();
        }


        public void UpdateSP(string pMaSP, string pTenSP, float pDonGia, int pSoLuong, string pXuatXu, string pHinh,
            string pMaHangSX, int pMaPhieu_BH, double pChieuDai, double pChieuRong, double pDoDay, double pTrongLuong, double pManHinh,
            string pRam, string pBoNhoTrong, string pHeDieuHanh, string pMoTa)
        {
            sp.Update_SP_ChiTietSP(pMaSP, pTenSP, pDonGia, pSoLuong, pXuatXu, pHinh, pMaHangSX, pMaPhieu_BH,
                pChieuDai, pChieuRong, pDoDay, pTrongLuong, pManHinh, pRam, pBoNhoTrong, pHeDieuHanh, pMoTa);
        }

        public string loadImageSP(string pMASP,string pXuatXu)
        {
            return sp.loadImageSP(pMASP,pXuatXu);
        }

        public int insertSanPham(string pMaSP, string pTenSP, float pDonGia, int pSoLuong, string pXuatXu, string pHinh,
            string pMaHangSX, int pThoiGian_BH, double pChieuDai, double pChieuRong, double pDoDay, double pTrongLuong, double pManHinh, string pRam,
            string pBoNhoTrong, string pHeDieuHanh, string pMoTa)
        {
            /* 
             * trùng mã , trùng tên , trùng xuất xứ// ko thêm được // ko thêm đc 
             * trùng mã , trùng tên, khác xuất xứ // thêm được // thêm đc 
             * trùng mã, khác tên, trùng xuất xứ // ko thêm được // không thêm đc 
             * trùng mã, khác tên, khác xuất xứ // thêm đc // ko thêm đc 
             * khác mã, khác tên, trùng xuất xứ // thêm đc  // thêm đc 
             * khác mã, trùng tên, trùng xuất xứ // thêm đc // ko thêm đc 
             * khác mã, khác tên, khác xuất xứ // thêm đc // thêm đc 
             * khác mã, trùng tên, khác xuất xứ // thêm đc // thêm đc
             */

            if (!sp.kiemTraMaSPTrung(pMaSP))
            {
                if (!sp.kiemTraTrungTenSP(pTenSP))
                {
                    if (!sp.kiemTraTrungTenSP_MaHangSX(pTenSP, pXuatXu))
                    {
                        SANPHAM s = new SANPHAM();
                        s.MASP = pMaSP;
                        s.TENSP = pTenSP;
                        sp.InsertSanPham(s);

                        CHITIET_SP ct = new CHITIET_SP();
                        ct.MASP = pMaSP;
                        ct.MAHANGSX = pMaHangSX;
                        ct.MANHINH = pManHinh;
                        ct.CHIEUDAI = pChieuDai;
                        ct.CHIEURONG = pChieuRong;
                        ct.thoiGian_BH = pThoiGian_BH;
                        ct.DODAY = pDoDay;
                        ct.HINH = pHinh;
                        ct.TRONGLUONG = pTrongLuong;
                        ct.RAM = pRam;
                        ct.BONHOTRONG = pBoNhoTrong;
                        ct.HEDIEUHANH = pHeDieuHanh;
                        ct.MOTA = pMoTa;
                        ct.DONGIA = pDonGia;
                        ct.SOLUONG = pSoLuong;
                        ct.XUATXU = pXuatXu;

                        sp.InsertChiTiet_SP(ct);
                        return 1;//Đã thêm sản phẩm mới thành công
                    }
                    else
                        return 0;//không trùng mã nhưng trùng tên và xuất xứ
                }
                else return 3;//trùng tên
            }
            else
            {
                if (!sp.kiemTraTrungChiTietSP_MaSP_XuatXu(pMaSP, pXuatXu))
                {
                    CHITIET_SP ct = new CHITIET_SP();
                    ct.MASP = pMaSP;
                    ct.MAHANGSX =  pMaHangSX;
                    ct.MANHINH = pManHinh;
                    ct.CHIEUDAI =pChieuDai;
                    ct.CHIEURONG = pChieuRong;
                    ct.DODAY = pDoDay;
                    ct.TRONGLUONG = pTrongLuong;
                    ct.RAM = pRam;
                    ct.HINH = pHinh;
                    ct.BONHOTRONG = pBoNhoTrong;
                    ct.HEDIEUHANH = pHeDieuHanh;
                    ct.MOTA = pMoTa;
                    ct.thoiGian_BH = pThoiGian_BH;
                    ct.SOLUONG = pSoLuong;
                    ct.DONGIA = pDonGia;
                    ct.XUATXU = pXuatXu;

                    sp.InsertChiTiet_SP(ct);
                    //trùng mã nhưng khác nơi xuất xứ
                    return -1;//thêm chi tiết mới của sản phẩm thành công
                }
                else
                    return -2;//trùng hết 
            }

        }

        public IQueryable loadChiTiepSPTheoMaSP(string pMaSP)
        {
            return sp.loadSPTheoMaSP(pMaSP);
        }

        public DataTable loadSanPhamLenMuaHang()
        {
            return sp.loadSPLenBanHang();
        }

        public IQueryable loadSP_TheoMaHangSX(string pMaHangSX)
        {
            return sp.loadSP_TheoMaHangSX(pMaHangSX);
        }

        public IQueryable loadSP_TheoTenHangSX(string pTenHangSX)
        {
            return sp.loadSP_TheoTenHangSX(pTenHangSX);
        }

        public bool kiemTraTrungTenSP_MaHangSX(string pTenSP, string pMaHangSX)
        {
            return sp.kiemTraTrungTenSP_MaHangSX(pTenSP, pMaHangSX);
        }

        public List<string> loadTenHangSX(string pMaSP)
        {
            return sp.loadTenHangSX(pMaSP);
        }
        public List<int?> loadThoiGian_BH(string pMaSP)
        {
            return sp.loadThoiGian_BH(pMaSP);
        }
        public List<string> loadXuatXu(string pMaSP)
        {
            return sp.loadXuatXu(pMaSP);
        }

        public void updateSoLuong_SP(string pMaSP, string pXuatXu, int soLuongMua)
        {
            sp.updateSoLuongSP(pMaSP,pXuatXu,soLuongMua);
        }

        public bool kiemTraTrungTenSP(string pTenSP)
        {
            return sp.kiemTraTrungTenSP(pTenSP);
        }
    }
}

