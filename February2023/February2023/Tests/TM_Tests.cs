using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using February2023.Pages;

// Open Chrome Browser
IWebDriver driver = new ChromeDriver(@"D:/February2023");

// Login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM page object initialization and definition
TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

// Edit TM
tmPageObj.EditTM(driver);

// Delete
tmPageObj.DeleteTM(driver);







