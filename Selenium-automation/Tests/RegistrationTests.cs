using NUnit.Framework;
using Selenium_automation.Helpers;

namespace Selenium_automation.Tests
{
    class RegistrationTests: Initializer
    {
        [Test]
        [Category("Forms")]
        [Description("Test to check Registration form all fields are present")]
        public void RegistrationForm()
        {
            I.Click(Pages.HomePage.Cards[1]);
            I.AmOn("/forms");
            I.SeeCount(Pages.ElementsPage.ElementGroups, 6);
            I.Click(Pages.RegistrationPage.PracticeForm);
            I.See(Pages.RegistrationPage.RegistrationForm);
            I.See(Components.RegistrationForm.FirstNameInput);
            I.See(Components.RegistrationForm.LastNameInput);
            I.See(Components.RegistrationForm.UserEmailInput);
            I.See(Components.RegistrationForm.GenderMaleOption);
            I.See(Components.RegistrationForm.GenderFemaleOption);
            I.See(Components.RegistrationForm.GenderOtherOption);
            I.See(Components.RegistrationForm.MobileNumberInput);
            I.See(Components.RegistrationForm.BirthdayInput);
            I.See(Components.RegistrationForm.HobbiesSportOption);
            I.See(Components.RegistrationForm.HobbiesReadingOption);
            I.See(Components.RegistrationForm.HobbiesMusicOption);
            I.See(Components.RegistrationForm.UploadFileInput);
            I.See(Components.RegistrationForm.CurrentAddress);
            I.See(Components.RegistrationForm.StateDropdown);
            I.See(Components.RegistrationForm.CityDropdown);
            I.See(Components.RegistrationForm.SubmitButton);
        }

        [Test]
        [Category("Forms")]
        [Description("Test to check Registration form submit successfully")]
        public void RegistrationForm_SubmitSuccessfully()
        {
            I.Click(Pages.HomePage.Cards[1]);
            I.AmOn("/forms");
            I.Click(Pages.RegistrationPage.PracticeForm);
            I.Fill(Components.RegistrationForm.FirstNameInput, Constants.FirstName);
            I.Fill(Components.RegistrationForm.LastNameInput, Constants.LastName);
            I.Fill(Components.RegistrationForm.UserEmailInput, Constants.Email);
            I.Click(Components.RegistrationForm.GenderFemaleOption);
            I.Fill(Components.RegistrationForm.MobileNumberInput, Constants.Phone);
            I.Click(Components.RegistrationForm.BirthdayInput);
            I.Click(Components.RegistrationForm.CalendarDateNextDay);
            string birthDate = I.RememberTextOf(Components.RegistrationForm.BirthdayInput);
            I.Click(Components.RegistrationForm.HobbiesSportOption);
            I.Click(Components.RegistrationForm.HobbiesReadingOption);
            I.Click(Components.RegistrationForm.HobbiesMusicOption);
            //I.Fill(Components.RegistrationForm.UploadFileInput, Constants.PictureUrl);
            I.Fill(Components.RegistrationForm.CurrentAddress, Constants.CurrentAddress);
            I.Click(Components.RegistrationForm.StateDropdown);
            I.Click(Components.RegistrationForm.HaryanaState);
            I.Click(Components.RegistrationForm.CityDropdown);
            I.Click(Components.RegistrationForm.PanipatCity);
            I.Click(Components.RegistrationForm.SubmitButton);
            I.SeeFormSubmittedSuccessfully(birthDate);
        }
    }
}
