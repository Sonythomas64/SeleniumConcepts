using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class DataTableProgram
    {
        static void Main1(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //InternetExplorerDriver driver = new InternetExplorerDriver();
            IWebDriver driver = new FirefoxDriver();
            //int totalsalary = 0;
            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);



            

            driver.FindElement(By.XPath("//*[@id='example_length']/label/select/option[3]")).Click();
            
            for(int i=1; i <= 50; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;

                string salary = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[6]")).ToString();
               
                //int salary1 = int.Parse(salary);

               // totalsalary = salary1 + totalsalary;
                Console.WriteLine("Salary of " +name+ " is: " +salary);
            }
            //Console.WriteLine("Total Salary is: " + totalsalary);







            driver.Quit();

        }
    }
}