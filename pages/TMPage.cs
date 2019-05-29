using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project1.pages
{
    class TMPage
    {
        //Function to crete TM
        public void addTM(IWebDriver driver)
        {
            //Create a new time and material

            //Click on create new button
            IWebElement CreaterecordButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreaterecordButton.Click();

            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            //TypeCode.Click();*/

//var Time = driver.FindElement(By.XPath("//li[@class= 'k-item' and text()= 'Time']"));
//Time.Click();

            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("BBB");

            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("testdesc");


           IWebElement Priceperunit= driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
           Priceperunit.SendKeys("200");

            IWebElement SButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
           SButton.Click();

           Thread.Sleep(1000);

//Verify the creation of time and material record

//Navigate to the last page
           driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

          /* IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]"));

            if (actualCode.Text == "testCode")
            {
            Console.WriteLine("Test Passed, material created successully");
            }
            else
            {
              Console.WriteLine("Test Failed!");
            }*/
        }


    }

}
