using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RepTurnupProtal.Pages;



public class Program
{
    private static void Main(string[] args)
    {
        
        
        //open chrome brower
        IWebDriver driver = new ChromeDriver();

        //Implicit wait
        //WebDriverWait wait = new WebDriverWait
        
       //Login page object initialization 
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page obj initialization
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMpage(driver);

       // TMPage obj initialization
        TMPage tMPageobj = new TMPage();
        tMPageobj.CreateTimeRecord(driver);
        tMPageobj.EditTimeRecord(driver);
        tMPageobj.DeleteRecord(driver);
        
       
        

        
        
        


    }
}