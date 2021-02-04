using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Selenium_automation.PageObjects.Dialogs
{
    public class RegistrationContent
    {
        [FindsBy(How = How.CssSelector, Using = ".table-dark tbody tr")]
        public IList<IWebElement> RegistrationFields { get; set; }
    }
}
