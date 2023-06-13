using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codeup_alchemy_assesment
{
    public class AmazonMehtods : AmazonPO
    {
        public AmazonMehtods(IWebDriver driver) : base(driver) { }

        public void NavigateToAmazonWebsite(string url)
        {
            MainCalls.SeleniumExtension.GotoUrl(url);
        }

        public void EnterTextInSearchButton(string text)
        {
            MainCalls.SeleniumExtension.WaitForElementAndSendKey(byAmazonSearchTexBox,text);
        }

        public void ClickSearchButton()
        {
            MainCalls.SeleniumExtension.WaitForElementAndClick(byAmazonSearchButton);
        }

        public void ClickOnSearchResult(int resultId) 
        {
            IWebElement searchElementFromGrid = MainCalls.SeleniumExtension.WaitAndGetElements(byAmazonSearchResultsAnchorTag)[resultId];
            searchElementFromGrid.Click();
        }

        public void ClickAddToCartButton() 
        {
            MainCalls.SeleniumExtension.WaitForElementAndClick(byAmazonAddToCartButton);
            MainCalls.SeleniumExtension.WaitTillPageLoad();
        }

        public int GetCartCount() 
        {
            
            IWebElement webElement = MainCalls.SeleniumExtension.WaitAndFindElement(byAmazonCartCount);
            int cartCount = Convert.ToInt32(webElement.Text);

            return cartCount;
        }
    }
}
