using OpenQA.Selenium;
using Selenium_Mstest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Mstest.Tests
{
    [TestClass]
    public class SmokeTest :BaseTest
    {
        [TestMethod]
        public async Task SelectCheckBox()
        {
            
            chk.clickmaincheck();
            bool isselected= chk.clickcheckbox(chk.GetCheckbox1());
            Assert.IsTrue(isselected, "checkbox not selected");
        }

        [TestMethod]
        public void Iframe()
        {
            FramePage.GetMainIframeLocator().Click();
            FramePage.GetIframeLocator().Click();
           
            IWebElement framelocator = driver.FindElement(By.Id("mce_0_ifr"));
            driver.SwitchTo().Frame(framelocator);
            bool isvisible = driver.FindElement(By.XPath("//p[text()='Your content goes here.']")).Displayed;
            Assert.IsTrue(isvisible, "not visible");

            //driver.FindElement(By.Id("//div[@aria-label='Close']")).Click();



        }
    }
}
