using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeup_alchemy_assesment
{
    public class MainCalls
    {
        public static IWebDriver WebDriver { get; set; }


        private static SeleniumExtensions _seleniiumExtension;
        public static SeleniumExtensions SeleniumExtension
        {
            get
            {
                if (_seleniiumExtension == null)
                {
                    _seleniiumExtension = new SeleniumExtensions(WebDriver);
                }
                return _seleniiumExtension;
            }
            set { _seleniiumExtension = value; }
        }

        private static AmazonMehtods _loginFunctions;
        public static AmazonMehtods AmazonMethods
        {
            get
            {
                if (_loginFunctions == null)
                {
                    _loginFunctions = new AmazonMehtods(WebDriver);
                }
                return _loginFunctions;
            }
            set { _loginFunctions = value; }
        }
    }
}
