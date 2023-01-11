using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Bank.Page
{
    public class AddValidCustomerPage
    {
        private By _Firstnamelocator = By.XPath("//input[@placeholder='First Name']");
        private By _LastNamelocator = By.XPath("//input[@placeholder='Last Name']");
        private By _PostCodelocator = By.XPath("//input[@placeholder='Post Code']");
        private By _loginlocator = By.XPath("//button[@type='submit']");

        private IWebDriver driver;
        public AddValidCustomerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Enterfirstname(string UserFirstName)
        {
            driver.FindElement(_Firstnamelocator).SendKeys(UserFirstName);
        }

        public void Enterlastname(string UserLastName)
        {
            driver.FindElement(_LastNamelocator).SendKeys(UserLastName);
        }

        public void Enterpincode(string UserPostCode)
        {
            driver.FindElement(_PostCodelocator).SendKeys(UserPostCode);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(_loginlocator).Click();
        }
    }
}
