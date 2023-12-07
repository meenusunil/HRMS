using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Browser
    {
    public IWebDriver driver;
    public ExtentReports extent;
    public IWebDriver OpenBrowser()
    {
        driver = new ChromeDriver();
        driver.Url = "http://hrm.qabible.in/hrms/admin";
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        return driver;
        
    }
    public void CloseBrowser()
    {
        //driver.Close();
        driver.Quit();
    }
    public void Reports()
    {
        var path = new ExtentHtmlReporter(@"C:\Users\mesunil\source\repos\HRMS\HRMS\Reports\extentRep.html");
        extent = new ExtentReports();
        extent.AttachReporter(path);

    }
    public void ReportsFlush()
    {
        extent.Flush();
    }


    public void SwitchToChildWindow()
    {
        List<string> childHandles = driver.WindowHandles.ToList();
        driver.SwitchTo().Window(childHandles[1]);
    }

    public void SwitchToParentWindow()
    {
        driver.SwitchTo().Window(driver.WindowHandles[0]);
    }


}






