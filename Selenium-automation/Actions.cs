using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Selenium_automation
{
    public class Actions
    {
        IWebDriver driver;
        public Actions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AmOn(string path)
        {
            Assert.IsTrue(driver.Url.Contains(path), "Page should be loaded but it was not.");
        }

        public void See(IWebElement element)
        {
            Assert.IsTrue(element.Displayed, $"Element {element} should be visible on the page but it did not.");
        }

        public void CheckLink(IWebElement element, string link)
        {
            Assert.IsTrue(element.GetAttribute("href").Equals(link), $"Expected link {link} to be present for element {element}");
        }

        public void SeeCount(IList<IWebElement> elements, int count)
        {
            int actualCount = elements.Count;
            Assert.IsTrue(actualCount.Equals(count), $"Expected to have {count} elements but was {actualCount}");
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }
    }
}
