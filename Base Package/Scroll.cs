using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scroll: Browser
    {
        public void PageScroll()
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,200");

    }


    }

