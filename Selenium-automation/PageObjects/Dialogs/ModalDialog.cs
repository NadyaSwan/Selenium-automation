
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_automation.PageObjects.Dialogs
{
    public class ModalDialog
    {
        [FindsBy(How = How.Id, Using = "example-modal-sizes-title-lg")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-body")]
        public IWebElement Content { get; set; }

        [FindsBy(How = How.Id, Using = "closeLargeModal")]
        public IWebElement CloseButton { get; set; }
    }
}
