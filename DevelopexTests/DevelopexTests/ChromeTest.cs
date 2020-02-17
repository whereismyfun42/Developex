using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopexTests
{
    [TestClass]
    class ChromeTest
    {
        IWebDriver chromeDriver = new ChromeDriver();

        [TestMethod]
        public void Bug1()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
        }

        [TestMethod]
        public void Bug2()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            chromeDriver.Navigate().Refresh();
            chromeDriver.Navigate().Refresh();
            chromeDriver.Navigate().Refresh();
            chromeDriver.Navigate().Refresh();
        }

        [TestMethod]
        public void Bug3()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[1]")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[1]")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[1]")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[1]")).Click();
        }

        [TestMethod]
        public void Bug4()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[2]"));
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[2]"));
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[2]"));
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[2]/fieldset/div/div/button[2]"));
        }

        [TestMethod]
        public void Bug5()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            List<IWebElement> fields = new List<IWebElement>();
            IWebElement field1 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[1]/input"));
            fields.Add(field1);
            IWebElement field2 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[2]/input"));
            fields.Add(field2);
            IWebElement field3 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[3]/input"));
            fields.Add(field3);
            IWebElement field4 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[4]/input"));
            fields.Add(field4);
            IWebElement field5 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[5]/input"));
            fields.Add(field5);
            IWebElement field6 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[6]/input"));
            fields.Add(field6);
            IWebElement field7 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[7]/input"));
            fields.Add(field7);

            foreach(IWebElement field in fields)
            {
                field.SendKeys("1");
            }

            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[8]/input")).Click();

        }

        [TestMethod]
        public void Bug6()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            List<IWebElement> fields = new List<IWebElement>();
            IWebElement field1 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[1]/input"));
            //fields.Add(field1);
            field1.SendKeys("qowdjnqwojdnqwkldnalskdmlaskmclaskmvlaksmvlaksmvlaksmvlaksmvalskvmalskmv");
            IWebElement field2 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[2]/input"));
            fields.Add(field2);
            IWebElement field3 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[3]/input"));
            fields.Add(field3);
            IWebElement field4 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[4]/input"));
            fields.Add(field4);
            IWebElement field5 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[5]/input"));
            fields.Add(field5);
            IWebElement field6 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[6]/input"));
            fields.Add(field6);
            IWebElement field7 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[7]/input"));
            fields.Add(field7);

            foreach (IWebElement field in fields)
            {
                field.SendKeys("1");
            }

            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[8]/input")).Click();
        }

        [TestMethod]
        public void Bug8()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            List<IWebElement> fields = new List<IWebElement>();
            IWebElement field1 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[1]/input"));
            //fields.Add(field1);
            field1.SendKeys("hr@developex.com");
            IWebElement field2 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[2]/input"));
            fields.Add(field2);
            IWebElement field3 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[3]/input"));
            fields.Add(field3);
            IWebElement field4 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[4]/input"));
            fields.Add(field4);
            IWebElement field5 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[5]/input"));
            fields.Add(field5);
            IWebElement field6 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[6]/input"));
            fields.Add(field6);
            IWebElement field7 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[7]/input"));
            fields.Add(field7);

            foreach (IWebElement field in fields)
            {
                field.SendKeys("1");
            }

            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[8]/input")).Click();
        }

        [TestMethod]
        public void Bug9()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            List<IWebElement> fields = new List<IWebElement>();
            
            IWebElement field4 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[4]/input"));
            fields.Add(field4);
            IWebElement field5 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[5]/input"));
            fields.Add(field5);
            

            foreach (IWebElement field in fields)
            {
                field.SendKeys("QAZxsw135");
            }

            //chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[8]/input")).Click();
        }

        [TestMethod]
        public void Bug10()
        {
            chromeDriver.Navigate().GoToUrl("https://reverent-aryabhata-11cf33.netlify.com/");
            List<IWebElement> fields = new List<IWebElement>();
            IWebElement field1 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[1]/input"));
            fields.Add(field1);
            IWebElement field2 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[2]/input"));
            fields.Add(field2);
            IWebElement field3 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[3]/input"));
            fields.Add(field3);
            IWebElement field4 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[4]/input"));
            fields.Add(field4);
            IWebElement field5 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[5]/input"));
            fields.Add(field5);
            IWebElement field6 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[6]/input"));
            fields.Add(field6);
            /*IWebElement field7 = chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[7]/input"));
            fields.Add(field7);*/

            foreach (IWebElement field in fields)
            {
                field.SendKeys("1");
            }

            chromeDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div[1]/form/fieldset/div[8]/input")).Click();
        }
    }
}
