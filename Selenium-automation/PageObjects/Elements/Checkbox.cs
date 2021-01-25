using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Selenium_automation.PageObjects.Elements
{
    public class Checkbox
    {
        [FindsBy(How = How.ClassName, Using = "rct-node-collapsed")]
        public IWebElement CollapsedList { get; set; }

        [FindsBy(How = How.ClassName, Using = "rct-option-expand-all")]
        public IWebElement ExpandListButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "rct-node-expanded")]
        public IWebElement ExpandedList { get; set; }

        [FindsBy(How = How.ClassName, Using = "rct-option-collapse-all")]
        public IWebElement CollapseListButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-home\"]")]
        public IWebElement HomeNodeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-desktop\"]")]
        public IWebElement DesktopNodeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-documents\"]")]
        public IWebElement DocumentsNodeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-workspace\"]")]
        public IWebElement WorkspaceNodeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-office\"]")]
        public IWebElement OfficeNodeCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"tree-node-downloads\"]")]
        public IWebElement DownloadsNodeCheckbox { get; set; }

        [FindsBy(How = How.ClassName, Using = "rct-icon-check")]
        public IList<IWebElement> ItemsChecked { get; set; }

        [FindsBy(How = How.ClassName, Using = "rct-icon-uncheck")]
        public IList<IWebElement> ItemsUnchecked { get; set; }

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement ResultMessage { get; set; }
    }
}
