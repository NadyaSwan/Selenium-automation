using OpenQA.Selenium.Support.PageObjects;
using Selenium_automation.PageObjects.Dialogs;
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

        public static RegistrationForm RegistrationForm
        {
            get { return GetComponents<RegistrationForm>(); }
        }

        public static ModalDialog ModalDialog
        {
            get { return GetComponents<ModalDialog>(); }
        }

        public static RegistrationContent RegistrationContent
        {
            get { return GetComponents<RegistrationContent>(); }
        }
    }
}
