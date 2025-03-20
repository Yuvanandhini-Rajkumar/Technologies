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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            chk.clickmaincheck();
            bool isselected= chk.clickcheckbox(chk.GetCheckbox1());
            Assert.IsTrue(isselected, "checkbox not selected");
        }
    }
}
