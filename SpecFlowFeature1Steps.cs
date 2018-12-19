using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ClassLibrary
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver d;

        [Given(@"I have enter all values")]
        public void GivenIHaveEnterAllValues()
        {
            d = new ChromeDriver();
            d.Navigate().GoToUrl("http://qaautomation.co.nz/deliveryform/");
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            d.Manage().Window.Maximize();
            Common a = new Common(d);
            a.fn.SendKeys("lavanya");
            a.ln.SendKeys("vemulapalli");
            a.email.SendKeys("lavanya@abc.com");
            a.phno.SendKeys("123456");
            a.cash.Click();
            a.SelectCity("New York");
            a.city.SendKeys("ghhh");
            a.add1.SendKeys("abc");
            a.add2.SendKeys("hhhh");
            a.zip.SendKeys("1234");


        }

        [Given(@"I sumbit all values")]
        public void GivenISumbitAllValues()
        {
            Common a = new Common(d);
            a.order.Click();
            Thread.Sleep(3000);
        }

        [When(@"I got verification message")]
        public void WhenIGotVerificationMessage()
        {
            Assert.AreEqual("Message is sent successfully", d.FindElement(By.XPath("//span[text()='Message is sent successfully']")).Text);
            Thread.Sleep(2000);
        }

        [Then(@"I will close the browser")]
        public void ThenIWillCloseTheBrowser()
        {
            d.Quit();
        }
    }
}
