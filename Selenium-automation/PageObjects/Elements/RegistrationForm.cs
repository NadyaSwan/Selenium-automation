using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_automation.PageObjects.Elements
{
    public class RegistrationForm
    {
        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement UserEmailInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"gender-radio-1\"]")]
        public IWebElement GenderMaleOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"gender-radio-2\"]")]
        public IWebElement GenderFemaleOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"gender-radio-3\"]")]
        public IWebElement GenderOtherOption { get; set; }

        [FindsBy(How = How.Id, Using = "userNumber")]
        public IWebElement MobileNumberInput { get; set; }

        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement BirthdayInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".react-datepicker__day--today+div")]
        public IWebElement CalendarDateNextDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"hobbies-checkbox-1\"]")]
        public IWebElement HobbiesSportOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"hobbies-checkbox-2\"]")]
        public IWebElement HobbiesReadingOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for=\"hobbies-checkbox-3\"]")]
        public IWebElement HobbiesMusicOption { get; set; }

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement UploadFileInput { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "state")]
        public IWebElement StateDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#react-select-3-option-2")]
        public IWebElement HaryanaState { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement CityDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#react-select-4-option-1")]
        public IWebElement PanipatCity { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-content")]
        public IWebElement ModalDialog { get; set; }
    }
}
