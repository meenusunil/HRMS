using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KeyboardActions
    {
    public Actions act;
    public void TabKeyDown(IWebDriver driver)
    {
        act = new Actions(driver);
        act.KeyDown(Keys.Tab).Perform();
    }
    public void TabKeyUp(IWebDriver driver)
    {
        act = new Actions(driver);  
        act.KeyUp(Keys.Tab).Perform();
    }

    }
