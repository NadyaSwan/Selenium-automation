using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Selenium_automation.PageObjects
{
    public class ElementsPage
    {
        [FindsBy(How = How.ClassName, Using = "element-group")]
        public IList<IWebElement> ElementGroups { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menu-list>li")]
        public IList<IWebElement> Elements { get; set; }

        [FindsBy(How = How.Id, Using = "userForm")]
        public IWebElement UserForm { get; set; }
    }
}
