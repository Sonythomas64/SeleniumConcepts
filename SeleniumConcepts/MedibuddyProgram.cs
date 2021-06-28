



using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class MedibuddyProgram
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.medibuddy.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);

            
            By notNowLocator = By.Id("wzrk-cancel");
            IWebElement element = driver.FindElement(notNowLocator);
            element.Click();
            Thread.Sleep(10000);
            


            driver.FindElement(By.LinkText("Signup")).Click();
            Thread.Sleep(10000);

            driver.FindElement(By.Name("firstName")).SendKeys("Ram Dev");
            driver.FindElement(By.Name("phone")).SendKeys(" 0481257189");
            driver.FindElement(By.Name("username")).SendKeys("ram@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("ram12@");

            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("submitbtn")).Click();
            

            driver.Quit();

        }
    }
}
