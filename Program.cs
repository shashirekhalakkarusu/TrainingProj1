using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //launch chrome web browser
            IWebDriver driver = new ChromeDriver();

            //Enter the URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //Maximise the window
            driver.Manage().Window.Maximize();

            //Enter the Username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Enter the Password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Click on login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();

            /*IWebElement helloHariHome = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            //IWebElement Administrator = driver.FindElement(By.XPath();


            //SelectElement Time = new SelectElement(Administrator);

            //Time.SelectByText("Time & Materials");



            //selenium.click("xpath=//a[contains(@href,'#') and text='Administration']");
            var Administrator = driver.FindElement(By.XPath("//li[@class= 'dropdown - toggle' and text()= 'Administration']"));*/

            // Administrator.SelectByText("Time & Materials")

            //To

            IWebElement Administrator = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));

            Administrator.Click();
            IWebElement Timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));

            Timeandmaterial.Click();

            /*IWebElement CreaterecordButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreaterecordButton.Click();

            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            //TypeCode.Click();*/

            //var Time = driver.FindElement(By.XPath("//li[@class= 'k-item' and text()= 'Time']"));
            //Time.Click();

            /* IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("BBB");

            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("testdesc");


            IWebElement Priceperunit= driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Priceperunit.SendKeys("200");

            IWebElement SButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SButton.Click();*/



            // IWebElement row1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]"));

            //IWebElement EditButton = driver.FindElement(By.XPath("[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));

            Thread.Sleep(1000);

            // driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            //EDIT

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();
            //DELETE

           // driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]")).Click();





            























        }
    }
}
