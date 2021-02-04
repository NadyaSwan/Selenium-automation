using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_automation.Helpers;
using System;
using System.Collections.Generic;

namespace Selenium_automation
{
    public class Actions
    {
        IWebDriver driver;
        public Actions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AmOn(string path)
        {
            Assert.IsTrue(driver.Url.Contains(path), "The page should be loaded but it was not.");
        }

        public void See(IWebElement element)
        {
            Assert.IsTrue(element.Displayed, $"The element {element} should be visible on the page but it was not.");
        }

        public void DontSee(IWebElement element)
        {
            Assert.IsTrue(!Assertions.Exists(element), "The element should not be visible but it was.");
        }

        public void CheckLink(IWebElement element, string link)
        {
            Assert.IsTrue(element.GetAttribute("href").Equals(link), $"Expected the link {link} to be present for element {element}");
        }

        public void SeeCount(IList<IWebElement> elements, int count)
        {
            int actualCount = elements.Count;
            Assert.IsTrue(actualCount.Equals(count), $"Expected to have {count} elements but found {actualCount}");
        }

        public void SeeText(IWebElement element, string text)
        {
            Assert.IsTrue(element.Text.Equals(text), $"Expected the element {element} to have {text}  but it was {element.Text}");
        }

        public string RememberTextOf(IWebElement element)
        {
            try
            {
                return element.GetAttribute("value");
            }
            catch
            {
                return element.Text;
            }
        }

        public void Click(IWebElement element)
        {
            ScrollIntoView(element);
            element.Click();
        }

        public void Clear(IWebElement element)
        {
            element.Clear();
        }

        public void Fill(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void Select(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);

            try
            {
                selectElement.SelectByValue(value);
            }
            catch (Exception e)
            {
                Logger.Log.Error(e);
            }
        }

        public void ScrollIntoView(IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            try
            {
                if (element.Location.Y > 200)
                {
                    js.ExecuteScript($"window.scrollTo({0}, {element.Location.Y - 200 })");
                }
            }
            catch (Exception e)
            {
                Logger.Log.Error(e);
            }
        }

        public void SeeFormSubmittedSuccessfully(string birthDate)
        {
            IWebElement UserName = Components.RegistrationContent.RegistrationFields[0].FindElements(By.TagName("td"))[1];
            IWebElement UserEmail = Components.RegistrationContent.RegistrationFields[1].FindElements(By.TagName("td"))[1];
            IWebElement Gender = Components.RegistrationContent.RegistrationFields[2].FindElements(By.TagName("td"))[1];
            IWebElement Mobile = Components.RegistrationContent.RegistrationFields[3].FindElements(By.TagName("td"))[1];
            IWebElement Birthday = Components.RegistrationContent.RegistrationFields[4].FindElements(By.TagName("td"))[1];
            IWebElement Hobbies = Components.RegistrationContent.RegistrationFields[6].FindElements(By.TagName("td"))[1];
            IWebElement Address = Components.RegistrationContent.RegistrationFields[8].FindElements(By.TagName("td"))[1];
            IWebElement StateAndCity = Components.RegistrationContent.RegistrationFields[9].FindElements(By.TagName("td"))[1];

            See(Components.RegistrationForm.ModalDialog);
            SeeText(Components.ModalDialog.Title, "Thanks for submitting the form");
            See(Components.ModalDialog.Content);
            See(Components.ModalDialog.CloseButton);
            SeeText(UserName, $"{Constants.FirstName} {Constants.LastName}");
            SeeText(UserEmail, $"{Constants.Email}");
            SeeText(Gender, "Female");
            SeeText(Mobile, $"{Constants.Phone}");
            SeeText(Birthday, $"{ParseDate(birthDate)}");
            SeeText(Hobbies, "Sports, Reading, Music");
            SeeText(Address, $"{Constants.CurrentAddress}");
            SeeText(StateAndCity, "Haryana Panipat");
        }

        string ParseDate(string birthDate)
        {
            Dictionary<string, string> months = new Dictionary<string, string>
            {
                { "Dec", "December" },
                { "Jan", "January" },
                { "Feb", "February" },
                { "Mar", "March" },
                { "Apr", "April" },
                { "May", "May" },
                { "Jun", "June" },
                { "Jul", "July" },
                { "Aug", "August" },
                { "Sep", "September" },
                { "Oct", "October" },
                { "Nov", "November" }
            };

            string givenDay = birthDate.Split(' ')[0];
            string givenMonth = birthDate.Split(' ')[1];
            string givenYear = birthDate.Split(' ')[2];
            string month = months[givenMonth];

            return $"{givenDay} {month},{givenYear}";
        }
    }
}
