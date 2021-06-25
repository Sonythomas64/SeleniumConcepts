using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumConcepts
{
    class GotoMeetingProgram
    {
        static void Main6(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://www.gotomeeting.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Thread.Sleep(10000);

            driver.FindElement(By.LinkText("Start for Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Amal");
            driver.FindElement(By.Id("last-name")).SendKeys("Saji");
            driver.FindElement(By.Id("login__email")).SendKeys("amal@gmail.com");
            driver.FindElement(By.Id("truste - consent - button")).Click();

            driver.FindElement(By.Id("contact - number")).SendKeys("986778884");

            SelectElement select = new SelectElement(driver.FindElement(By.Name("JobTitle")));
            select.SelectByText("Help Desk");

            driver.FindElement(By.Id("login__password")).SendKeys("amal&43");


            driver.FindElement(By.XPath("//input[@value='10 - 99']"));

            driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();









            Thread.Sleep(5000);







            driver.Quit();

        }
    }
}