using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_automation.PageObjects.Elements
{
    public class TextBox
    {
        [FindsBy(How = How.Id, Using = "userForm")]
        public IWebElement UserForm { get; set; }
    }
}
