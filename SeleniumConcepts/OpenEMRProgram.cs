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
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
           // FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://eight.openemr.io/openemr/interface/login/login.php?site=default";
            driver.Manage().Window.Maximize();

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            select.SelectByText("English (Indian)");
                                    
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
                      

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@class='menuLabel dropdown-toggle oe-dropdown-toggle']"))).Click().Build().Perform();


            driver.FindElement(By.XPath("//*[@id='mainMenu']/div/div[5]/div/ul/li[1]/div")).Click();
            driver.SwitchTo().Frame("fin");
            driver.FindElement(By.Id("create_patient_btn1")).Click();
            driver.SwitchTo().DefaultContent();
            
            driver.SwitchTo().Frame("pat");
                                    
            SelectElement select1 = new SelectElement(driver.FindElement(By.XPath("//*[@id='form_title']")));
            select1.SelectByText("Mr.");

            driver.FindElement(By.XPath("//*[@id='form_fname']")).SendKeys("Jerin");
            driver.FindElement(By.XPath("//*[@id='form_mname']")).SendKeys("John");
            driver.FindElement(By.XPath("//*[@id='form_lname']")).SendKeys("Joseph");
            driver.FindElement(By.XPath("//*[@id='form_DOB']")).SendKeys("2021-06-27");

            SelectElement select2 = new SelectElement(driver.FindElement(By.XPath("//*[@id='form_sex']")));
            select2.SelectByText("Male");
                        
            driver.FindElement(By.XPath("//button[contains(text(),'Create New Patient')]")).Click();
            driver.SwitchTo().DefaultContent();
            //driver.SwitchTo().Frame("logoutinnerframe");
            //*[@id="searchResultsHeader"]/center/input

            //driver.SwitchTo().Frame("logoutinnerframe");
            driver.SwitchTo().Frame("modalframe");
            driver.FindElement(By.ClassName("body_top")).Click();

            
            driver.SwitchTo().Frame("pat");
            //string text = driver.FindElement(By.XPath("//p[@class = 'h2']")).Text;
            string text = driver.FindElement(By.Id("reminder_popup_link")).Text;
            
            Console.WriteLine(text);

            // driver.FindElement(By.XPath("//div[@class = 'closeDlgIframe']")).Click();
                                                
            string text2 = driver.FindElement(By.XPath("//*[@class = 'clearfix' and //*[h2[contains(text(),'Medical Record Dashboard')]]]")).Text;

            Console.WriteLine(text2);


            Thread.Sleep(5000);

            driver.Quit();

        }
    }
}



