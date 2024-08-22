using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTurnupProtal.Pages
{
    public class HomePage
    {
        public void NavigateToTMpage(IWebDriver driver)
      
        {
            // Create the Time and Marterial record
            // Navigate to the Time and Marterial
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();
            IWebElement timeAndMatertialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMatertialOption.Click();
        }
    }
}
