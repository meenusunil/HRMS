using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scroll
    {

    public void ScrollPage(IWebDriver driver)
    {

        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

        //js.ExecuteScript("window.scrollBy(0,150)");
    }
    }
