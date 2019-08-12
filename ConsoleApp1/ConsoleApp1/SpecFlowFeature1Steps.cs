using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace ToolsQA
{
    [Binding]
    public class SpecFlowFeatsure1Steps
    {
        IWebDriver driver;
        SpecFlowFeatsure1Steps()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
        }

        [Given(@"I navigate to uitest.duodecadits.com")]
        public void I_navigate_to_a_website()
        {
            driver.Url = "http://uitest.duodecadits.com/";
            NUnit.Framework.Assert.AreEqual("UI Testing Site", driver.Title);
            Console.WriteLine("The first test! ");
        }

        [Given(@"I navigate to (.*)")]
        public void I_navigate_to_a_website(String customWebsiteUrl)
        {
            driver.Navigate().GoToUrl(customWebsiteUrl);
            NUnit.Framework.Assert.IsTrue(driver.Url.Equals(customWebsiteUrl));
        }

        [Then(@"The title is (.*)")]
        public void I_check_website_title(String customWebsiteTitle)
        {
            NUnit.Framework.Assert.AreEqual(customWebsiteTitle, driver.Title);
        }

        [Then(@"I close the browser")]
        public void ICloseTheBrowser()
        {
            driver.Close();
        }
    }
}
