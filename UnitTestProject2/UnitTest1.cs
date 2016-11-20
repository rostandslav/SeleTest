using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
