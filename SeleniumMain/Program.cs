using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Selenium;

namespace SeleniumMain
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver chromeDriver = GetChromeDriver();
           
            OpenPage(chromeDriver, "https://www.google.com/");
            DoSearch(chromeDriver);
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(@"c:\libraries\");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }

        public static void OpenPage(IWebDriver driver, string url)
        {
            driver.Url = url;
        }

        private static void DoSearch(IWebDriver driver)
        {
            //var searchTextBox = driver.FindElement(By.ClassName("gLFyf "));

            //Locate the search text box
            var searchTextBox = driver.FindElement(By.Name("q"));

            //Send text to the text box
            searchTextBox.SendKeys("pluralsight");

            //Find nad click the search button
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Click();

            //Find the images link and clck
            var imagesLink = driver.FindElement(By.LinkText("Images"));
            imagesLink.Click();
            

            //Wait for image to be visible
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible
                (By.ClassName(string.Format("rg_ic"))));

            /*driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);*/

            //Locate and click the image
            var image = driver.FindElements(By.ClassName("rg_ic"))[0];
            image.Click();
        }

    }
}
