using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Extensions;

namespace EAEmployeeTest.Pages
{
    public class ManageUsers
    {

        private IWebDriver Driver;

        public ManageUsers(IWebDriver driver)

        {
            Driver = driver;
        }



       

         public IWebElement lnkManageUsers => Driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li:nth-child(5) > a"));


        public IWebElement lnkDropDown => Driver.FindElement(By.CssSelector("body > div.container.body-content > table > tbody > tr:nth-child(3) > td:nth-child(3)"));





        public void ClickManageUsers()
        {
           lnkManageUsers.Click();
           // lnkDropDown.GetSelectedListOptions();
            

        }

        internal static void GetSelectedDropDown()
        {
           
        }
    }
}




