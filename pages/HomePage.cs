using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.pages
{
    class HomePage
    {
        //Function to navigate to TMPaage
        public void navigateToTM(IWebDriver driver)
        {
            //Navigate to Time and Material page
            IWebElement Administrator = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));

            Administrator.Click();
            IWebElement Timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));

            Timeandmaterial.Click();
        }

        internal void navigateToTM()
        {
            throw new NotImplementedException();
        }
    }
}
