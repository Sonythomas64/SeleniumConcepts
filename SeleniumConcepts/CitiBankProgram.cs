using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class CitiBankProgram
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.online.citibank.co.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(10000);

            String parent = driver.CurrentWindowHandle;
            Console.WriteLine(parent);

            //driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.LinkText("Travel")).Click();
            driver.FindElement(By.Id("Email_Id")).SendKeys("bala@gmail.com");
            Thread.Sleep(4000);
            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);

            driver.Quit();

        }
    }
}