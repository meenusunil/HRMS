using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Logout
    {
    public bool loginDisplayed;
    public Logout(IWebDriver driver) 
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//img[@class='user-image-top']")]
    IWebElement userImg;

    [FindsBy(How = How.XPath, Using = "//a[text() ='Sign out']")]
    IWebElement signOutButton;

    [FindsBy(How = How.XPath, Using = "//h3[text()='Login to your account']")]
    IWebElement LoginPage;

    public bool UserLogout()
    {
        userImg.Click();
        signOutButton.Click();

        loginDisplayed = LoginPage.Displayed;
        return loginDisplayed;
        
    }
    }
