using NUnit.Framework;

namespace Selenium_automation.Tests
{
    class ElementsTests: Initializer
    {
        [Test]
        [Category("ElementsTests")]
        [Description("Test to check TextBox element validation")]
        public void TextBoxElement()
        {
            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.SeeCount(Pages.ElementsPage.ElementGroups, 6);
            I.Click(Pages.ElementsPage.Elements[0]);
            I.See(Pages.ElementsPage.UserForm);
        }
    }
}
