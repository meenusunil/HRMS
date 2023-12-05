using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class ThemeSettings
    {
    public bool c;
    public ThemeSettings(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//span[text() ='Dashboard']")] IWebElement DashboardTab;
    [FindsBy(How = How.XPath, Using = "//div[@class=\"fc-toolbar fc-header-toolbar\"]")] IWebElement calendar;
    [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-asterisk']")] IWebElement settings;
    [FindsBy(How = How.XPath, Using = "//a[text() = 'Theme Settings']")] IWebElement themes;
    [FindsBy(How = How.XPath, Using = "(//a[text() ='No'])[1]")] IWebElement calendarToggle;
    [FindsBy(How = How.XPath, Using = "(//button[text() =' Save '])[1]")] IWebElement saveButton;
    [FindsBy(How = How.XPath, Using = "//div[@id='toast-container']")] IWebElement successMsg;

    public void ChangeCalendarSettings()
    {
        settings.Click();
        themes.Click();
        calendarToggle.Click();
        saveButton.Click();
        //give explicit wait nad fetch the text from element and validate.
    }
    public void ToastMessage()
    {
        if (successMsg.Displayed == true)
            c = true;
        else
            c = false;
    }

    }

