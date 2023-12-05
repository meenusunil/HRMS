using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

public class LeaveManagement
    {
    public bool a;
    public LeaveManagement(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);

    }

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Dashboard']")] IWebElement dashboard;
    [FindsBy(How = How.XPath, Using = "//a[text() =' Leave ']")] IWebElement leaveMngmnt;
    [FindsBy(How = How.XPath, Using = "(//span[@class='fa fa-arrow-circle-right'])[2]")] IWebElement viewDetails;
    
    [FindsBy(How = How.XPath, Using = "//span[text() ='Pending']")] IWebElement statusDD;
    //[FindsBy(How = How.XPath, Using = "//span[@class='select2-selection__rendered']")] IWebElement statusDD;
    [FindsBy(How = How.XPath, Using = "//li[text() = 'Approved']")] IWebElement statusApproved;
    [FindsBy(How = How.XPath, Using = "//div[@placeholder ='Remarks']")] IWebElement remarks;
    [FindsBy(How = How.XPath, Using = "(//button[@type='submit'])[1]")] IWebElement saveButton;

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Approved']")] IWebElement status;


    public void ApproveLeave()
    {
        dashboard.Click();
        leaveMngmnt.Click();
        Thread.Sleep(1000);
        viewDetails.Click();
        Thread.Sleep(1000);
        statusDD.Click();
        statusApproved.Click();
        remarks.Clear();
        remarks.SendKeys("Approved");
        saveButton.Click();
        Thread.Sleep(1000);
    }

    public void CheckLeaveStatus()
    {
        Thread.Sleep(1000);
        if (status.Displayed == true)
            a = true;
        else
            a = false;
    }

    }

