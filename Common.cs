using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Common
    {
        IWebDriver _d;
        public Common(IWebDriver d)
        {
            _d = d;
            PageFactory.InitElements(_d, this);
        }


      //  public static IWebDriver d { get; set; }
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_25")] public IWebElement fn;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_24")] public IWebElement ln;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_26")] public IWebElement email;
        [FindsBy(How = How.XPath, Using = "//*[@id='hugeit_preview_textbox_23']")] public IWebElement phno;

       [FindsBy(How = How.XPath, Using = "//*[@id='hugeit_preview_textbox_30']/li[2]/label/div/i[2]")] public IWebElement cash;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_28")] public IWebElement state;
       
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_29")] public IWebElement city;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_22")] public IWebElement add1;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_27")] public IWebElement add2;
        [FindsBy(How = How.Id, Using = "hugeit_preview_textbox_31")] public IWebElement zip;

        [FindsBy(How = How.ClassName, Using = "submit")] public IWebElement order;

        public void SelectCity(string value)
        {
            new SelectElement(state).SelectByText(value);
        }


    }
}