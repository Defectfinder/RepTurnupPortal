using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using RepTurnupProtal.Pages;
using RepTurnupProtal.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTurnupProtal.Tests
{
    [TestFixture]
    public class TM_test : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()

        {
            //open chrome brower
            driver = new ChromeDriver();

            //Login page object initialization 
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page obj initialization
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMpage(driver);
        }
        [Test]
        public void CreateTime_Test()
        {
            TMPage tMPageobj = new TMPage();
            tMPageobj.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test() 
        {
            TMPage tMPageobj = new TMPage();
            tMPageobj.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Test()
        {
            TMPage tMPageobj = new TMPage();
            tMPageobj.DeleteRecord(driver);
            // Calling Customer page
            //homePageObj.NavigateToCustomerPage(driver);
        }
        [TearDown]
        public void CloseRun_Test() 
        {
            driver.Quit();
        }
    }
}
