using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ClassLibrary
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        IWebDriver d;

        [Given]
        public void Given_I_have_entered_all_values()
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
        
        [Given]
        public void Given_I_click_order_button()
        {
            Common a = new Common(d);
            a.order.Click();
            
        }
        
        [When]
        public void When_I_verify_message()
        {
            Assert.AreEqual("Message is sent successfully", d.FindElement(By.XPath("//span[text()='Message is sent successfully']")).Text);
            
        }
        
        [Then]
        public void Then_I_will_kill_the_browser()
        {
            d.Quit();
        }
    }
}
