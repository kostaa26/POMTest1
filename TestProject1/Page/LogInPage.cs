using OpenQA.Selenium;
using TestProject1.Driver;

namespace TestProject1.Page
{
    public class LogInPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Name => driver.FindElement(By.Id("name"));

        public IWebElement Password => driver.FindElement(By.Id("password"));

        public IWebElement ButtonLogin => driver.FindElement(By.Id("login"));

        public void LogInOnPage(string name, string password)
        {
            Name.SendKeys(name);
            Password.SendKeys(password);
            ButtonLogin.Click();

        }


    }
}
