using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using XYZ_Bank.Base;
using XYZ_Bank.Page;
using XYZ_Bank.Utilities;

namespace XYZ_Bank
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest1()
        {
            string actualtitle = driver.FindElement(By.XPath("//strong[text()='XYZ Bank']")).Text;
            Console.WriteLine(actualtitle);

            string Home = driver.FindElement(By.XPath("//button[text()='Home']")).Text;

            Console.WriteLine(Home);

            String Login = driver.FindElement(By.XPath("//button[text()='Customer Login']")).Text;
            Console.WriteLine(Login);

            string BankLogin = driver.FindElement(By.XPath("//button[text()='Bank Manager Login']")).Text;
            Console.WriteLine(BankLogin);
        }
        //[Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidBankManagerLogin))]
        public void AddValidCustomer(string UserFirstName, string UserLastName, string UserPostCode)
        {
            driver.FindElement(By.XPath("//button[text()='Bank Manager Login']")).Click();
           driver.FindElement(By.XPath("//button[@ng-class='btnClass1']")).Click();
            // driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(UserFirstName);
            //driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(UserLastName);
            //driver.FindElement(By.XPath("//input[@placeholder='Post Code']")).SendKeys(UserPostCode);
            //driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            AddValidCustomerPage ValidLogin = new AddValidCustomerPage(driver);
           
            ValidLogin.Enterfirstname(UserFirstName);
            ValidLogin.Enterlastname(UserLastName);
            ValidLogin.Enterpincode(UserPostCode);
            ValidLogin.ClickOnLogin();
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.CustomerInfo))]
        public void OpenAccount(string fullname,string Money)
        {
            driver.FindElement(By.XPath("//button[text()='Bank Manager Login']")).Click();
            driver.FindElement(By.XPath("//button[@ng-class='btnClass2']")).Click();
            Thread.Sleep(1000);
            SelectElement select1 = new SelectElement(driver.FindElement(By.Name("userSelect")));
            select1.SelectByText(fullname);
            Thread.Sleep(1000);
            SelectElement select2 = new SelectElement(driver.FindElement(By.Name("currency")));
            select2.SelectByValue(Money);
            driver.FindElement(By.XPath("//button[text()='Process']")).Click();


            /*BankManagerOpenAccount OpenAccont = new BankManagerOpenAccount(driver);
            OpenAccont.En(fullname);
            OpenAccont.EnterMoney(Money);
            OpenAccont.EnterSubmit();*/

            /*
            */

        }
    }
}


