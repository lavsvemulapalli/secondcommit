using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Class3
    {
        class DatePickerDemo
        {
            protected ExtentReports _extent;
            protected ExtentTest _test;

            [OneTimeSetUp]
            protected void Setup()
            {


                var htmlReporter = new ExtentHtmlReporter("d:\\reports\\test1.html");

                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }

            [OneTimeTearDown]
            protected void TearDown()
            {
                _extent.Flush();
            }

            [SetUp]
            public void BeforeTest()
            {
                _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            }

            [TearDown]
            public void AfterTest()
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                        ? ""
                        : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
                Status logstatus;

                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        break;
                    case TestStatus.Inconclusive:
                        logstatus = Status.Warning;
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        break;
                    default:
                        logstatus = Status.Pass;
                        break;
                }

                _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
                _extent.Flush();
            }
            IWebDriver d;
            [SetUp]
            public void Intilizing()
            {

                d = new ChromeDriver();
                d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            }

            [TestCase]
            public void Test1()
            {

                d.Navigate().GoToUrl("https://www.irctc.co.in/eticketing/loginHome.jsf");
                //d.FindElement(By.LinkText("FLIGHTS")).Click();
                //Thread.Sleep(5000);
                //d.FindElement(By.ClassName("home-search-btn")).Click();


            }

            [TearDown]
            public void Closing()
            {
                d.Quit();
            }

        }
    }

    }
