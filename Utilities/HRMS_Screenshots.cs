using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HRMS_Screenshots
    {
    //public IWebDriver driver;
   

    public string TakeScreenshot(IWebDriver driver, string name)
    {
        ITakesScreenshot s = (ITakesScreenshot)driver;
        Screenshot scr = s.GetScreenshot();
        string screenShotPath = System.Configuration.ConfigurationManager.AppSettings["ScreenshotFolder"];
        scr.SaveAsFile(screenShotPath + name, ScreenshotImageFormat.Jpeg);
        return screenShotPath + name;

    }

    }

