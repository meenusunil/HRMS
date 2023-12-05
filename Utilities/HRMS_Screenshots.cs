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
   

    public void TakeScreenshot(IWebDriver driver, string name)
    {
        ITakesScreenshot s = (ITakesScreenshot)driver;
        Screenshot scr = s.GetScreenshot();
        scr.SaveAsFile("C:\\Users\\mesunil\\source\\repos\\HRMS\\HRMS\\Screenshots\\" + name, ScreenshotImageFormat.Jpeg);

    }

    }

