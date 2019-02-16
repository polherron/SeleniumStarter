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
    public class HTMLExample
    {
        internal static void SelectTableCell(IWebDriver driver, string webURL)
        {
            driver.Url = webURL;
            //Get outer table
            var myOuterTable = driver.FindElements(By.TagName("table"))[0];
            //Get inner table
            var myInnerTable = myOuterTable.FindElement(By.TagName("table"));
            //Get the row
            var myTableRow = myInnerTable.FindElements(By.TagName("td"))[1];
            //Write value to console
            Console.WriteLine(myTableRow.Text);
        }

        internal static void SelectTableCellByXPath(IWebDriver driver, string webURL)
        {
            driver.Url = webURL;

            var row = driver.FindElement(By.XPath("//table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Console.WriteLine(row.Text);
        }

        //Tests Radio Buttons on TestPage.html
        internal static void SelectRadioButtons(IWebDriver driver, string url)
        {

            driver.Url = url;
            //Find the elements named color
            var radioButtons = driver.FindElements(By.Name("color"));
            //Selelct and click on the second button
            var radioButton = radioButtons[1];
            radioButton.Click();


            //Check which button is clicked and write its value to console

            foreach (var item in radioButtons)
            {
                if (item.Selected)
                {
                    Console.WriteLine(item.GetAttribute("value"));
                }
            }

        }


        //Tests Radio Buttons on TestPage.html
        public static bool SelectOptionDDL(IWebDriver driver, string url)
        {
            driver.Url = url;
            var checkbox = driver.FindElement(By.Id("select1"));
            var paulOption = checkbox.FindElements(By.TagName("option"))[1];
            paulOption.Click();
            if (paulOption.Text.Equals("Paul"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Tests Radio Buttons on TestPage.html
        internal static void SelectOptionDDLUsingSupport(IWebDriver driver, string url)
        {
            driver.Url = url;
            var select = driver.FindElement(By.Id("select1"));

            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Ringo");


        }

        //Tests Radio CheckBox on TestPage.html
        internal static void SelectCheckbox(IWebDriver driver, string url)
        {

            driver.Url = url;
            var checkbox = driver.FindElement(By.Id("checkbox"));
            //Click on the second buttonName
            checkbox.Click();
            Console.WriteLine(checkbox.GetAttribute("value"));

            //Check which button is clicked and write its value to console

            if (checkbox.Selected)
            {
                Console.WriteLine("Checkbox is selected");
            }

            //Now deselect the checkbox
            checkbox.Click();
            Console.WriteLine(checkbox.GetAttribute("value"));

            //Check which button is clicked and write its value to console

            if (!checkbox.Selected)
            {
                Console.WriteLine("Checkbox is not selected");
            }


            Console.ReadLine();
        }
    }
}
