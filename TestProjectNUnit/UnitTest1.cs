using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumMain;

namespace Tests
{
    public class Tests
    {
        string webURL = @"file:///C:/Users/Paul/Source/Repos/Selenium/SeleniumMain/Default.html";
        IWebDriver driver = new ChromeDriver(@"C:\libraries\");


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSelectOption()
        {
            bool result = HTMLExample.SelectOptionDDL(driver, webURL);
            Assert.True(result);
        }
    }
}