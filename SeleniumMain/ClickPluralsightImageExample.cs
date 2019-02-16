
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;


namespace SeleniumMain
{
    class ClickPluralsightImageExample
    {
        internal static void DoSearch(IWebDriver driver, string url)
        {
            //var searchTextBox = driver.FindElement(By.ClassName("gLFyf "));
            driver.Url = url;

            //Locate the search text box
            var searchTextBox = driver.FindElement(By.Name("q"));

            //Send text to the text box
            searchTextBox.SendKeys("pluralsight");

             //Wait for image to be visible
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible
                (By.Name("btnK")));
            //Find  click the search button
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Click();

            //Find the images link and clck
            var imagesLink = driver.FindElement(By.LinkText("Images"));
            imagesLink.Click();

            //Wait for image to be visible
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible
               (By.Id("S3_A4SCQnV83UM:")));
            //Locate and click the image
            var image = driver.FindElement(By.Id("S3_A4SCQnV83UM:"));
            image.Click();
        }
    }
}
