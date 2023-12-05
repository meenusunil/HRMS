using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeeReport
   {
     public EmployeeReport(IWebDriver driver) 
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Staff']")]    IWebElement StaffTab;
    [FindsBy(How = How.XPath, Using = "//a[text() = ' Employees']")]    IWebElement EmployeesTab;
    [FindsBy(How = How.XPath, Using = "//button[text() = ' Report ']")] IWebElement ReportDD;
    [FindsBy(How = How.XPath, Using = "//a[text() = 'Employement Report']")] IWebElement empReport;

    [FindsBy(How = How.XPath, Using = "(//span[@class ='select2-selection__rendered'])[1]")] IWebElement companyDD;
    [FindsBy(How = How.XPath, Using = "(//span[@class ='select2-selection__rendered'])[2]")] IWebElement depDD;
    [FindsBy(How = How.XPath, Using = "//li[text() ='CRROTHRM']")] IWebElement crrothrm;
    [FindsBy(How = How.XPath, Using = "//button[text() =' Get ']")] IWebElement GetButton;
    [FindsBy(How = How.XPath, Using = "//li[text() ='MD Office']")] IWebElement MDOffice;

    


    public void ClickEmpReport()
    {
        Thread.Sleep(1000);
        StaffTab.Click();
        Thread.Sleep(1000);
        EmployeesTab.Click();
        ReportDD.Click();
        empReport.Click();
        Thread.Sleep(1000);
    }

    public void GoToEmpReportWindow()
    {
        companyDD.Click();
        crrothrm.Click();
        depDD.Click();
        MDOffice.Click();
        GetButton.Click();
        Thread.Sleep(1000);
    }


}

