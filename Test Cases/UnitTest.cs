using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
    public class UnitTest: Browser
    {
    public IWebDriver driver;
    public Login userLogin;
    public Browser browser;
    public ExtentTest test;
    public AddEmployee addEmp;
    public Logout logout;
    public TrainingList trngList;
    public Organization org;
    public Profile profile;
    public LeaveManagement leaveMngmt;
    public EmployeesFilter empFilter;
    public ThemeSettings themeSettings;
    public HRMS_Screenshots screenshot;
    public EmployeeReport empRep;
    public EmployeesAbsent abs;

    [OneTimeSetUp]
    public void Setup()
    {
        driver = OpenBrowser();
        Reports();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        CloseBrowser();
        ReportsFlush();
    }

    [Test, Order(1), Category("HRMS Application")]
    public void InvalidUsername()
    { 
        //Assert.Ignore();
        test = extent.CreateTest("TC1: Enter invalid password").Info("This test enters invalid username and checks if error message is displayed");
        userLogin = new Login(driver);
        screenshot = new HRMS_Screenshots();
        string name = "InvalidUserName.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (userLogin.InvalidUserName() == false)
        {
            test.Log(Status.Fail, "Error message for invalid username is not displayed");
            Assert.Fail("Error Message is not displayed");
        }
        else
        {
            test.Log(Status.Pass, "Error message for invalid username is displayed");
            Assert.Pass("Error Message displayed");
        }

    }

    [Test, Order(2), Category("HRMS Application")]
    public void InvalidPassword()
    {
        //Assert.Ignore();
        test = extent.CreateTest("TC2: Enter Invalid Password").Info("This test enters invalid password and checks if error message is displayed");
        userLogin = new Login(driver);
        screenshot = new HRMS_Screenshots();
        string name = "InvalidPassword.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (userLogin.InvalidPassword() == false)
        {
            test.Log(Status.Fail, "Error message for invalid password is not displayed");
            Assert.Fail("Error Message is not displayed");
        }
        else
        {
            test.Log(Status.Pass, "Error message for invalid password is not displayed");
            Assert.Pass("Error Message displayed");
        }

    }

    [Test, Order(3), Category("HRMS Application")]
    public void validCredentials()
    {
        //Assert.Ignore();
        test = extent.CreateTest("TC3: Enter valid credentials.").Info("This test enters valid credentials and checks if login is successful");
        userLogin = new Login(driver);
        screenshot = new HRMS_Screenshots();
        string name = "ValidCredentials.jpeg";
        Thread.Sleep(1000);
        screenshot.TakeScreenshot(driver, name);
        if (userLogin.validCreds() == false)
        {
            test.Log(Status.Fail, "Login message for successful login is not displayed");
            Assert.Fail("Login message for successful login is not displayed");
        }
        else
        {
            test.Log(Status.Pass, "Login message for successful login is displayed");
            Assert.Pass("Error Message displayed");
        }
        test.Log(Status.Info, "Valid creds entered");

    }
    
    [Test, Order(4), Category("HRMS Application")]
    public void AddTraining()
    {
        Assert.Ignore();
        test = extent.CreateTest("TC4: Add a new training").Info("This tests if a new training can be added successfully");
        trngList = new TrainingList(driver);
        screenshot = new HRMS_Screenshots();
        string name = "AddTraining.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (trngList.b == false)
        {
            test.Log(Status.Fail, "Training added not listed in grid");
            Assert.Fail("Training added not listed in grid");
        }
        else
        {
            test.Log(Status.Pass, "Training added listed in grid");
            Assert.Pass();
        }
    }

    [Test, Order(5), Category("HRMS Application")] 
    public void SearchCompany()
    {
        //Assert.Ignore();
        test = extent.CreateTest("TC5: Search for a company").Info("This tests the search functionality");
        org = new Organization(driver);
        org.searchFunctionality();
        screenshot = new HRMS_Screenshots();
        string name = "CompanySearch.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (org.b == false)
        {
            test.Log(Status.Fail, "Search functionality is not working");
            Assert.Fail("Search functionality is not working");
        }
        else
        {
            test.Log(Status.Pass, "Search functionality is working");
            Assert.Pass();
        }
    }

    [Test, Order(6), Category("HRMS Application")] 
    public void UpdateContactNo()
    {
        //Assert.Ignore();
        test = extent.CreateTest("TC6: Update Contact Number").Info("This tests if contact number can be updated successfully");
        Thread.Sleep(1000);
        profile = new Profile(driver);
        profile.profileBasicInfoUpdate();
        driver.Navigate().Refresh();
        profile.UpdateResult();
        screenshot = new HRMS_Screenshots();
        string name = "UpdateContactInfo.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (profile.c == false)
        {
            test.Log(Status.Fail, "Update functionality is not working");
            Assert.Fail("Update not working");
        }
        else
        {
            test.Log(Status.Pass, "Search functionality is working");
            Assert.Pass("Search functionality is working");
        }
    }

    [Test, Order(7), Category("HRMS Application")] 
    public void ApproveLeave()
    {
       //Assert.Ignore();
        try {
            test = extent.CreateTest("TC7: Approve Leave").Info("This tests if leave can be approved successfully");
            leaveMngmt = new LeaveManagement(driver);
            leaveMngmt.ApproveLeave();
            driver.Navigate().Back();
            leaveMngmt.CheckLeaveStatus();
            screenshot = new HRMS_Screenshots();
            string name = "ApproveLeave.jpeg";
            screenshot.TakeScreenshot(driver, name);
            if (leaveMngmt.a == false)
            {
                test.Log(Status.Fail, "Leave status not updated");
                Assert.Fail("Leave status not updated");
            }
            else
            {
                test.Log(Status.Pass, "Leave status is updated");
                Assert.Pass("Leave status not updated");
            }
        }
       catch (NoSuchElementException ex)
        {
            test.Log(Status.Fail, "No such element");
            Assert.Fail("No such element");
        }

    }

    [Test, Order(8), Category("HRMS Application")]   
    public void EmpFilterSection()
    {
      // Assert.Ignore();
        test = extent.CreateTest("TC8: Employee Filter Section").Info("This tests if filter section is displayed");
        empFilter = new EmployeesFilter(driver);
        empFilter.FilterSectionDisplayed();
        screenshot = new HRMS_Screenshots();
        string name = "EmpFilter.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (empFilter.f == false) 
        {
            test.Log(Status.Fail, "Filter section not displayed");
            Assert.Fail("Filter section not displayed");
        }
        else
        {

            test.Log(Status.Pass, "Filter section is displayed");
            Assert.Pass("Filter section is displayed");
        }

    }

    [Test, Order(9), Category("HRMS Application")]   
    public void EmpHideFilterSection()
    {
      // Assert.Ignore();
        test = extent.CreateTest("TC9: Hide Filter Section").Info("This tests if section can be hidden");
        empFilter = new EmployeesFilter(driver);
        empFilter.HideFilterSection();
        screenshot = new HRMS_Screenshots();
        string name = "HideFilter.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (empFilter.h == false)
        {
            test.Log(Status.Fail, "Filter section is not hidden");
            Assert.Fail("Filter section is not hidden");
        }
            
        else
        {
            test.Log(Status.Pass, "Filter section is hidden");
            Assert.Pass("Filter section is not hidden");
        }
    }

    [Test, Order(10), Category("HRMS Application")]
    public void CalendarSettings()
    {
        //Assert.Ignore();
            test = extent.CreateTest("TC10: Change Theme- Calendar").Info("This tests if calendar settings can be changed");
            themeSettings = new ThemeSettings(driver);
            themeSettings.ChangeCalendarSettings();
            //driver.SwitchTo().Frame("toast-container");
            //themeSettings.ToastMessage();
            screenshot = new HRMS_Screenshots();
            string name = "CalendarSettings.jpeg";
            screenshot.TakeScreenshot(driver, name);
            if (themeSettings.c == false)
            {
                test.Log(Status.Fail, "No such Frame.");
                Assert.Fail("Calendar setting unchanged");
            }
                
            else
            {
                Assert.Pass("Calendar setting changed");
                Assert.Pass();
            }
      
    }

    [Test, Order(11), Category("HRMS Application")]
    public void AbsentTabDisplayed()
    {
        //Assert.Ignore();
        Thread.Sleep(1000);
        test = extent.CreateTest("TC11: Absent Tab").Info("This tests if absent Tab is displayed");
        abs = new EmployeesAbsent(driver);
        screenshot = new HRMS_Screenshots();
        string name = "AbsentTab.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (abs.t == true)
        {
            test.Log(Status.Fail, "Absent Tab is not displayed");
            Assert.Fail("Absent Tab is not displayed");
        }
        else
        {
            test.Log(Status.Pass, "Absent Tab is displayed");
            Assert.Pass("Absent Tab is displayed");
        }

    }


    [Test, Order(12), Category("HRMS Application")]   
    public void LogoutApp()
    {
        //Assert.Ignore();
        Thread.Sleep(1000);
        test = extent.CreateTest("TC12: Logout").Info("This tests if user can logout successfully");
        logout = new Logout(driver);
        screenshot = new HRMS_Screenshots();
        string name = "Logout.jpeg";
        screenshot.TakeScreenshot(driver, name);
        if (logout.UserLogout() == false)
        {
            test.Log(Status.Fail, "Logout unsuccessful");
            Assert.Fail("Logout unsuccessful"); 
        }
        else
        {
            test.Log(Status.Pass, "Logout successful");
            Assert.Pass("Logout successful");
        }

    }

}

