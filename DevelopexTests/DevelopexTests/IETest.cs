using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopexTests
{
    [TestClass]
    class IETest
    {
        IWebDriver ieDriver = new InternetExplorerDriver();

        [TestMethod]
        public void Bug13()
        {
            ieDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
        }
    }
}
