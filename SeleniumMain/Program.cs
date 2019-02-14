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

            OpenPage();

        }

        public static void OpenPage()
        {
            IWebDriver driver = new ChromeDriver(@"c:\libraries\");
            driver.Url = "http://www.google.com";
        }
    }
}
