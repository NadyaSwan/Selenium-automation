using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Selenium_automation.PageObjects.Elements
{
    public class UserForm
    {
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement FullName { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#userEmail.field-error")]
        public IWebElement EmailInputError { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement SubmitMessage { get; set; }
    }
}
