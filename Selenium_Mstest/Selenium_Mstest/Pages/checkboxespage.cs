using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Mstest.Pages
{
    public class checkboxespage
    {
        
        protected readonly IWebDriver driver;
        protected By checkbox1 = By.XPath("(//input[@type='checkbox'])[1]");
        protected By checkbox2 = By.XPath(" //input[@type='checkbox'][2]");
        public checkboxespage(IWebDriver driver)
        {
            this.driver = driver;
        }

       //Locators
      
       
        public IWebElement GetCheckbox1()
        {
            return driver.FindElement(checkbox1);
        }

        public IWebElement GetCheckbox2()
        {
            return driver.FindElement(checkbox2);
        }

        public void clickmaincheck()
        {
            IWebElement checkbox = driver.FindElement(By.XPath("//a[text()='Checkboxes']"));
            checkbox.Click();
        }
        public bool clickcheckbox(IWebElement element)
        {
            
            element.Click();
            bool check = element.Selected;
            return check;

        }
    }
}
