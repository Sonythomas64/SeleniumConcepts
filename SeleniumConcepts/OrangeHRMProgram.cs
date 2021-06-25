using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;


namespace SeleniumConcepts
{
    class OrangeHRMProgram

    {
       
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Window.Maximize();


            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();

            String currentURL = driver.Url;
            Console.WriteLine(currentURL);

            driver.FindElement(By.Id("menu_pim_viewMyDetails")).Click();
            driver.FindElement(By.Id("btnSave")).Click();

           
            driver.FindElement(By.LinkText("Emergency Contacts")).Click();
            driver.FindElement(By.Id("btnAddContact")).Click();

            driver.FindElement(By.Id("emgcontacts_name")).SendKeys("Ram Dev");
            driver.FindElement(By.Id("emgcontacts_relationship")).SendKeys("Brother");
            driver.FindElement(By.Id("emgcontacts_homePhone")).SendKeys(" 0481 257189");
            driver.FindElement(By.Id("emgcontacts_mobilePhone")).SendKeys("872572189");
            driver.FindElement(By.Id("emgcontacts_workPhone")).SendKeys("9856286221");

            driver.FindElement(By.Id("btnSaveEContact")).Click();

            Thread.Sleep(2000);

            driver.Quit();

        }
    }
}
