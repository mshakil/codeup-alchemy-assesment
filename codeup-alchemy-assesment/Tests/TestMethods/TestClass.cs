using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codeup_alchemy_assesment
{
    [TestClass]
    public class TestClass : Hooks
    {
        [TestMethod]
        public void TestCase() {
            string webUrl = "http://www.amazon.com";
            string searchText = "Gaming Keyboards";

            MainCalls.AmazonMethods.NavigateToAmazonWebsite(webUrl);
            MainCalls.AmazonMethods.EnterTextInSearchButton(searchText);
            MainCalls.AmazonMethods.ClickSearchButton();

            MainCalls.AmazonMethods.ClickOnSearchResult(1); //SELECTED 1 as index

            MainCalls.AmazonMethods.ClickAddToCartButton();
            Assert.AreEqual(1, MainCalls.AmazonMethods.GetCartCount(), "Product is not added to cart");
        }
    }
}
