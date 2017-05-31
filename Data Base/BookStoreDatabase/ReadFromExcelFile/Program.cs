using System;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadFromExcelFile
{
    class Program
    {
        static void Main()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            string excelFileLocation=string.Empty;
            var files =Directory.GetFiles (Environment.CurrentDirectory);
            foreach (var file in files)
            {
                if (file.Contains("excel")) excelFileLocation = file;
            }
           // GetRelativePath();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFileLocation);
            //(@"D:\csrp\BookStoreDatabase\BookStoreDatabase\bin\Debug\excelinputBook.xlsx");
        

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            //Then you can read from the sheet, keeping in mind that indexing in Excel is not 0 based. 
            //This just reads the cells and prints them back just as they were in the file. 

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!

            int rowCount = 3;
            int colCount = 2;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");

                    //add useful things here!   
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private static void GetRelativePath()
        {
            Uri file = new Uri(@"D:\csrp\BookStoreDatabase\BookStoreDatabase\bin\Debug\excelinputBook.xlsx");
            // Must end in a slash to indicate folder
            Uri folder = new Uri(Environment.CurrentDirectory);
            string relativePath =
                Uri.UnescapeDataString(
                    folder.MakeRelativeUri(file)
                        .ToString()
                        .Replace('/', Path.DirectorySeparatorChar)
                    );
            Console.WriteLine("relative is {0} ",relativePath);
        }
    }
}
