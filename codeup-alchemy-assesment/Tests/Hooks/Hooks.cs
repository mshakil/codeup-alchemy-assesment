using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeup_alchemy_assesment
{
    [TestClass]
    public class Hooks
    {
        [TestInitialize]
        public void Init()
        {
            BrowserConfigurations.InitializeWebDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            BrowserConfigurations.CloseWebDriver();
        }
    }
}
