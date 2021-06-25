using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class HDFCNetBankingProgram
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(10000);



            // driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            driver.SwitchTo().Frame("login_page");
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("text123");

            driver.FindElement(By.XPath("//img[@alt='continue']")).Click();

            driver.SwitchTo().DefaultContent();
            driver.Quit();

        }
    }
}