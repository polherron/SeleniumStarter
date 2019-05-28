using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;

namespace SeleniumMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string webURL = @"file:///C:/Users/Paul/Source/Repos/Selenium/SeleniumMain/Default.html";
            IWebDriver driver = new ChromeDriver(@"C:\libraries\");

            //ClickPluralsightImageExample.DoSearch(driver, googleUrl);
            HTMLExample.SelectRadioButtons(driver, webURL);
            HTMLExample.SelectOptionDDL(driver, webURL);
            HTMLExample.SelectOptionDDLUsingSupport(driver, webURL);
            HTMLExample.SelectTableCell(driver, webURL);
            HTMLExample.SelectTableCellByXPath(driver, webURL);
            //PluralsightTestWithExpicitWait(driver, webURL);*/

            Console.ReadLine();

            driver.Close();

        }

     
        }

    }
