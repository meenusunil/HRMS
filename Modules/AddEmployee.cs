using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class AddEmployee
    {
    public AddEmployee(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Staff']")]
    IWebElement StaffTab;

    [FindsBy(How = How.XPath, Using = "//a[text() = ' Employees']")]
    IWebElement EmployeesTab;

    [FindsBy(How = How.XPath, Using = "//button[text() = ' Add New']")]
    IWebElement AddNewButton;

    [FindsBy(How = How.Name, Using = "first_name")]
    IWebElement firstName;

    [FindsBy(How = How.Name, Using = "last_name")]
    IWebElement lastName;

    [FindsBy(How = How.XPath, Using = "//span[@aria-labelledby='select2-aj_company-container']")]
    IWebElement company;

    [FindsBy(How = How.XPath, Using = "//li[text() ='CRROTHRM']")]
    IWebElement companyDD;

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Location']")]
    IWebElement location;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Chennai Branch']")]
    IWebElement locationDD;


    [FindsBy(How =How.Name,Using = "email")]
    IWebElement email;

    [FindsBy(How =How.Name,Using = "username")]
    IWebElement username;

    [FindsBy(How = How.Name, Using = "date_of_birth")]
    IWebElement dob;

    [FindsBy(How = How.XPath, Using = "//select[@class ='ui-datepicker-year']")]
    IWebElement dobYear;

    [FindsBy(How = How.XPath, Using = "//select[@class ='ui-datepicker-month']")]
    IWebElement dobMonth;

    [FindsBy(How = How.XPath, Using = "//a[@class ='ui-state-default' and text() = '16']")]
    IWebElement dobDate;

    [FindsBy(How = How.Name, Using = "contact_no")]
    IWebElement contactNo;

    [FindsBy(How = How.Name, Using = "employee_id")]
    IWebElement empId;

    [FindsBy(How = How.Name, Using = "date_of_joining")]
    IWebElement doj;

    [FindsBy(How = How.ClassName, Using = "ui-datepicker-year")]
    IWebElement dojYear;

    [FindsBy(How = How.ClassName, Using = "ui-datepicker-month")]
    IWebElement dojMonth;

    [FindsBy(How = How.XPath, Using = "//a[@class ='ui-state-default' and text() = '26']")]
    IWebElement dojDate;

    [FindsBy(How = How.XPath, Using = "//span[text() ='Select Department']")]
    IWebElement dept;

    [FindsBy(How = How.XPath, Using = "//li[text() ='MD Office']")]
    IWebElement MDOffice;

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Designation']")]
    IWebElement designation;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Developer']")]
    IWebElement developer;

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Male']")]
    IWebElement gender;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Male']")]
    IWebElement male;
    

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Morning Shift']")]
    IWebElement shift;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Morning Shift']")]
    IWebElement morningShift;

    [FindsBy(How = How.Name, Using = "password")]
    IWebElement password;

    [FindsBy(How = How.Name, Using = "confirm_password")]
    IWebElement ConfirmPwd;

    [FindsBy(How = How.XPath, Using = "//span[text() = 'Role']")]
    IWebElement role;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Employee']")]
    IWebElement empRole;

    [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Leave Category']")]
    IWebElement leaveCategory;

    [FindsBy(How = How.XPath, Using = "//li[text() ='Casual Leave']")]
    IWebElement casualLeave;

    [FindsBy(How = How.Name, Using = "address")]
    IWebElement address;

    [FindsBy(How = How.XPath, Using = "//button[text() = ' Save']")]
    IWebElement save;

    [FindsBy(How = How.XPath, Using = "//table[@id ='xin_table']")]
    IWebElement empTable;

    [FindsBy(How = How.TagName, Using = "td")]
    IWebElement tableData;
    
    public void AddNewEmployee()
    {
        Thread.Sleep(1000);
        StaffTab.Click();
        EmployeesTab.Click();
        AddNewButton.Click();
        Thread.Sleep(2000);
    }

    public void EnterEmpDetails()
    {
        firstName.SendKeys("Philip");
        lastName.SendKeys("Thomas");
        empId.SendKeys("567543");

        doj.Click();
        SelectElement joiningYear = new SelectElement(dojYear);
        joiningYear.SelectByValue("2023");
        SelectElement joiningMonth = new SelectElement(dojMonth);
        joiningMonth.SelectByText("Nov");
        dojDate.Click();

        company.Click();
        companyDD.Click();

        location.Click();
        locationDD.Click();

        dept.Click();
        MDOffice.Click();

        designation.Click();
        developer.Click();

        username.SendKeys("pthomas");
        email.SendKeys("pthomas@xxx.com");
        gender.Click();
        male.Click();
        shift.Click();
        morningShift.Click();

        dob.Click();
        SelectElement birthyear = new SelectElement(dobYear);
        birthyear.SelectByValue("1992");
        SelectElement birthMonth = new SelectElement(dobMonth);
        birthMonth.SelectByText("May");
        dobDate.Click();

        contactNo.SendKeys("9897253749");
        password.SendKeys("12345");
        ConfirmPwd.SendKeys("12345");
        role.Click();
        empRole.Click();
        leaveCategory.Click();
        casualLeave.Click();
        address.SendKeys("xxx yyy zzz");

        save.Click();
        Thread.Sleep(1000);
    }

    public bool checkEmpDetailsAdded()
    {
        bool b = false;
        List<IWebElement> tableData = new List<IWebElement>(empTable.FindElements(By.TagName("td")));
        for (int i = 0; i < tableData.Count; i++)
        {
            IWebElement td = tableData[i];
            string str1 = td.Text;
            if (str1 == "Philip")
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


