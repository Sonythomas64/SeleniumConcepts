


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class RoyalCaribbeanProgram
    {
        static void Main12(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();
                       

            driver.Url = "https://www.royalcaribbean.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            
            driver.FindElement(By.XPath("//*[@class='email-capture__close']")).Click();
            driver.FindElement(By.Id("rciHeaderSignIn")).Click();

            driver.FindElement(By.XPath("//a[@class='login__create-account login__create-account--royal']")).Click();

            driver.FindElement(By.XPath("//*[@data-placeholder='First name/Given name']")).SendKeys("Dennis");
            driver.FindElement(By.XPath("//*[@data-placeholder='Last name/Surname']")).SendKeys("Rich");

            driver.FindElement(By.XPath("//span[(text() ='Month')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),' April ')]")).Click();

            driver.FindElement(By.XPath("//span[(text() ='Day')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(), '4 ')]")).Click();

            driver.FindElement(By.XPath("//*[@data-placeholder= 'Year']")).SendKeys("1990");

            driver.FindElement(By.XPath("//*[(text() ='Country/Region of residence')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(), 'India ')]")).Click();

            driver.FindElement(By.XPath("//input[@id='mat-input-2']")).SendKeys("bala123@gmail.com");
            driver.FindElement(By.XPath("//*[@data-placeholder='Create new password']")).SendKeys("bala123@@");

            driver.FindElement(By.XPath("//*[text()='Select one security question']")).Click();
            driver.FindElement(By.XPath("//*[@id='mat-option-298' ]")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).SendKeys("Maruthi Suzuki");



            //*[@aria-label='I have read and agree to the Terms of Use and Privacy Policy']
            
            //*[@class='input - checkbox__container']
            driver.FindElement(By.XPath("//*[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']")).Click();
            driver.FindElement(By.XPath("//*[@class='mat-royal-button btn-create']")).Click();
         

            driver.Close();

        }
    }
}