using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_automation.Helpers;
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
            Assert.IsTrue(driver.Url.Contains(path), "The page should be loaded but it was not.");
        }

        public void See(IWebElement element)
        {
            Assert.IsTrue(element.Displayed, $"The element {element} should be visible on the page but it was not.");
        }

        public void DontSee(IWebElement element)
        {
            Assert.IsTrue(!Assertions.Exists(element), "The element should not be visible but it was.");
        }

        public void CheckLink(IWebElement element, string link)
        {
            Assert.IsTrue(element.GetAttribute("href").Equals(link), $"Expected the link {link} to be present for element {element}");
        }

        public void SeeCount(IList<IWebElement> elements, int count)
        {
            int actualCount = elements.Count;
            Assert.IsTrue(actualCount.Equals(count), $"Expected to have {count} elements but found {actualCount}");
        }

        public void SeeText(IWebElement element, string text)
        {
            Assert.IsTrue(element.Text.Equals(text), $"Expected the element {element} to have {text}  but it was {element.Text}");
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void Clear(IWebElement element)
        {
            element.Clear();
        }

        public void Fill(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
    }
}
