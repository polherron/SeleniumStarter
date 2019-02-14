using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium;

namespace SeleniumMain
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver chromeDriver = GetChromeDriver();
            OpenPage(chromeDriver);
            System.Threading.Thread.Sleep(5000);
            CloseBrowser(chromeDriver);

        }

        private static void CloseBrowser(IWebDriver driver)
        {
            driver.Close();
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(@"c:\libraries\");
            return driver;
        }

        public static void OpenPage(IWebDriver driver)
        {
            driver.Url = "http://www.google.com";
        }
    }
}
