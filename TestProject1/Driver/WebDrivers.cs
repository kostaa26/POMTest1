using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.Driver
{
    public static class WebDrivers
    {
        public static IWebDriver? Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://example.testproject.io/web/");
        }
        public static void CleanUP()
        {
            Instance?.Quit();
        }








    }
}
