using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangSX_BLL
    {
        HangSX_DAL hangSX = new HangSX_DAL();

        public HangSX_BLL()
        { }

        public IQueryable loadHangSX()
        {
            return hangSX.loadHSX();
        }

        public string loadMaHangSXTuDong()
        {
            Random rd = new Random();
            string maHangSX = "HSX0" + rd.Next(0,500);
            while(hangSX.kiemTraTrungMa(maHangSX))
            {
                maHangSX = "HSX0" + rd.Next(0, 500);
            }
            return maHangSX;
        }

        public int insertHSX_BLL(string pMaHangSX, string ptenHSX, string pDiaChi, string pSDT)
        {
            if (!hangSX.kiemTraTrungMa(pMaHangSX))
            {
                HANGSX h = new HANGSX();
                h.MAHANGSX = pMaHangSX;
                h.TENHANGSX = ptenHSX;
                h.DIACHI = pDiaChi;
                h.SDT = pSDT;
                hangSX.insertHSX(h);
                return 1;//Đã thêm thành công 
            }
            else
                return 0;//Đã bị trùng mã
        }

        public void updateHSX(string pMaHangSX, string ptenHSX, string pDiaChi, string pSDT)
        {
            hangSX.HangSX_Update(pMaHangSX,ptenHSX,pDiaChi,pSDT);
        }
    }
}
