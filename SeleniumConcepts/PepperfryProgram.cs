using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class PepperfryProgram
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.pepperfry.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);

            IWebElement frameElement = driver.FindElement(By.XPath("//iframe[contains(@title,'notification-frame')]"));
            driver.SwitchTo().Frame(frameElement);


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement closeIcon = driver.FindElement(By.XPath("//div[@class='close']"));
            closeIcon.Click();
                    
            //driver.FindElement(By.Id("webklipper-publisher-widget-container-notification-close-div")).Click();
            driver.SwitchTo().DefaultContent();

            
            
            driver.FindElement(By.Id("search")).SendKeys("bedsheets");
            
            driver.FindElement(By.Id("searchButton")).Click();

            IJavaScriptExecutor j = (IJavaScriptExecutor)driver;
            j.ExecuteScript("window.scrollBy(0,500)");


            driver.FindElement(By.XPath("//label[@for='brandsnameSleep_Dove']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), '100% Cotton 300TC King Size Bedsheet With 2 Pillow')]")).Click();
            

            //driver.FindElement(By.LinkText("100% Cotton 300TC King Size Bedsheet With 2 Pillow Covers")).Click();


            /*
             * OpenQA.Selenium.StaleElementReferenceException: 'stale element reference: element is not attached to the page document
                (Session info: chrome=91.0.4472.114)'
             */



            //driver.Quit();

        }
    }
}