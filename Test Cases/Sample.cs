using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
    public class Sample
    {
    public IWebDriver driver;
    public ExtentReports extent;
    public ExtentTest test;
    public Login userLogin;

    [OneTimeSetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Url = "http://hrm.qabible.in/hrms/admin";

        driver.Manage().Window.Maximize();

        var path = new ExtentHtmlReporter(@"C:\Users\mesunil\source\repos\HRMS\HRMS\Reports\HRMSReport.html");
        extent = new ExtentReports();
        extent.AttachReporter(path);
    }
    [OneTimeTearDown]
    public void TearDown()
    {
        driver.Close();
        extent.Flush();
    }

    [Test, Order(1), Category("HRMS Application")]
    public void InvalidUsername()
    {
        test = extent.CreateTest("TC1: Invalid Username entered").Info("This test enters invalid username and checks if error message is displayed");
        userLogin = new Login(driver);
        if (userLogin.InvalidUserName() == false)
        {
            Assert.Fail("Error Message is not displayed");
        }
        else
        {
            Assert.Pass("Error Message displayed");
        }
        test.Log(Status.Info, "Invalid username entered");

    }
}

