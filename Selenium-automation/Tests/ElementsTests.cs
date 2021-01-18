using NUnit.Framework;
using Selenium_automation.Helpers;

namespace Selenium_automation.Tests
{
    class ElementsTests: Initializer
    {
        [Test]
        [Category("ElementsTests")]
        [Description("Test to check TextBox element form present")]
        public void TextBoxElement()
        {
            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.SeeCount(Pages.ElementsPage.ElementGroups, 6);
            I.Click(Pages.ElementsPage.TextBoxElement);
            I.See(Components.TextBox.UserForm);
        }

        [Test]
        [Category("ElementsTests")]
        [Description("Test to check TextBox element email validation")]
        public void TextBoxElementEmailValidation()
        {
            string invalidEmail = "qwerty";

            string fullName = "Test";
            string validEmail = "qwerty@qwerty.com";
            string currentAddress = "test address";
            string permanentAddress = "test address 2";

            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.Click(Pages.ElementsPage.TextBoxElement);
            I.DontSee(Components.UserForm.EmailInputError);
            I.Fill(Components.UserForm.EmailInput, invalidEmail);
            I.Click(Components.UserForm.SubmitButton);
            I.See(Components.UserForm.EmailInputError);

            I.DontSee(Components.UserForm.SubmitMessage);
            I.Fill(Components.UserForm.FullName, fullName);
            I.Clear(Components.UserForm.EmailInput);
            I.Fill(Components.UserForm.EmailInput, validEmail);
            I.Fill(Components.UserForm.CurrentAddress, currentAddress);
            I.Fill(Components.UserForm.PermanentAddress, permanentAddress);
            I.Click(Components.UserForm.SubmitButton);
            I.See(Components.UserForm.SubmitMessage);
            I.SeeText(Components.UserForm.SubmitMessage, $"Email:{validEmail}");
        }
    }
}
