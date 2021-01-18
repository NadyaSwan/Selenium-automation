﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Selenium_automation
{
    class Initializer
    {
        public static IWebDriver driver;
        public Actions I;

        [SetUp]
        public void Init()
        {
            string outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string relativePath = @"..\Drivers";
            string driverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
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
            driver.Close();
            driver.Quit();
        }
    }
}
