using OpenQA.Selenium;


namespace codeup_alchemy_assesment
{
    public class AmazonPO : BasePO
    {
        protected AmazonPO(IWebDriver driver) : base(driver) { }

        protected By byAmazonSearchTexBox = By.CssSelector("input#twotabsearchtextbox");
        protected By byAmazonSearchButton = By.CssSelector("input#nav-search-submit-button");

        protected By byAmazonSearchResultsAnchorTag = By.CssSelector("div[data-component-type='s-search-result'] div.s-title-instructions-style h2.a-size-mini a");

        protected By byAmazonAddToCartButton = By.XPath("//input[@id='add-to-cart-button']");
        protected By byAmazonCartCount = By.XPath("//div[@id='nav-cart-count-container']/span[@id='nav-cart-count']");

    }
}
