using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using EAAutoFramework.Config;
using OpenQA.Selenium.Support.UI;
using EAAutoFramework.Extensions;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        
        
        
        private IWebDriver Driver;

        [TestMethod]
        public void TestMethod1()
        {

            ConfigReader.SetFrameworkSettings();
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Settings.AUT);
            //Login();




            LoginPage page = new LoginPage(Driver);
            page.ClickLogin();
            page.Login("admin", "password");
           //page.CheckIfLoginExists();
            EmployeePage employeePage = new EmployeePage(Driver);
            //employeePage.CheckIfEmployeeListExists();
            //employeePage.CheckIfSearchExists();

            employeePage.EmployeeList();
           // employeePage.CheckIfSearchExists();

            //employeePage.CheckIfCreateNewExists();
            employeePage.ClickCreateNew();

            ManageUsers mangePage = new ManageUsers(Driver);
            mangePage.ClickManageUsers();
            //ManageUsers.GetSelectedDropDown();

            //WebElementExtensions man = new WebElementExtensions();


        }
        // public void Login()
        //{
       // LoginPage page = new LoginPage(Driver);
       // page.ClickLogin();
         //   page.Login("admin", "password");

          //  EmployeePage employeePage = new EmployeePage(Driver);

      //  employeePage.EmployeeList();

          // EmployeePage employeePage = new EmployeePage(Driver);

            //Driver.FindElement(By.CssSelector("#loginLink")).Click();
          //  IWebElement user = Driver.FindElement(By.CssSelector("#UserName"));
           //user.SendKeys("admin");
           // IWebElement pass = Driver.FindElement(By.CssSelector("#Password"));
           // pass.SendKeys("password");
           // IWebElement log = Driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input"));
          // log.Submit();

           // page2.buttonEmployee.Click();
        //Driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li:nth-child(3) > a")).Click();

       // IWebElement txtS = Driver.FindElement(By.Name("searchTerm"));
         //   txtS.SendKeys("test");
            
           // empPage.txtSearchbutton.Click();





       // }
    }
}
