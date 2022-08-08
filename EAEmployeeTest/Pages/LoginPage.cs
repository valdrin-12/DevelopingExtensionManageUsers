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
    public class LoginPage
    {

          private IWebDriver Driver;

        public LoginPage(IWebDriver driver)

        {
              Driver = driver;
        }



        //public LoginPage(RemoteWebDriver driver) => _driver = driver;

        public IWebElement loginhonme => Driver.FindElement(By.CssSelector("#loginLink"));


        public IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        internal void CheckIfLoginExists()
        {
            txtUserName.AssertElementPresent(); 
        }

        public IWebElement btnLogin => Driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input"));


        public void Login(string userName ,string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);

            btnLogin.Submit();

        }


        public void ClickLogin()
        {
            loginhonme.Click();
          //  loginhonme.SelectDropDownList;

            //loginhonme.AssertElementPresent

        }

        

    }
}
