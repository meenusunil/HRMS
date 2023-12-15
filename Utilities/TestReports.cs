using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

public  class TestReports
    {
    public ExtentReports extent;
    public void Reports()
    {
        string reportPath = System.Configuration.ConfigurationManager.AppSettings["ReportFolder"];
        var path = new ExtentHtmlReporter(reportPath);
       // var path = new ExtentHtmlReporter(@"C:\Users\mesunil\source\repos\HRMS\HRMS\Reports\ExtRep.html");
        extent = new ExtentReports();
        extent.AttachReporter(path);

    }
    public void ReportsFlush()
    {
        extent.Flush();
    }
}

