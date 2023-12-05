using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Profile
    {
    
    public bool c;
    public Profile(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//img[@class='user-image-top']")] IWebElement userImg;
    [FindsBy(How = How.XPath, Using = "//a[text() ='My Profile']")] IWebElement profileTab;
    [FindsBy(How = How.XPath, Using = "//a[text() =' Basic Information ']")] IWebElement basicInfo;
    [FindsBy(How = How.Name, Using = "contact_no")] IWebElement contactNo;
    [FindsBy(How = How.XPath, Using = "(//button[text() =' Save'])[1]")] IWebElement saveButton;
    [FindsBy(How = How.XPath, Using = "//div[text() ='Basic Information updated.']")] IWebElement toastMsg;

    public void profileBasicInfoUpdate()
    {
        userImg.Click();
        profileTab.Click();
        basicInfo.Click();
        contactNo.Clear();
        contactNo.SendKeys("1234567890");
        saveButton.Click();
        //driver.Navigate().Refresh();
        
 
    }

    public void UpdateResult()
    {
        if (contactNo.GetAttribute("value") == "1234567890")
            c = true;
        else
            c = false;
    }
    
}

