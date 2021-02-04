using OpenQA.Selenium.Support.PageObjects;
using Selenium_automation.PageObjects;

namespace Selenium_automation.Helpers
{
    public static class Pages
    {
        public static T GetPages<T>() where T: new()
        {
            var page = new T();
            PageFactory.InitElements(Base.driver, page);
            return page;
        }

        public static HomePage HomePage
        {
            get { return GetPages<HomePage>(); }
        }

        public static ElementsPage ElementsPage
        {
            get { return GetPages<ElementsPage>(); }
        }

        public static RegistrationPage RegistrationPage
        {
            get { return GetPages<RegistrationPage>(); }
        }
    }
}
