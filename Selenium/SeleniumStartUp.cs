using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Selenium
{
    public class SeleniumStartUp
    {
        public static void OpenPage()
        {
            IWebDriver driver = new ChromeDriver(@"c:\libraries\");
            driver.Url = "http://www.google.com";
            
        }
    }
}
