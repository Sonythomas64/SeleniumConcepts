


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class StarbucksProgram
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();


            driver.Url = "https://www.starbucks.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            driver.FindElement(By.XPath("//*[contains(text(),'Menu')]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'Sweet Bakery')]")).Click();
          
            driver.Quit();

        }
    }
}