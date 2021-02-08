﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_automation.Helpers;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Selenium_automation
{
    class Initializer
    {
        public static IWebDriver driver;
        public Actions I;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Logger.InitLogger();
        }

        [SetUp]
        public void Init()
        {
            string outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string relativePath = @"..\Drivers";
            string driverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
            var options = new ChromeOptions();
            options.AddArguments("--headless");
            driver = new ChromeDriver(driverPath)
            {
                Url = "https://demoqa.com/",
              
            };
            I = new Actions(driver);
            Base.driver = driver;

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
