using ClosedXML.Excel;
using System;

namespace ConsoleEXECore.DirectInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                DoSomeSimpleExcel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private static void DoSomeSimpleExcel()
        {
            Console.WriteLine("Do you want to invoke AdjustContents method? (y/n)");
            string sShouldAdjustContents = Console.ReadLine();
            string folder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = System.IO.Path.Combine(folder, "HelloWorld-Std.xlsx");
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
                if (sShouldAdjustContents.ToLower() == "y")
                {
                    worksheet.Columns().AdjustToContents();
                    worksheet.Rows().AdjustToContents();
                }
                workbook.SaveAs(file);
            }
        }

    }
}
