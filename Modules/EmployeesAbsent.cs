using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeesAbsent
    {
    public bool t;
    public EmployeesAbsent(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() ='Employee Absent Today']")] IWebElement absentTab;

    public void EmpAbsentTabDisplayed()
    {
        if (absentTab == null)
            t = false;
        else t = true;
    }



    }

