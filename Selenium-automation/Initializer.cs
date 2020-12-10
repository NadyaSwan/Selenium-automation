using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Web_browser_automation
{
    class Initializer
    {
        IWebDriver driver;

        [SetUp]
        public void Init()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @"..\Drivers";
            var driverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
            driver = new ChromeDriver(driverPath);
        }

        [Test]
        public void test()
        {
            driver.Url = "https://demoqa.com/";
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
