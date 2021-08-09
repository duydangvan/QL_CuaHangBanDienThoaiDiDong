using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();
        public SanPhamDAL()
        {

        }


        public IQueryable loadSanPham()
        {
            var sanPham = qlCH.SANPHAMs.Select(sp => new { sp.MASP, sp.TENSP});
            return sanPham;
        }

        public IQueryable timKemXuatXu(string pXuatXu)
        {
            var sourceTenSP = from s in qlCH.SANPHAMs
                              from c in qlCH.CHITIET_SPs
                              where s.MASP == c.MASP
                              where c.XUATXU.Contains(pXuatXu)
                              select new
                              {
                                  s.MASP,
                                  s.TENSP
                              };
            return sourceTenSP;


        }

        public IQueryable timKiemTenSP(string tenSP)
        {
            var sourceTenSP = qlCH.SANPHAMs.Where(sp => sp.TENSP.Contains(tenSP)).Select(sp => new { sp.MASP, sp.TENSP});
            return sourceTenSP;
        }


        public bool kiemTraMaSPTrung(string pMaSP)
        {
            int kq = qlCH.SANPHAMs.Where(sp => sp.MASP == pMaSP).Select(sp => sp.MASP).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public IQueryable LoadSP_ChiTietSP()
        {
            var sanPham = from sp in qlCH.SANPHAMs
                          from ct in qlCH.CHITIET_SPs
                          from h in qlCH.HANGSXes
                          where sp.MASP == ct.MASP
                          where h.MAHANGSX == ct.MAHANGSX
                          select new
                          {
                              sp.MASP,
                              sp.TENSP,
                              ct.thoiGian_BH,
                              h.TENHANGSX,
                              ct.CHIEUDAI,
                              ct.CHIEURONG,
                              ct.DODAY,
                              ct.TRONGLUONG,
                              ct.MANHINH,
                              ct.BONHOTRONG,
                              ct.RAM,
                              ct.HEDIEUHANH,
                              ct.MOTA,
                              ct.DONGIA,
                              ct.SOLUONG,
                              ct.XUATXU
                          };
            return sanPham.Distinct();
        }

        public IQueryable loadTenHangSX()
        {
            var hangSX = qlCH.HANGSXes;
            return hangSX;
        }

        public void InsertSanPham(SANPHAM pSanPham)
        {
            qlCH.SANPHAMs.InsertOnSubmit(pSanPham);
            qlCH.SubmitChanges();
        }

        public void InsertChiTiet_SP(CHITIET_SP ct)
        {
            qlCH.CHITIET_SPs.InsertOnSubmit(ct);
            qlCH.SubmitChanges();
        }

        public string loadImageSP(string pMaSP, string pXuatXu)
        {
            var ct = (from c in qlCH.CHITIET_SPs
                      from h in qlCH.HANGSXes
                      where c.MAHANGSX == h.MAHANGSX
                      where c.MASP == pMaSP
                      where c.XUATXU==pXuatXu
                      select c).FirstOrDefault();

            string hinhAnh = ct.HINH;
            return hinhAnh;
        }

        public bool kiemTraTrungChiTietSP_MaSP_XuatXu(string pMaSP, string pXuatXu)
        {
            int kq = qlCH.CHITIET_SPs.Where(s => s.MASP == pMaSP).
                Where(s => s.XUATXU == pXuatXu).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public void Update_SP_ChiTietSP(string pMaSP, string pTenSP, float pDonGia, int pSoLuong, string pXuatXu, string pHinh,
            string pMaHangSX, int pMaPhieu_BH, double pChieuDai, double pChieuRong, double pDoDay, double pTrongLuong, double pManHinh, string pRam,
            string pBoNhoTrong, string pHeDieuHanh, string pMoTa)
        {
            var chiTiet_SP = (from c in qlCH.CHITIET_SPs
                              where c.XUATXU==pXuatXu
                              where c.MASP == pMaSP
                              select c).FirstOrDefault();
            var sp = qlCH.SANPHAMs.Where(s => s.MASP == pMaSP).FirstOrDefault();


            SANPHAM sanPham = sp;
            sanPham.TENSP = pTenSP;

            CHITIET_SP ct = chiTiet_SP;
            ct.MAHANGSX = pMaHangSX;
            ct.HINH = pHinh;
            ct.CHIEUDAI = pChieuDai;
            ct.CHIEURONG = pChieuRong;
            ct.DODAY = pDoDay;
            ct.TRONGLUONG = pTrongLuong;
            ct.MANHINH = pManHinh;
            ct.RAM = pRam;
            ct.BONHOTRONG = pBoNhoTrong;
            ct.HEDIEUHANH = pHeDieuHanh;
            ct.MOTA = pMoTa;
            ct.DONGIA = pDonGia;
            ct.thoiGian_BH = pMaPhieu_BH;
            ct.SOLUONG = pSoLuong;
            qlCH.SubmitChanges();
        }

        public IQueryable loadSPTheoMaSP(string pMaSP)
        {
            var sanPham = from sp in qlCH.SANPHAMs
                          from ct in qlCH.CHITIET_SPs
                          from HSX in qlCH.HANGSXes
                          where sp.MASP == ct.MASP
                          where ct.MASP == pMaSP
                          where ct.MAHANGSX == HSX.MAHANGSX
                          select new
                          {
                              sp.MASP,
                              sp.TENSP,
                              ct.SOLUONG,
                              ct.thoiGian_BH,
                              ct.CHIEUDAI,
                              ct.CHIEURONG,
                              ct.DODAY,
                              ct.TRONGLUONG,
                              ct.MANHINH,
                              ct.BONHOTRONG,
                              ct.RAM,
                              ct.HEDIEUHANH,
                              ct.MOTA,
                              ct.DONGIA,
                              ct.XUATXU,
                              HSX.TENHANGSX
                          };
            return sanPham;
        }

        public DataTable loadSPLenBanHang()
        {
            var sanPham = from s in qlCH.SANPHAMs
                          from c in qlCH.CHITIET_SPs
                          from h in qlCH.HANGSXes
                          where s.MASP == c.MASP
                          where c.MAHANGSX == h.MAHANGSX
                          select new
                          {
                              s.MASP,
                              s.TENSP,
                              h.TENHANGSX,
                              c.BONHOTRONG,
                              c.RAM,
                              c.DONGIA,
                              c.SOLUONG,
                              c.XUATXU
                          };

            return LINQToDataTable(sanPham);
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        public IQueryable loadSP_TheoMaHangSX(string pMaHangSX)
        {
            var sanPham = from s in qlCH.SANPHAMs
                          from c in qlCH.CHITIET_SPs
                          from h in qlCH.HANGSXes
                          where s.MASP == c.MASP
                          where c.MAHANGSX == h.MAHANGSX
                          where h.MAHANGSX.Contains(pMaHangSX)
                          select new
                          {
                              s.MASP,
                              s.TENSP,
                              c.DONGIA
                          };
            return sanPham;
        }

        public IQueryable loadSP_TheoTenHangSX(string pTenHangSX)
        {
            var sanPham = from s in qlCH.SANPHAMs
                          from c in qlCH.CHITIET_SPs
                          from h in qlCH.HANGSXes
                          where s.MASP == c.MASP
                          where c.MAHANGSX == h.MAHANGSX
                          where h.TENHANGSX.Contains(pTenHangSX)
                          select new
                          {
                              s.MASP,
                              s.TENSP,
                              c.DONGIA
                          };
            return sanPham;
        }


        public bool kiemTraTrungTenSP_MaHangSX(string pTenSP, string pXuatXu)
        {
            var k = (from s in qlCH.SANPHAMs
                    from c in qlCH.CHITIET_SPs
                    where s.MASP==c.MASP
                    where c.XUATXU==pXuatXu
                    where s.TENSP==pTenSP
                         select s);
            int kq = k.Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public bool kiemTraTrungTenSP(string pTenSP)
        {
            var k = (from s in qlCH.SANPHAMs
                     where s.TENSP == pTenSP
                     select s);
            int kq = k.Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public IQueryable loadChiTiet_SP(string pMaSP)
        {
            var s = from sp in qlCH.SANPHAMs
                    from c in qlCH.CHITIET_SPs
                    where sp.MASP == c.MASP
                    where sp.MASP == pMaSP
                    select new
                    {
                        sp.TENSP
                    };
            return s;
        }

        public List<string> loadTenHangSX(string pMaSP)
        {
            var l = from s in qlCH.SANPHAMs
                    from c in qlCH.CHITIET_SPs
                    from h in qlCH.HANGSXes
                    where s.MASP == c.MASP
                    where c.MASP == pMaSP
                    where h.MAHANGSX == c.MAHANGSX
                    select h.TENHANGSX;
            return l.Distinct().ToList();
        }

        public List<int?> loadThoiGian_BH(string pMaSP)
        {
            var l = from s in qlCH.SANPHAMs
                    from c in qlCH.CHITIET_SPs
                    where s.MASP == c.MASP
                    where c.MASP == pMaSP
                    select c.thoiGian_BH;
            return l.Distinct().ToList();
        }

        public List<string> loadXuatXu(string pMaSP)
        {
            var l = from s in qlCH.SANPHAMs
                    from c in qlCH.CHITIET_SPs
                    where s.MASP == c.MASP
                    where c.MASP == pMaSP
                    select c.XUATXU;
            return l.Distinct().ToList();
        }

        public void updateSoLuongSP(string pMaSP,string pXuatXu,int soLuongSPMua)
        {
            CHITIET_SP s = qlCH.CHITIET_SPs.Where(t => t.MASP == pMaSP).Where(t => t.XUATXU == pXuatXu).FirstOrDefault();
            int soLuongConLai = int.Parse(s.SOLUONG.ToString())-soLuongSPMua;
            s.SOLUONG = soLuongConLai;
            qlCH.SubmitChanges();

        }

    }
}
