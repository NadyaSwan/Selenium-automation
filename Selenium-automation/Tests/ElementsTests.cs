using NUnit.Framework;
using Selenium_automation.Helpers;

namespace Selenium_automation.Tests
{
    class ElementsTests: Initializer
    {
        [Test]
        [Category("Elements")]
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
        [Category("Elements")]
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

        [Test]
        [Category("Elements")]
        [Description("All checkboxes are checked when root folder is clicked")]
        public void CheckboxRootFolder()
        {
            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.Click(Pages.ElementsPage.CheckboxElement);
            I.See(Components.Checkbox.CollapsedList);
            I.DontSee(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.ExpandListButton);
            I.See(Components.Checkbox.ExpandedList);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.Click(Components.Checkbox.HomeNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 17);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.HomeNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);
        }

        [Test]
        [Category("Elements")]
        [Description("All checkboxes are checked when sub folders are clicked")]
        public void CheckboxSubFolders()
        {
            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.Click(Pages.ElementsPage.CheckboxElement);
            I.See(Components.Checkbox.CollapsedList);
            I.DontSee(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.ExpandListButton);
            I.See(Components.Checkbox.ExpandedList);

            Logger.Log.Info("Check Desktop sub folder");
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.Click(Components.Checkbox.DesktopNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 3);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.DesktopNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);

            Logger.Log.Info("Check Documents sub folder");
            I.Click(Components.Checkbox.DocumentsNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 10);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.DocumentsNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);

            Logger.Log.Info("Check Downloads sub folder");
            I.Click(Components.Checkbox.DownloadsNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 3);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.DownloadsNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);
        }

        [Test]
        [Category("Elements")]
        [Description("All checkboxes are checked when sub2 folders are clicked")]
        public void CheckboxSub2Folders()
        {
            I.Click(Pages.HomePage.Cards[0]);
            I.AmOn("/elements");
            I.Click(Pages.ElementsPage.CheckboxElement);
            I.See(Components.Checkbox.CollapsedList);
            I.DontSee(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.ExpandListButton);
            I.See(Components.Checkbox.ExpandedList);

            Logger.Log.Info("Check Workspace sub2 folder");
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.Click(Components.Checkbox.WorkspaceNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 4);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.WorkspaceNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);

            Logger.Log.Info("Check Office sub2 folder");
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.Click(Components.Checkbox.OfficeNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsChecked, 5);
            I.See(Components.Checkbox.ResultMessage);
            I.Click(Components.Checkbox.OfficeNodeCheckbox);
            I.SeeCount(Components.Checkbox.ItemsUnchecked, 17);
            I.DontSee(Components.Checkbox.ResultMessage);
        }
    }
}
