using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace Demo.ReadWorksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Trifecta Bonus.xlsx";
            ReadSummaryExcelFile(path);
        }

        public static double ReadSummaryExcelFile(string path)
        {
            double gt = 0;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(path);

            Excel.Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
            Excel.Range xlRange = xlWorkSheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            string[] dataColumn = new string[16];
            //string message ="";

            for (int r = 4; r <= rowCount; r++)
            {
                for (int dc = 0; dc < dataColumn.Length; dc++)
                    dataColumn[dc] = " ";

                for (int c = 1; c <= colCount; c++)
                {
                    if (xlRange.Cells[r, c] != null && xlRange.Cells[r, c].Value2 != null)
                    {
                        //Console.Write(xlRange.Cells[r, c].Value2.ToString() + "\t");
                        dataColumn[c - 1] = xlRange.Cells[r, c].Value2.ToString();
                    }
                }
                if (dataColumn[3].Length > 3)
                {
                  
                    //DA.BonusSummaryTable(dataColumn);
                  //  message = "I am here";
                }
                if (dataColumn[0] == "Grand Total")
                {
                    gt = double.Parse(dataColumn[15]);
                    // Console.WriteLine(gt);
                }

                for (int x = 0; x < dataColumn.Length; x++)
                {
                    dataColumn[x] = "";
                }

            }
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlApp.Quit();
            return gt;
        }
    }
}
