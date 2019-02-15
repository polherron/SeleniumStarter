using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Selenium;

namespace SeleniumMain
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver chromeDriver = GetChromeDriver();
            OpenPage(chromeDriver);

            IWebDriver ieDriver = getIEDriver();
            OpenPage(ieDriver);

            IWebDriver firefoxDriver = getFirefoxDriver();
            OpenPage(firefoxDriver);

        }

        private static IWebDriver getFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver(@"c:\libraries\");
            return driver;
        }

        private static IWebDriver getIEDriver()
        {
            var options = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true
            };
            IWebDriver driver = new InternetExplorerDriver(@"c:\libraries\",options);
            return driver;
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
