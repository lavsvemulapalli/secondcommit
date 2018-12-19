using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ClassLibrary
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        [Given(@"I have enterd all values")]
        public void GivenIHaveEnterdAllValues()
        {

            Common1.d = new ChromeDriver();
            Common1.d.Manage().Window.Maximize();
            Common1.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            Common1.d.Navigate().GoToUrl(" http://new-keys.azurewebsites.net/Account/Login ");
            Common1.textbox(Common1.d, "UserName", "vincent.nguyen@mvpstudio.co.nz", "Id");
            Common1.textbox(Common1.d, "Password", "ntmv2682", "Id");
            Common1.button(Common1.d, "//*[@id='sign_in']/div[1]/div[4]/button", "Xpath");
            Common1.button(Common1.d, "body > div.ui.fixed.top.text.menu > div > div.right.menu > div.ui.dropdown.item.active.visible", "CssSelector");
            //Actions a = new Actions(Common1.d);
            //a.MoveToElement(Common1.d.FindElement(By.ClassName("ui dropdown item active visible")).Click().
            Thread.Sleep(3000);
            

        }
        
        [Given(@"I have click next button")]
        public void GivenIHaveClickNextButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter finance details")]
        public void GivenIEnterFinanceDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click save button")]
        public void WhenIClickSaveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I verify my property added or not")]
        public void ThenIVerifyMyPropertyAddedOrNot()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
