using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Selenium_automation.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.CssSelector, Using = "header img")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "header a")]
        public IWebElement LogoLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".home-banner a")]
        public IWebElement Banner { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".category-cards .top-card")]
        public IList<IWebElement> Cards { get; set; }
    }
}
