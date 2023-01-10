using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_Bank.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            string browserName = "";
            if (browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browserName.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login";


        }

        [TearDown]
        public void AfterMethod()
        {

           // driver.Quit();
        }


    }
}

    

