using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AuthomatedTestingGoogleSearch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int waitingTime = 1000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By googleResultText = By.XPath(".//h2//span[text()='Street Fighter V']");
            By link = By.XPath(".//h3[text()='Street Fighter Series | CAPCOM']");
            By game = By.XPath(".//span[text()='GAMES']");
            By submenu = By.XPath(".//a[text()='Street Fighter V: Champion Edition']");
            By showall = By.XPath(".//a[text()='Allow all']");
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);
            webDriver.Navigate().GoToUrl("https://www.google.co.uk");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(googleSearchButton).Click();
            var actualResultText = webDriver.FindElement(googleResultText);
            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));
            Thread.Sleep(waitingTime);
            webDriver.FindElement(link).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(game).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(submenu).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(showall).Click();
            //webDriver.Quit();
        }
    }
}
