using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace SeleniumConcepts
{
    class Program
    {
        static void Main9(string[] args)
        {
            //ChromeDriver driver = new ChromeDriver();
            InternetExplorerDriver driver = new InternetExplorerDriver();
            //FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "https://google.com";

            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            String actualURL = driver.Url;
            Console.WriteLine(actualURL);

            driver.Quit();

        }
    }
}
