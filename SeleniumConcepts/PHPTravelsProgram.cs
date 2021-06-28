


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class PHPTravelsProgram
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();


            driver.Url = "https://phptravels.net/home";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            driver.FindElement(By.XPath("//a[@class='text-center flights  active']")).Click();
            





           // driver.Quit();

        }
    }
}