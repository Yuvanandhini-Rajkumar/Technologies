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
        public checkboxespage chk;
        [TestInitialize]
        public void Login()
        {
           driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            PageInitialization();

        }

        public void PageInitialization()
        {
             chk = new checkboxespage(driver);
        }

        [TestCleanup]
        public void Logout()
        {
            driver.Close();

        }
    }
}
