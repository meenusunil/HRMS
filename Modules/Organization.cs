using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Organization
  {
    public bool b;
     public Organization(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() ='Organization']")] IWebElement orgTab;
    [FindsBy(How = How.XPath, Using = "//a[text() =' Company']")] IWebElement companyTab;
    [FindsBy(How = How.XPath, Using = "//input[@type = 'search']")] IWebElement searchText;
    [FindsBy(How = How.XPath, Using = "//table[@class='datatables-demo table table-striped table-bordered dataTable no-footer']")] IWebElement companyTable;
    [FindsBy(How = How.XPath, Using = "//td[text() = 'infosys']")] IWebElement searchResult;

    public void searchFunctionality()
    {
        orgTab.Click();
        companyTab.Click();
        searchText.SendKeys("infosys");
        if (searchText.Displayed)
        {
            b = true;
            
        }
        else
        {
            b= false;
        }
    }



}

