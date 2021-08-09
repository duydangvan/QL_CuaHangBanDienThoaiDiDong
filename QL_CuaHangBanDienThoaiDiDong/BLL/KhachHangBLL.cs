using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL kh = new KhachHangDAL();

        public KhachHangBLL()
        { }

        public IQueryable loadKH()
        {
            return kh.loadKH();
        }

        public string tuDongLoadMaKHKhongTrung()
        {
            Random rd = new Random();
            string maKH = "KH0"+rd.Next(0,500);
            while(kh.kiemTraTrungMaKH(maKH))
            {
                maKH = "KH0" + rd.Next(0,500);
            }
            return maKH;
        }

        public int insertKH(string pMaKH,  string pTenKH, string pDiaChi, string pSDT, int pNamSinh, string pEmail)
        {
            if (!kh.kiemTraTrungMaKH(pMaKH))
            {
                KHACHHANG k = new KHACHHANG();
                k.MAKH = pMaKH;
                k.TENKH = pTenKH;
                k.SDT = pSDT;
                k.DIACHI = pDiaChi;
                k.NAMSINH = pNamSinh;
                k.EMAIL = pEmail;
                kh.insertKH(k);
                return 1;//thêm thành công
            }
            else
                return 0;

        }

        public void UpdateKH(string pMaKH,  string pTenKH, string pDiaChi, string pSDT, int pNamSinh, string pEmail)
        {
            kh.KH_Can_Update(pMaKH,pTenKH,pDiaChi,pSDT,pNamSinh,pEmail);
        }

        public IQueryable timKemMaKH(string pMaKH)
        {
            return kh.timKiemMaKH(pMaKH);
        }

        public IQueryable timKiemTenKH(string pTenKH)
        {
            return kh.timKiemTenKH(pTenKH);
        }
        public IQueryable loadKH_LenThanhToan()
        {
            return kh.loadKH_LenThanhToan();
        }
    }
}
