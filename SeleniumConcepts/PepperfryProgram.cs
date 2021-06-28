using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class PepperfryProgram
    {
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.pepperfry.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            /*
             * Thread.Sleep(5000);
            IWebElement frameElement = driver.FindElement(By.XPath("//iframe[contains(@title,'notification-frame')]"));
            driver.SwitchTo().Frame(frameElement);


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement closeIcon = driver.FindElement(By.XPath("//div[@class='close']"));
            closeIcon.Click();
                    
            //driver.FindElement(By.Id("webklipper-publisher-widget-container-notification-close-div")).Click();
            driver.SwitchTo().DefaultContent();
            */

            driver.FindElement(By.Id("search")).SendKeys("bedsheets");
            
            driver.FindElement(By.Id("searchButton")).Click();

            IJavaScriptExecutor j = (IJavaScriptExecutor)driver;
            j.ExecuteScript("window.scrollBy(0,500)");


            driver.FindElement(By.XPath("//label[@for='brandsnameSleep_Dove']")).Click();

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@unbxdattr='product']"))).Click().Build().Perform();

            //driver.FindElement(By.ClassName("clip-add-to-cart-btn")).Click();
                        
            driver.FindElement(By.XPath("//*[contains(text(),'Add To Cart')]")).Click();

            driver.FindElement(By.XPath("//*[contains(text(),'Proceed to pay securely')]")).Click();

            j.ExecuteScript("window.scrollBy(0,500)");
            driver.FindElement(By.XPath("//*[contains(text(),'PLACE ORDER')]")).Click();
                                                
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Dennis Richie");
            driver.FindElement(By.XPath("//input[@id='postcode']")).SendKeys("");
            driver.FindElement(By.XPath("//textarea[@id='street']")).SendKeys("Ellil house");
                        
            SelectElement address = new SelectElement(driver.FindElement(By.XPath("//select[@id='region']")));
            address.SelectByText("Kerala");
                        
            driver.FindElement(By.XPath("//button[@id='btn_guestform_save_shipping']")).Click();
            
            //driver.Quit();

        }
    }
}