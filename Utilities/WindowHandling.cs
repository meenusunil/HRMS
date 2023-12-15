using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WindowHandling
    {
    public IWebDriver driver;
    public void SwitchToChildWindow(IWebDriver driver)
    {
        List<string> childHandles = driver.WindowHandles.ToList();
        driver.SwitchTo().Window(childHandles[1]);
    }
    public void SwitchToParentWindow(IWebDriver driver)
    {
        driver.SwitchTo().Window(driver.WindowHandles[0]);
    }




}
