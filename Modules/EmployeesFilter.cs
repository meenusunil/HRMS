using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class EmployeesFilter
    {
    public bool f,h;
    public EmployeesFilter(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Staff']")] IWebElement StaffTab;
    [FindsBy(How = How.XPath, Using = "//a[text() = ' Employees']")] IWebElement EmpTab;
    [FindsBy(How = How.XPath, Using = "//button[text() =' Filter']")] IWebElement FilterButton;
    [FindsBy(How = How.XPath, Using = "//h3[text() ='Filter Employee']")] IWebElement FilterSection;
    [FindsBy(How = How.XPath, Using = "//button[text() =' Hide']")] IWebElement HideFilter;


    public void FilterSectionDisplayed()
    {
        Thread.Sleep(1000);
        StaffTab.Click();
        EmpTab.Click();
        FilterButton.Click();
        Thread.Sleep(1000);
        if (FilterSection.Displayed == true)
            f = true;
        else
            f = false;
    }

    public void HideFilterSection()
    {
        HideFilter.Click();
        Thread.Sleep(1000);
        if (FilterSection.Displayed == true)
            h = false;
        else
            h = true;
    }

    }
