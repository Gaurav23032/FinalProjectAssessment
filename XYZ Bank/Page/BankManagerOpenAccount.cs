using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Bank.Page
{
    public class BankManagerOpenAccount
    {
        private IWebDriver driver;
        public BankManagerOpenAccount(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
