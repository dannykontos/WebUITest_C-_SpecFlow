/*using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize(){
            driver = new FirefoxDriver(Environment.CurrentDirectory);
        }

        [Test]
        public void OpenAppTest() => driver.Url = "http://www.demoqa.com";

        [TearDown]
        public void EndTest(){
            driver.Close();
        }
        public void TestApp(){
        }
    }
}*/