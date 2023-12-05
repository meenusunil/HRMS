using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Login
    {
    LoginCredentialsExcel credExcel;
    public bool errorDisplayed;
    public bool successMsg;
    public Login(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.Id, Using = "iusername")]    IWebElement userName;
    [FindsBy(How= How.Id,Using = "ipassword")]   IWebElement password;
    [FindsBy(How = How.Name, Using = "hrsale_form")]    IWebElement loginButton;
    [FindsBy(How = How.XPath, Using = "//div[@class ='toast-message' and text() ='Invalid Login Credential.']")]
    IWebElement errorMessage;
    [FindsBy(How = How.XPath, Using = "//h4[text() ='Welcome back, John Manuel!']")]    IWebElement loginMsg;
    public bool InvalidUserName()
    {
        credExcel = new LoginCredentialsExcel();
        string name = credExcel.InvalidUserName();
        userName.SendKeys(name);
        password.SendKeys(credExcel.Password());
        loginButton.Click();
        Thread.Sleep(1000);
        errorDisplayed = errorMessage.Displayed;
        userName.Clear();
        password.Clear();
        return errorDisplayed;
        
    }

    public bool InvalidPassword()
    {
        credExcel = new LoginCredentialsExcel();
        string pwd = credExcel.InvalidPassword();
        userName.SendKeys(credExcel.Username());
        password.SendKeys(pwd);
        loginButton.Click();
        Thread.Sleep(1000);
        errorDisplayed = errorMessage.Displayed;
        userName.Clear();
        password.Clear();
        return errorDisplayed;
    }
    public bool validCreds()
    {
        credExcel = new LoginCredentialsExcel();
        userName.SendKeys(credExcel.Username());
        password.SendKeys(credExcel.Password());
        loginButton.Click() ;
        Thread.Sleep(1000);
        successMsg = loginMsg.Displayed;
        return successMsg;

    }


    }
