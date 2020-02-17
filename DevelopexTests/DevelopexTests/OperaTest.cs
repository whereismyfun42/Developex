using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopexTests
{
    [TestClass]
    class OperaTest
    {
        //IWebDriver operaDriver = new OperaDriver();


        [TestMethod]
        public void Bug12()
        {
            new DriverManager().SetUpDriver(new OperaConfig());
            IWebDriver operaDriver = new OperaDriver();
            operaDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            operaDriver.Navigate().Refresh();
            operaDriver.Navigate().Refresh();
            operaDriver.Navigate().Refresh();
            operaDriver.Navigate().Refresh();
        }
    }
}
