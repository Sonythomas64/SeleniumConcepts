using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class EchoEchoProgram
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "http://www.echoecho.com/javascript4.htm";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(10000);

            driver.FindElement(By.Name("B1")).Click();

            String alerttext = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alerttext);

            driver.SwitchTo().Alert().Accept();
            
            driver.Quit();

        }
    }
}