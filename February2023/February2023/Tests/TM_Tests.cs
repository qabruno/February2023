using February2023.Pages;
using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2023.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
           driver = new ChromeDriver(@"D:/February2023");

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            // Edit TM
            tmPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            // Delete
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
