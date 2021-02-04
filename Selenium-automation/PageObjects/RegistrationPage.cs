using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_automation.PageObjects
{
    public class RegistrationPage
    {
        [FindsBy(How = How.CssSelector, Using = ".element-list.collapse.show li")]
        public IWebElement PracticeForm { get; set; }

        [FindsBy(How = How.Id, Using = "userForm")]
        public IWebElement RegistrationForm { get; set; }
    }
}
