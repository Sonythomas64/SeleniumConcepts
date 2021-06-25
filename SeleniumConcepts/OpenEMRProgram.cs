



using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class OpenEMRProgram
    {
        static void Main(string[] args)
        {
            //ChromeDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://eight.openemr.io/openemr/interface/login/login.php?site=default";
            driver.Manage().Window.Maximize();
            

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");

            
            //driver.FindElement(By.XPath("//*[@class='btn btn-secondary nothanks']")).Click();

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@class='menuLabel dropdown-toggle oe-dropdown-toggle']"))).Click().Build().Perform();


            driver.FindElement(By.XPath("//*[@id='mainMenu']/div/div[5]/div/ul/li[1]/div")).Click();
            driver.SwitchTo().Frame("fin");
            driver.FindElement(By.Id("create_patient_btn1")).Click();
            //driver.FindElement(By.Id("form_title")).Click();
            //driver.FindElement(By.XPath("//*[@value='Mr.']")).Click();

            driver.SwitchTo().Frame(1);

            SelectElement select1 = new SelectElement(driver.FindElement(By.XPath("//*[@id='form_title']")));
            select1.SelectByText("Mr.");

            driver.SwitchTo().DefaultContent();



            Thread.Sleep(5000);

            //driver.Quit();

        }
    }
}



