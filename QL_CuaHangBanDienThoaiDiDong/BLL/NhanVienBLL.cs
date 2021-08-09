using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv = new NhanVienDAL();
        public NhanVienBLL()
        {

        }

        public IQueryable loadNV()
        {
            return nv.loadNV();
        }

        public IQueryable loadChucVu()
        {
            return nv.loadCbbChucVu();
        }

        public void themNhanVien(string maNV, string tenNV, string diaChi, string cMND, DateTime ngaySinh, string sDT, string eMail, string chucVu, string hinhNV)
        {
            NHANVIEN nhanVien = new NHANVIEN();
            nhanVien.MANV = maNV;
            nhanVien.HOTEN = tenNV;
            nhanVien.DIACHI = diaChi;
            nhanVien.CMND = cMND;
            nhanVien.NGAYSINH = ngaySinh;
            nhanVien.SDT = sDT;
            nhanVien.EMAIL = eMail;
            nhanVien.CHUCVU = chucVu;
            nhanVien.HINHANH = hinhNV;
            nv.themNV(nhanVien);
        }

        public string loadHinhAnh(string manv)
        {
            return nv.loadAnhNV(manv);
        }

        public string layMaTuDongKhongTrung(string chucVu)
        {
            Random rd = new Random();
            string MaNV = chucVu+"0"+rd.Next(1,500);
            while(nv.kiemTraMaNVTrung(MaNV))
            {
                MaNV = chucVu+"0"+rd.Next(1,500);
            }

            return MaNV;
        }

        public bool kiemTraMaNVTrung(string pMaNV)
        {
            return nv.kiemTraMaNVTrung(pMaNV);
        }

        public void UpdateNV(string maNV, string tenNV, string diaChi, string cMND, DateTime ngaySinh, string sDT, string eMail, string chucVu, string hinhNV)
        {
            nv.UpdateNV(maNV,tenNV,diaChi,cMND,ngaySinh,sDT,eMail,chucVu,hinhNV);
        }

        public string loadAnhLen_Tk(string pMaNV)
        {
            return nv.loadAnhNVLenTK(pMaNV);
        }

        public string loadTenNV(string pMaNV)
        {
            return nv.loadTenNV(pMaNV);
        }

        public IQueryable loadNVLenThongKe()
        {
            return nv.loadNVLenThongKe();
        }

        public IQueryable loadNVTheoNgaylapHD(DateTime pNgayBatDau, DateTime pNgayKetThuc)
        {
            return nv.loadNVTheoNgayLapHD(pNgayBatDau, pNgayKetThuc);
        }

        public DataTable dsNVTrongThongKe(DateTime pNgayBatDau, DateTime pNgayKetThuc)
        {
            return nv.dsNVTrongThongKe(pNgayBatDau,pNgayKetThuc);
        }

    }
}
