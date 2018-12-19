using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Common1
    {
        public static IWebDriver d { get; set; }
        public static void textbox(IWebDriver d, String element, string value, string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == "Id")
                d.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).SendKeys(value);
            if (elementtype == "ClassName")
                d.FindElement(By.ClassName(element)).SendKeys(value);
        }
        public static void button(IWebDriver d, String element, string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).Click();
            else if (elementtype == "Id")
                d.FindElement(By.Id(element)).Click();
            else if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).Click();
            else if (elementtype == "ClassName")
                d.FindElement(By.ClassName(element)).Click();
            else if (elementtype == "CssSelector")
                d.FindElement(By.ClassName(element)).Click();

        }

        public static void dd(IWebDriver d, String element, string value, string elementtype)
        {
            if (elementtype == "Name")
                new SelectElement(d.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == "Id")
                new SelectElement(d.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Xpath")
                new SelectElement(d.FindElement(By.XPath(element))).SelectByText(value);
            if (elementtype == "ClassName")
                new SelectElement(d.FindElement(By.ClassName(element))).SelectByText(value);

        }

        public static void radioButton(IWebDriver d, String element, string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).Click();
            else if (elementtype == "Id")
                d.FindElement(By.Id(element)).Click();
            else if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).Click();
            else if (elementtype == "ClassName")
                d.FindElement(By.ClassName(element)).Click();

        }

        public static void Checkbox(IWebDriver d, String element, string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).Click();
            else if (elementtype == "Id")
                d.FindElement(By.Id(element)).Click();
            else if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).Click();
            else if (elementtype == "ClassName")
                d.FindElement(By.ClassName(element)).Click();

        }


    }
}

