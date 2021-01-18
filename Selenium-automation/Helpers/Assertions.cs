using OpenQA.Selenium;
using System.Linq;

namespace Selenium_automation.Helpers
{
    public static class Assertions
    {
        public static bool Exists(IWebElement element)
        {
            try
            {
                return element.Displayed ? true : false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
