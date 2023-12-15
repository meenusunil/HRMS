using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class BrowserWait
    {
    public IWebDriver driver;
    public WebDriverWait exWait;

    public void WaitImplicit(IWebDriver driver)
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    public void WaitExplicit(IWebDriver driver)
    {
        exWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
    }