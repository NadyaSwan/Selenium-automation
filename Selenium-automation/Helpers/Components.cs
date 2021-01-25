using OpenQA.Selenium.Support.PageObjects;
using Selenium_automation.PageObjects.Elements;

namespace Selenium_automation.Helpers
{
    public static class Components
    {
        public static T GetComponents<T>() where T : new()
        {
            var component = new T();
            PageFactory.InitElements(Base.driver, component);
            return component;
        }

        public static TextBox TextBox
        {
            get { return GetComponents<TextBox>(); }
        }

        public static Checkbox Checkbox
        {
            get { return GetComponents<Checkbox>(); }
        }

        public static UserForm UserForm
        {
            get { return GetComponents<UserForm>(); }
        }
    }
}
