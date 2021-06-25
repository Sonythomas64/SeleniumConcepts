using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class RedBusProgram
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.redbus.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(10000);


            driver.FindElement(By.Id("signin-block")).Click();
            driver.FindElement(By.Id("signInLink")).Click();
            Thread.Sleep(10000);

            driver.SwitchTo().Frame(1);
            
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[4]/div[3]/input")).SendKeys("787878");
            Thread.Sleep(10000);

            driver.Quit();

        }
    }
}