﻿using NUnit.Framework;
using Selenium_automation.Helpers;

namespace Selenium_automation.Tests
{
    class HomePageTests: Initializer
    {
        [Test]
        [Category("HomePage")]
        public void MainElementsPresent()
        {
            I.See(Pages.HomePage.Logo);
            I.CheckLink(Pages.HomePage.LogoLink, "https://demoqa.com/");
            I.See(Pages.HomePage.Banner);
            I.CheckLink(Pages.HomePage.Banner, "https://www.toolsqa.com/selenium-training/");
            for(int i = 0; i < Pages.HomePage.Cards.Count; i++) { 
                I.See(Pages.HomePage.Cards[i]);
            };
            I.SeeCount(Pages.HomePage.Cards, 6);
        }
    }
}
