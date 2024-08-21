using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



public class Program
{
    private static void Main(string[] args)
    {
        //open chrome brower
        IWebDriver driver = new ChromeDriver();
        //Launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);

        //Identify Username textbox
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");
        Thread.Sleep(1000);
        //identify password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        // Identify login button and click it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        // check the login button
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User login successfully. Test Passed");
        }
        else
        {
            Console.WriteLine("user has not logged in. Test failed");
        }

        // Create the Time and Marterial record
        // Navigate to the Time and Marterial
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();
        IWebElement timeAndMatertialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMatertialOption.Click();
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
        //IWebElement priceEdittextbox = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]"));
        //IWebElement priceEdittextbox = driver.FindElement(By.Id("Price"));
        //priceEdittextbox.Clear();
        //priceEdittextbox.SendKeys("1234");

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

        //Deleting the code
        IWebElement deleteButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
        deleteButton.Click();
        //Alert delete 
        IAlert okDeleteItem = driver.SwitchTo().Alert();
        okDeleteItem.Accept();


    }
}