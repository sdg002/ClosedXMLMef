# ClosedXML and Managed Extensibility Framework
Demo of loading plugins from a folder using Managed Extensibility Framework. Some ClosedXML issues with .NET Standard 20 package.

## About
This is a simple .NET Framework Console EXE which 
- Discovers plugins from a subdirectory using Managed Extensibility Framework
- loads plugins using MEF
- Demonstrates a very simple usage of ClosedXML to create a simple Excel file
- The solution has 2 plugin projects 1)CosedXML on .NET Framework class library 2)ClosedXML using .NET Standard20

## Challenges
The plugin written on .NET Standard 20 throws PlatformNotSupportedException when the methods AdjustToContents is called. Works fine otherwise


## Stack trace

System.PlatformNotSupportedException: System.Drawing is not supported on this platform.
   at System.Drawing.Font..ctor(String familyName, Single emSize, FontStyle style)
   at ClosedXML.Excel.FontBaseExtensions.GetCachedFont(IXLFontBase fontBase, Dictionary`2 fontCache)
   at ClosedXML.Excel.FontBaseExtensions.GetWidth(IXLFontBase fontBase, String text, Dictionary`2 fontCache)
   at ClosedXML.Excel.XLColumn.AdjustToContents(Int32 startRow, Int32 endRow, Double minWidth, Double maxWidth)
   at ClosedXML.Excel.XLColumns.<>c.<AdjustToContents>b__8_0(XLColumn c)
   at System.Collections.Generic.List`1.ForEach(Action`1 action)
   at ClosedXML.Excel.XLColumns.AdjustToContents()
   at Demo.Plugin.NetStd.Class1.DoSomeSimpleExcel() in C:\Users\saurabhd\MyTrials\Apex-Stuff\ClosedXMLMef\Demo.Plugin.NetStd\Class1.cs:line 30
   at Demo.Plugin.NetStd.Class1.DoWork(String file) in C:\Users\saurabhd\MyTrials\Apex-Stuff\ClosedXMLMef\Demo.Plugin.NetStd\Class1.cs:line 15
   at Demo.ConsoleEXEFwk.Program.Main(String[] args)
Press any key to continue . . .
