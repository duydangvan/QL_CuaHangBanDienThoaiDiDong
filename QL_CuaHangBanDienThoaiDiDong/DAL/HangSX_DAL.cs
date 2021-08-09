using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangSX_DAL
    {
        QLCuaHangDataContext qlCH = new QLCuaHangDataContext();
        public HangSX_DAL()
        {

        }

        public IQueryable loadHSX()
        {
            var hangsx = qlCH.HANGSXes.Select(h => new { h.MAHANGSX, h.TENHANGSX, h.DIACHI, h.SDT});
            return hangsx;
        }

        public bool kiemTraTrungMa(string pMaHangSX)
        {
            int kq = qlCH.HANGSXes.Where(h=>h.MAHANGSX==pMaHangSX).Count();
            if (kq >= 1)
                return true;
            return false;
        }

        public void insertHSX(HANGSX h)
        {
            qlCH.HANGSXes.InsertOnSubmit(h);
            qlCH.SubmitChanges();
        }

        public void HangSX_Update(string pMaHangSX, string ptenHSX, string pDiaChi, string pSDT)
        {
                HANGSX h = qlCH.HANGSXes.Where(k => k.MAHANGSX == pMaHangSX).FirstOrDefault();
                h.TENHANGSX = ptenHSX;
                h.DIACHI = pDiaChi;
                h.SDT = pSDT;
                qlCH.SubmitChanges();

        }



    }
}
