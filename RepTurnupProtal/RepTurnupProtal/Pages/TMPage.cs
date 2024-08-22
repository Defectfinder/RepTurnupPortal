using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTurnupProtal.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            //Select time from dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();

            //IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            //timeOption.Click();

            //Type code into the text box
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("XYZ123");

            //Type the description 

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Testing code");

            //Type the price
            IWebElement priceTextbox = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // checkif Time record is added successfully
            IWebElement goToLastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "XYZ123")
            {
                Console.WriteLine("Time record created successfully");
            }
            else
            {
                Console.WriteLine("New record is not created");
            }
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            //Click the Edit option
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[1]"));
            editButton.Click();

            //Select the dropdown
            IWebElement typeMaterialDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeMaterialDropdown.Click();

            IWebElement selectDropdown = driver.FindElement(By.XPath("/html/body/div[5]/div/ul/li[2]"));
            //IWebElement selectDropdown = driver.FindElement(By.Id("TypeCode_option_selected"));
            selectDropdown.Click();


            //Type code into the text box
            IWebElement codeEditTextbox = driver.FindElement(By.Id("Code"));
            codeEditTextbox.Clear();
            codeEditTextbox.SendKeys("EditedCode");

            //Type the description 

            IWebElement descriptionEditTextbox = driver.FindElement(By.Id("Description"));
            descriptionEditTextbox.Clear();
            descriptionEditTextbox.SendKeys("Testing code after edit");
            Thread.Sleep(2000);

            //Type the price

            IWebElement priceEditOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceEditOverlap.Click();

            IWebElement priceEdittextbox = driver.FindElement(By.Id("Price"));
            priceEdittextbox.SendKeys("1234");

            //click on save button
            IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
            saveEditButton.Click();
            Thread.Sleep(3000);



            // checkif Time record is added successfully
            IWebElement goToeditLastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToeditLastButton.Click();

            IWebElement neweditCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (neweditCode.Text == "XYZ123")
            {
                Console.WriteLine("Time record Edited successfully");
            }
            else
            {
                Console.WriteLine("New record is not Edited");
            }

        }
        public void DeleteRecord(IWebDriver driver)
        {
            //Deleting the code
            IWebElement deleteButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);
            //Alert delete 
            IAlert okDeleteItem = driver.SwitchTo().Alert();
            okDeleteItem.Accept();
        }
    }
}
