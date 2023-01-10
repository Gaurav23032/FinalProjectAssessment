using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_Bank.Base;
using XYZ_Bank.Utilities;

namespace XYZ_Bank
{
    public class CustomerTest: AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]

        public void AddValidCustomer(string UserFirstName,string UserLastName,string UserPostCode,string fullname)
        {
            driver.FindElement(By.XPath("//button[text()='Bank Manager Login']")).Click();
            driver.FindElement(By.XPath("//button[@ng-class='btnClass1']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(UserFirstName);
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(UserLastName);
            driver.FindElement(By.XPath("//input[@placeholder='Post Code']")).SendKeys(UserPostCode);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);
        
        
            driver.FindElement(By.XPath("//button[@ng-class='btnClass2']")).Click();
            Thread.Sleep(1000);

            SelectElement select1 = new SelectElement(driver.FindElement(By.Name("userSelect")));
            select1.SelectByText(fullname);
            Thread.Sleep(1000);
            SelectElement select2 = new SelectElement(driver.FindElement(By.Name("currency")));
            select2.SelectByValue("Rupee");

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Process']")).Click();

            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.XPath("//button[text()='Home']")).Click();

            driver.FindElement(By.XPath("//button[text()='Customer Login']")).Click();

            SelectElement select3 = new SelectElement(driver.FindElement(By.Id("userSelect")));
            select3.SelectByText(fullname);

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();


            driver.FindElement(By.XPath("//button[@ng-class='btnClass2']")).Click();


            driver.FindElement(By.XPath("//input[@placeholder='amount']")).SendKeys("2000");

            driver.FindElement(By.XPath("//button[text()='Deposit']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@ng-click='transactions()']")).Click();

            string Actualtextprint =driver.FindElement(By.XPath("//span[text()='Deposit Successful']")).Text;

            Console.WriteLine(Actualtextprint);

         

            driver.FindElement(By.XPath("//button[@ng-class='btnClass3']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='amount']")).SendKeys("2500");

            driver.FindElement(By.XPath("//button[text()='Withdraw']")).Click();

           string ErrorMessage = driver.FindElement(By.XPath("//span[text()='Transaction Failed. You can not withdraw amount more than the balance.']")).Text;
            Console.WriteLine(ErrorMessage);

            driver.FindElement(By.XPath("//input[@placeholder='amount']")).SendKeys("8000");
            driver.FindElement(By.XPath("//button[text()='Withdraw']")).Click();

            string Message = driver.FindElement(By.XPath("//span[text()='Transaction successful']")).Text;
            Console.WriteLine(Message);

            driver.FindElement(By.XPath("//button[@ng-show='logout']")).Click();


        }
    }
}
