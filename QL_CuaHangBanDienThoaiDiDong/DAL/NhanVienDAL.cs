using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();
        public NhanVienDAL()
        {

        }

        public IQueryable loadNV()
        {
            var dsnv = from nv in qlCH.NHANVIENs
                       select new {nv.MANV,nv.HOTEN,nv.DIACHI,nv.CMND,nv.NGAYSINH, nv.SDT, nv.EMAIL, nv.CHUCVU };
            return dsnv;
        }

        public IQueryable loadCbbChucVu()
        {
            var chucvu = qlCH.NHANVIENs.Select(n=>n.CHUCVU).Distinct();
            return chucvu;
        }

        public void themNV(NHANVIEN nv)
        {
            qlCH.NHANVIENs.InsertOnSubmit(nv);
            qlCH.SubmitChanges();
        }

        public string loadAnhNV(string manv)
        {
            NHANVIEN nvs = qlCH.NHANVIENs.Where(n => n.MANV == manv).FirstOrDefault();
            string hi = nvs.HINHANH;
            return hi;
        }

        public bool kiemTraMaNVTrung(string pMaNV)
        {
            int kq = qlCH.NHANVIENs.Where(n => n.MANV == pMaNV).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public void UpdateNV(string maNV, string tenNV, string diaChi, string cMND, DateTime ngaySinh, string sDT, string eMail, string chucVu, string hinhNV)
        {
            var nhanVien = qlCH.NHANVIENs.Where(n => n.MANV == maNV).FirstOrDefault();
            if(nhanVien !=null)
            {
                nhanVien.HOTEN = tenNV;
                nhanVien.DIACHI = diaChi;
                nhanVien.CMND = cMND;
                nhanVien.NGAYSINH = ngaySinh;
                nhanVien.SDT = sDT;
                nhanVien.EMAIL = eMail;
                nhanVien.CHUCVU = chucVu;
                nhanVien.HINHANH = hinhNV;
                qlCH.SubmitChanges();
            }
        }

        public string loadAnhNVLenTK(string pMaNV)
        {
            NHANVIEN anh = qlCH.NHANVIENs.Where(n => n.MANV == pMaNV).SingleOrDefault();
            return anh.HINHANH;
        }

        public string loadTenNV(string pMaNV)
        {
            NHANVIEN ten = qlCH.NHANVIENs.Where(n => n.MANV == pMaNV).SingleOrDefault();
            return ten.HOTEN;
        }

        public IQueryable loadNVLenThongKe()
        {
            var n = from nv in qlCH.NHANVIENs
                    from h in qlCH.HOADONs
                    where nv.MANV == h.MANV
                    select new
                    {
                        nv.MANV, nv.HOTEN,nv.DIACHI, nv.NGAYSINH, nv.SDT, nv.EMAIL,h.MAHD, h.TONGTIEN
                    };
            return n.Distinct();
        }

        public IQueryable loadNVTheoNgayLapHD(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var n = from nv in qlCH.NHANVIENs
                    from h in qlCH.HOADONs
                    where nv.MANV == h.MANV
                    where h.NGAYLAPHD>=ngayBatDau
                    where h.NGAYLAPHD<=ngayKetThuc
                    select new
                    {
                        nv.MANV,
                        nv.HOTEN,
                        nv.DIACHI,
                        nv.NGAYSINH,
                        nv.SDT,
                        nv.EMAIL,
                        h.MAHD,
                        h.TONGTIEN
                    };
            return n.Distinct();
        }

        public DataTable dsNVTrongThongKe(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var n = (from nv in qlCH.NHANVIENs
                    from h in qlCH.HOADONs
                    where nv.MANV == h.MANV
                    where h.NGAYLAPHD >= ngayBatDau
                    where h.NGAYLAPHD <= ngayKetThuc
                    select new
                    {
                        nv.MANV,
                        nv.HOTEN,nv.DIACHI
                    }).Distinct();
            DataTable table = LINQToDataTable(n);
                return table;
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

    }
}
