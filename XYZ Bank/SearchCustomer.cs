using DocumentFormat.OpenXml.Drawing.Charts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_Bank.Base;

namespace XYZ_Bank
{
    public class SearchCustomer : AutomationWrapper
    {
        [Test]
        public void customer()
        {
        driver.FindElement(By.XPath("//button[text()='Bank Manager Login']")).Click();
            driver.FindElement(By.XPath("//button[@ng-class='btnClass3']")).Click();
            string Attribute = driver.FindElement(By.XPath("//input[@placeholder='Search Customer']")).GetAttribute("placeholder");
            Console.WriteLine(Attribute);
            driver.FindElement(By.XPath("//input[@placeholder='Search Customer']")).SendKeys("Neville"); 
           // driver.FindElement(By.XPath(""))
        }
        [Test]
        public void EnterNewCustomer()
        {
            driver.FindElement(By.XPath("//button[text()='Customer Login']")).Click();
            SelectElement select3 = new SelectElement(driver.FindElement(By.Id("userSelect")));
            select3.SelectByText("Albus Dumbledore");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();
           string  welcomeText=driver.FindElement(By.XPath("//strong[text()=' Welcome ']")).Text;
            Console.WriteLine(welcomeText);
          string  NameOfCustomer=driver.FindElement(By.XPath("//span[text()='Albus Dumbledore']")).Text;
            Console.WriteLine(NameOfCustomer);

           string CustomerAccountInfo=driver.FindElement(By.XPath("//div[@ng-hide='noAccount']")).Text;
           Console.WriteLine(CustomerAccountInfo);

          string  TransectionText=driver.FindElement(By.XPath("//button[@ng-click='transactions()']")).Text;
            Console.WriteLine(TransectionText);

            string DepositButton=driver.FindElement(By.XPath("//button[@ng-class='btnClass2']")).Text;
            Console.WriteLine(DepositButton);
            string CashWithDrawDetails=driver.FindElement(By.XPath("//button[@ng-class='btnClass3']")).Text;
            Console.WriteLine(CashWithDrawDetails);


        }
    }
}
     
            

        
    
