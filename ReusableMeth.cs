using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class ReusableMeth
    {
        [SetUp]
        public void Intilising()
        {
            Common1.d = new ChromeDriver();
            Common1.d.Manage().Window.Maximize();
            Common1.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }
        [TestCase]
        public void test1()
        {
            
            Common1.d.Navigate().GoToUrl("http://qaautomation.co.nz/deliveryform/");
             Common1.textbox(Common1.d, "hugeit_preview_textbox_25", "lavanya", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_24", "vemula", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_26", "abc@xyz.com", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_23", "123456", "Id");
            Common1.radioButton(Common1.d, "//*[@id='hugeit_preview_textbox_30']/li[2]/label/div/i[2]", "XPath");
            Common1.dd(Common1.d, "hugeit_preview_textbox_28", "New York", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_29", "asffggh", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_22", "asffggh", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_27", "asffggh", "Id");
            Common1.textbox(Common1.d, "hugeit_preview_textbox_31", "1234", "Id");
            Common1.button(Common1.d, "submit", "ClassName");
            Thread.Sleep(4000);
        }
        [TearDown]
        public void closing()
        {
            Common1.d.Quit();
        }

    }
}

