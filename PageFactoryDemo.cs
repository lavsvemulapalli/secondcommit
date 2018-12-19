using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PageFactoryDemo
    {
        IWebDriver d;
        [SetUp]
        public void Intilising()
        {
            d = new ChromeDriver();
            d.Manage().Window.Maximize();
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }
        [TestCase]
        public void test1()
        {
            d.Navigate().GoToUrl("http://qaautomation.co.nz/deliveryform/");
            Common a = new Common(d);
            a.fn.SendKeys("lavanya");
            a.ln.SendKeys("vemulapalli");
            a.email.SendKeys("lavanya@abc.com");
            a.phno.SendKeys("123456");
            a.cash.Click();
            a.SelectCity("New York");
            Thread.Sleep(3000);
            a.city.SendKeys("ghhh");

            a.add1.SendKeys("abc");
            a.add2.SendKeys("hhhh");
            a.zip.SendKeys("1234");
            a.order.Click();

        }
        [TearDown]
        public void closing()
        {
            d.Quit();
        }

    }

}
