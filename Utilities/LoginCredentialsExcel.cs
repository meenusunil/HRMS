using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

public class LoginCredentialsExcel
    {
    public Excel.Application ex;
    public Excel.Workbook wb;
    public Excel._Worksheet ws;
    public Excel.Range range;

    public void OpenExcel()
    {
        string excelFolder = System.Configuration.ConfigurationManager.AppSettings["LoginExcelFolder"];
        string excelName = System.Configuration.ConfigurationManager.AppSettings["ExcelName"];
        //Making a new path
        string Base = AppDomain.CurrentDomain.BaseDirectory;
        string RelativePath = Path.Combine(excelFolder, excelName);
        string newpath = Path.Combine(Base, RelativePath);

        ex = new Excel.Application();
        wb = ex.Workbooks.Open(newpath, FileAccess.ReadWrite);
        ws = (Excel._Worksheet)wb.Worksheets[1];
        range = ws.UsedRange;

    }
    public string InvalidUserName()
    {
        OpenExcel();
        string username = range.Cells[1][1].Value2.ToString();
        return username;
    }

    public string Password()
    {
        OpenExcel();
        string password = range.Cells[2][3].Value2.ToString();
        return password;
    }
    public string Username()
    {
        OpenExcel();
        string username = range.Cells[1][3].Value2.ToString();
        return username;
    }

    public string InvalidPassword()
    {
        OpenExcel();
        string password = range.Cells[2][2].Value2.ToString();
        return password;
    }

    public void CloseExcel()
    {
        ex.Quit();
    }
    

}

