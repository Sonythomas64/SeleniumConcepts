using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;


namespace SeleniumConcepts
{
    class MagentoConceptsProgram

    {

        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://magento.com/";
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            
            driver.FindElement(By.LinkText("Sign in")).Click();

            driver.FindElement(By.Id("email")).SendKeys("balaji0017@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("balaji@12345");
                     
            driver.FindElement(By.Id("send2")).Click();

            String currentTitle = driver.Title;
            Console.WriteLine(currentTitle);

            Thread.Sleep(10000);

            driver.FindElement(By.LinkText("Log Out")).Click();



            driver.Quit();

        }
    }
}
