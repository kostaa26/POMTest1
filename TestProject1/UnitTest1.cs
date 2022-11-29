using OpenQA.Selenium;
using TestProject1.Driver;
using TestProject1.Page;

namespace TestProject1
{
    public class Tests
    {
        private LogInPage logInPage;
        private TestFormPage testFormPage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            logInPage = new LogInPage();
            testFormPage = new TestFormPage();

        }
        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.CleanUP();
        }

        [Test]
        public void TC01_FillOutTheForm_ShouldFormBeFilled()
        {
            logInPage.LogInOnPage("Kosta", "12345");

            testFormPage.SelectOption("Serbia");
            testFormPage.Address.SendKeys("ulicabr2");
            testFormPage.Email.SendKeys("kostab@gmail.com");
            testFormPage.Phone.SendKeys("0645873975");
            testFormPage.ButtonSave.Click();
            testFormPage.ButtonLogOut.Click();


        }
        public void LogInOnPage(string name, string password)
        {
            logInPage.LogInOnPage(name, password);
        }



    }
}