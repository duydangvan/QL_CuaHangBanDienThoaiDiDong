using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChiTietSanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();

        public frmChiTietSanPham()
        {
            InitializeComponent();
            ganDL = new layDL(nhanDL);
        }
        public delegate void layDL(string pMaSP,string pTenSP);
        public layDL ganDL;

        void nhanDL(string pMaSP, string pTenSp)
        {
            lbMaSP.Text = pMaSP;
            lbTenSP.Text = pTenSp;
        }


        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            loadTenHangSX();
            loadThoiGian_BH();
            loadXuatXu();
        }

        void loadTenHangSX()
        {
            List<string> dsHSX = sp.loadTenHangSX(lbMaSP.Text.Trim());
            string n = string.Empty;
            for (int i = 0; i < dsHSX.Count;i++ )
            {
                n += dsHSX[i].Trim() + ", ";
                if(i==dsHSX.Count-1)
                {
                    n.Replace(", ",".");
                }
            }
            
                lbTenHangSX.Text = n.Substring(0,n.Length-2)+".";
        }

        void loadThoiGian_BH()
        {
            List<int?> dsTG = sp.loadThoiGian_BH(lbMaSP.Text.Trim());
            string n = string.Empty;
            foreach (int item in dsTG)
            {
                n += item + ", ";
            }
            lbThoiGian_BH.Text = n.Substring(0,n.Length-2)+".";
        }

        void loadXuatXu()
        {
            List<string> dsXuatXu = sp.loadXuatXu(lbMaSP.Text.Trim());
            string n = string.Empty;
            foreach(string item in dsXuatXu)
            {
                n += item + ", ";
            }
            lbXuatXu.Text = n.Substring(0, n.Length - 2) + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
