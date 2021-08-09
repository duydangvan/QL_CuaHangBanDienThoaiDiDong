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
    public partial class frmDSKH : Form
    {
        KhachHangBLL kh = new KhachHangBLL();
        public frmDSKH()
        {
            InitializeComponent();
        }

        private void frmDSKH_Load(object sender, EventArgs e)
        {

            loadKHLen();
        }


        public void loadKHLen()
        {
            dtgvDSKH.DataSource = kh.loadKH();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dtgvDSKH.Columns.Count + 1; i++)
                {

                    worksheet.Cells[1, i] = dtgvDSKH.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dtgvDSKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvDSKH.Columns.Count; j++)
                    {
                        string tenluu = dtgvDSKH.Rows[i].Cells[j].Value.ToString().Trim();
                        worksheet.Cells[i + 2, j + 1] = tenluu;
                    }
                }
                // save the application  
                workbook.SaveAs(@"C:\Users\Duy\Desktop\DanhSachKhachHang", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
