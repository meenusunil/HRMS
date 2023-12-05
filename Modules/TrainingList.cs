using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Collections;

public class TrainingList
    {
    public bool b;
    public TrainingList(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() ='Training']")] IWebElement TrainingTab;
    [FindsBy(How = How.XPath, Using = "//a[text() =' Training List ']")] IWebElement TrainingListTab;
    [FindsBy(How = How.XPath, Using = "//button[text() = ' Add New']")] IWebElement AddTrainingButton;
    [FindsBy(How = How.XPath, Using = "//span[text() = 'Company']")] IWebElement Company;
    //[FindsBy(How = How.XPath, Using = "//span[@id='select2-training_type-cu-container']")] IWebElement Company;
    
    [FindsBy(How = How.XPath, Using = "//li[text() = ' CRROTHRM']")] IWebElement CompanyDD;
    [FindsBy(How = How.XPath, Using = "//span[text() = 'Training Type']")] IWebElement trainingType;
    [FindsBy(How = How.XPath, Using = "//li[text() = 'Job Training']")] IWebElement trainingTypeDD;
    [FindsBy(How = How.XPath, Using = "//span[text() = 'Trainer']")] IWebElement trainer;
    [FindsBy(How = How.XPath, Using = "//li[text() = 'vini m']")] IWebElement trainerDD;
    [FindsBy(How = How.Name, Using = "training_cost")] IWebElement trainingCost;
    [FindsBy(How = How.XPath, Using = "//input[@class ='select2-search__field' and @placeholder = 'Choose an Employee']")] IWebElement emp;
    [FindsBy(How = How.XPath, Using = "//li[text() =' John Smith']")] IWebElement empDD;
    [FindsBy(How = How.Id, Using = "description")] IWebElement description;
    [FindsBy(How = How.Name, Using = "start_date")] IWebElement startDateDD;

    [FindsBy(How = How.ClassName, Using = "ui-datepicker-year")] IWebElement startYear;
    [FindsBy(How = How.ClassName, Using = "ui-datepicker-month")] IWebElement startMonth;
    [FindsBy(How = How.XPath, Using = "//a[@class ='ui-state-default' and text() = '22']")] IWebElement startDate;
    [FindsBy(How = How.Name, Using = "end_date")] IWebElement endDateDD;
    [FindsBy(How = How.ClassName, Using = "ui-datepicker-year")] IWebElement endYear;
    [FindsBy(How = How.ClassName, Using = "ui-datepicker-month")] IWebElement endMonth;
    [FindsBy(How = How.XPath, Using = "//a[@class ='ui-state-default' and text() = '22']")] IWebElement endDate;
    [FindsBy(How = How.XPath, Using = "//button[text() =' Save ']")] IWebElement saveButton;
    [FindsBy(How = How.XPath, Using = "//div[@class = 'toast toast-success']")] IWebElement addedSuccessMsg;
    
    [FindsBy(How = How.XPath, Using = "//table[@id='xin_table']")] IWebElement trainingTable;
    [FindsBy(How = How.XPath, Using = "(//span[@class='fa fa-trash'])[2]")] IWebElement deleteIcon;
    [FindsBy(How = How.XPath, Using = "//strong[text()='Are you sure you want to delete this record?']")] IWebElement confirmMsg;
    [FindsBy(How = How.XPath, Using = "(//button[text() =' Confirm'])[1]")] IWebElement confirmButton;
    [FindsBy(How = How.XPath, Using = "//div[@class='dataTables_info']")] IWebElement tableInfo;
    [FindsBy(How = How.XPath, Using = "//td[text() ='May-22-2024 to Jul-22-2024']")] IWebElement newTrainingDate;
    



    public void AddTraining()
    {
        TrainingTab.Click();
        TrainingListTab.Click();
        AddTrainingButton.Click();

        Company.Click();
        CompanyDD.Click();
        Thread.Sleep(2000);
        trainingType.Click();
        trainingTypeDD.Click();
        Thread.Sleep(2000);
        trainer.Click();
        trainerDD.Click();
        Thread.Sleep(2000);
        trainingCost.SendKeys("10000");
        emp.Click();
        empDD.Click();
        Thread.Sleep(2000);
        description.SendKeys("New Training added");
        Thread.Sleep(2000);
        startDateDD.Click();
        SelectElement year = new SelectElement(startYear);
        year.SelectByValue("2024");
        SelectElement month = new SelectElement(startMonth);
        month.SelectByText("May");
        startDate.Click();
        Thread.Sleep(2000);
        endDateDD.Click();
        SelectElement yearEnd = new SelectElement(endYear);
        yearEnd.SelectByValue("2024");
        SelectElement monthEnd = new SelectElement(endMonth);
        month.SelectByText("Jul");
        endDate.Click();
        Thread.Sleep(2000);
        saveButton.Click();
        Thread.Sleep(1000);
        if (newTrainingDate.Displayed)
            b = true;
        else
            b = false;

    }

    public void DeleteTraining()
    {
        TrainingTab.Click();
        TrainingListTab.Click();
        string str = tableInfo.Text;
        
        string[] numbers = Regex.Split(str," ");
            for(int j=0; j < numbers.Length; j++)
        {
            Console.WriteLine("Initial values:"+ numbers[j]);
        }
        int i = int.Parse(numbers[1]);
        Thread.Sleep(1000);
        deleteIcon.Click();
        confirmButton.Click();
        Thread.Sleep(1000);
        string[] afterDeletion = Regex.Split(str, " ");
        int a = int.Parse(numbers[1]);
        Console.WriteLine("a:" + a);
        if(a == i-1)
        {
            Assert.Pass();
        }  
        else { Assert.Fail("Item deleted"); }



    }

   

}