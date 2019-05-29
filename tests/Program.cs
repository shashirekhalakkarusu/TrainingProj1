using OpenQA.Selenium.Chrome;
using project1.helpers;
using project1.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.tests
{
    class Program
    {
        public void Login()
        {
            CommonDriver.driver = new ChromeDriver();

            //Steps to login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(CommonDriver.driver);

            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);

            TMPage tmObj = new TMPage();
            tmObj.addTM(CommonDriver.driver);




        }

    }
}
