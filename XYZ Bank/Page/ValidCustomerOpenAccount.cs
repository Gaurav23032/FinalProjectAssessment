using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace XYZ_Bank.Page
{
    public  class ValidCustomerOpenAccount
    {
        private By _FullNamelocater = By.Name("userSelect");
        private By _Moneylocator = By.XPath("//button[@type='submit']");
        private By _Processlocater = By.XPath("//button[text()='Process']");

        private IWebDriver driver;
        public ValidCustomerOpenAccount(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterFullName(string fullname)
        {
            //driver.FindElement(_FullNamelocater).SendKeys(fullname);

            SelectElement select1 = new SelectElement(driver.FindElement(_FullNamelocater));
             select1.SelectByText(fullname);
        }

        public void EnterMoney(string Money)
        {
            driver.FindElement(_Moneylocator).SendKeys(Money);
        }
        public void EnterSubmit()
        {
            driver.FindElement(_Processlocater).Click();
        }
    }
}*/
