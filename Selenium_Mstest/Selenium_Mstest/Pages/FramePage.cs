using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Mstest.Pages
{
   public class FramePage
    {
        private readonly IWebDriver driver;
        private By mainiframelocator = By.XPath("//a[text()='Frames']");
        private By iframelocator = By.XPath("//a[text()='iFrame']");
        public FramePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetMainIframeLocator()
        {
            return driver.FindElement(mainiframelocator);
        }

        public IWebElement GetIframeLocator()
        {
            return driver.FindElement(iframelocator);
        }


    }
}
