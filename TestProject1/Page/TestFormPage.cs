using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject1.Driver;

namespace TestProject1.Page
{
    public class TestFormPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void SelectOption(string text)
        {
            SelectElement Country = new(driver.FindElement(By.Id("country")));
            Country.SelectByText(text);
        }

        public IWebElement Address => driver.FindElement(By.Id("address"));

        public IWebElement Email => driver.FindElement(By.Id("email"));

        public IWebElement Phone => driver.FindElement(By.Id("phone"));

        public IWebElement ButtonSave => driver.FindElement(By.Id("save"));

        public IWebElement ButtonLogOut => driver.FindElement(By.Id("logout"));



    }
}
