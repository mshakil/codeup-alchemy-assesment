using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeup_alchemy_assesment
{
    public class BasePO
    {
        protected IWebDriver wDriver;
        protected BasePO(IWebDriver driver)
        {
            this.wDriver = driver;
        }
    }
}
