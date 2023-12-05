using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class TrainingType
    {
    public bool toastMsg;
    public TrainingType(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() ='Training']")]
    IWebElement TrainingTab;

   [FindsBy(How = How.XPath, Using = "//a[text() =' Training Type ']")]
    IWebElement TrainingTypeTab;

  //  [FindsBy(How = How.XPath, Using = "//a[@href='https://hrm.qabible.in/hrms/admin/training_type']")]
    //IWebElement TrainingTypeTab;
    

    [FindsBy(How = How.XPath, Using = "//a[text() =' Training List ']")]
    IWebElement TrainingListTab;

    [FindsBy(How = How.Name, Using = "type_name")]
    IWebElement TrainingTypeTextBox;

    [FindsBy(How = How.XPath, Using = "//button[text() =' Save ']")]
    IWebElement SaveButton;

    [FindsBy(How = How.XPath, Using = "//div[text() ='Training type added.']")]
    IWebElement TrainingToastMsg;

    [FindsBy(How = How.XPath, Using = "//table[@class='datatables-demo table table-striped table-bordered dataTable no-footer']")]
    IWebElement typeTable;

    public bool AddNewTrainingType()
    {
        TrainingTab.Click();
        TrainingListTab.Click();
        TrainingTypeTextBox.SendKeys("Selenium");
        SaveButton.Click();
        toastMsg = TrainingToastMsg.Displayed;
        return toastMsg;

    }

    public bool checkNewTypeInGrid()
    {
        bool b = false;
        List<IWebElement> tableData = new List<IWebElement>(typeTable.FindElements(By.TagName("td")));
        for(int i = 0;i < tableData.Count; i++)
        {
            IWebElement type = tableData[i];
            if (type.Text == "Selenium")
            {
                b = true;
                break;
            }
            else
                b = false;
        }
        return b;
    }



}

