using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codeup_alchemy_assesment
{
    public class SeleniumExtensions
    {
        private IWebDriver wdriver;
        const int Webdriver_TimeOut = 30;

        public SeleniumExtensions(IWebDriver driver) 
        {
            this.wdriver = driver;
        }

        public void GotoUrl(string url)
        {
            wdriver.Navigate().GoToUrl(url);
        }

        public void WaitTillPageLoad() 
        {
            Thread.Sleep(1000);
        }

        public IWebElement WaitAndFindElement(By selector)
        {
            WebDriverWait wait = new WebDriverWait(wdriver, TimeSpan.FromSeconds(Webdriver_TimeOut));
            return wait.Until(x => x.FindElement(selector));
        }

        public IList<IWebElement> WaitAndGetElements(By selector) {
            WebDriverWait wait = new WebDriverWait(wdriver, TimeSpan.FromSeconds(Webdriver_TimeOut));

            return wait.Until(x=> x.FindElements(selector));
        }

        public void WaitForElementAndSendKey(By selector, string key)
        {
            WebDriverWait wait = new WebDriverWait(wdriver, TimeSpan.FromSeconds(Webdriver_TimeOut));
            IWebElement element = wait.Until(x => x.FindElement(selector));
            element.SendKeys(key);
        }

        public void WaitForElementAndClick(By selector)
        {
            WebDriverWait wait = new WebDriverWait(wdriver, TimeSpan.FromSeconds(Webdriver_TimeOut));
            IWebElement element = wait.Until(x => x.FindElement(selector));

            element.Click();
        }
    }
}
