using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium_automation.PageObjects.Elements;
using System.Collections.Generic;

namespace Selenium_automation.PageObjects
{
    public partial class ElementsPage
    {
        [FindsBy(How = How.ClassName, Using = "element-group")]
        public IList<IWebElement> ElementGroups { get; set; }

        [FindsBy(How = How.Id, Using = "item-0")]
        public IWebElement TextBoxElement { get; set; }
    }
}
