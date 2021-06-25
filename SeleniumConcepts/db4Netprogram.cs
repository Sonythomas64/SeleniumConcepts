using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class db4Netprogram
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.db4free.net/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);

                       
            driver.FindElement(By.LinkText("phpMyAdmin »")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("db123");

            driver.FindElement(By.Id("input_password")).SendKeys("test123");

            
            driver.FindElement(By.Id("input_go")).Click();
            String errorText = driver.FindElement(By.XPath("(//div[@role='alert'])[2]")).Text;
            //(By.ClassName("ic_s_error"))
            Console.WriteLine("Error message is: "+ errorText);


            driver.Close();

        }
    }
}