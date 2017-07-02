using System;
using Microsoft.Office.Interop.Excel;
using Excel_12 = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ThuctapCSDL.DataAccessLayer
{
    public class Export
    {
        public Export()
        {

        }

        public void Print(DataGridView dgv)
        {
            try
            {
                Excel_12.Application excel = new Excel_12.Application();

                excel.Workbooks.Add(true);

                Excel_12.Application oExcel_12 = null;       // Excel_12 Application
                Workbook oBook = null;                       // Excel_12 Workbook
                Sheets oSheetsColl = null;                   // Excel_12 Worksheets collection
                Worksheet oSheet = null;                     // Excel_12 Worksheet
                Range oRange = null;                         // Cell or Range in worksheet
                object oMissing = System.Reflection.Missing.Value;
                oExcel_12 = new Excel_12.Application();
                // Make Excel_12 visible to the user.
                oExcel_12.Visible = true;
                // Set the UserControl property so Excel_12 won't shut down.
                oExcel_12.UserControl = true;
                // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
                // Add a workbook.
                oBook = oExcel_12.Workbooks.Add(oMissing);
                // Get worksheets collection
                oSheetsColl = oExcel_12.Worksheets;

                oSheet = (Worksheet)oSheetsColl.get_Item("Sheet1");

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    oRange = (Range)oSheet.Cells[1, j + 1];
                    oRange.Value2 = dgv.Columns[j].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {

                        oRange = (Range)oSheet.Cells[i + 2, j + 1];
                        oRange.Value2 = dgv.Rows[i].Cells[j].Value;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

