using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Mstest.Pages;
using System.Diagnostics.Contracts;

namespace Selenium_Mstest.Tests
{
    [TestClass]
    public class BaseTest
    {
        public required IWebDriver driver;
        protected checkboxespage chk;
        protected FramePage FramePage;
        
        [TestInitialize]
        public void Login()
        {
           driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            PageInitialization();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

        }

        public void PageInitialization()
        {
             chk = new checkboxespage(driver);
            FramePage = new FramePage(driver);
        }

        [TestCleanup]
        public void Logout()
        {
            driver.Close();

        }
    }
}
