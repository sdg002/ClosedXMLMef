using ClosedXML.Excel;
using System;
using System.ComponentModel.Composition;
using System.Diagnostics;

namespace Demo.Plugin.NetFwk
{
    [Export(typeof(Demo.Contracts.IPlugin))]
    [ExportMetadata("name", "pluginfwk")]
    public class Class1 : Demo.Contracts.IPlugin
    {
        public void DoWork(string file)
        {
            Trace.WriteLine("Inside method Demo.Plugin.NetFwk.Class1.DoWork");
            Trace.WriteLine($"Contents will be written to file:{file}");
            DoSomeSimpleExcel();
        }
        private void DoSomeSimpleExcel()
        {
            string folder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = System.IO.Path.Combine(folder, "HelloWorld-Fwk.xlsx");
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
                worksheet.Columns().AdjustToContents();
                worksheet.Rows().AdjustToContents();
                workbook.SaveAs(file);
            }
        }

    }
}
