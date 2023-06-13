using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Firefox;

namespace codeup_alchemy_assesment
{
    public class BrowserConfigurations : MainCalls
    {
        public static void InitializeWebDriver()
        {
            string browserType = "chrome";

            if (browserType.Equals("chrome"))
            {
                InitializeChromeDriver();
            }
            else if (browserType.Equals("firefox"))
            {
                InitializeFirefoxDriver();
            }
        }
        public static void CloseWebDriver()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }
        private static void InitializeChromeDriver()
        {
            if (WebDriver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                WebDriver = new ChromeDriver();
                WebDriver.Manage().Window.Maximize();
                WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }
        private static void InitializeFirefoxDriver()
        {
            if (WebDriver == null)
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                WebDriver = new FirefoxDriver();
                WebDriver.Manage().Window.Maximize();
            }
        }
    }
}
