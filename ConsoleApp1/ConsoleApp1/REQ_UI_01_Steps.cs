using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ToolsQA
{
    [Binding]
    public class SpecFlowFeatsure1Steps
    {
        IWebDriver driver;
        public object Driver { get; private set; }
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

        [TechTalk.SpecFlow.Then(@"The title is (.*)")]
        public void I_check_website_title(String customWebsiteTitle)
        {
            NUnit.Framework.Assert.AreEqual(customWebsiteTitle, driver.Title);
        }

        [TechTalk.SpecFlow.When(@"I click on (.*) button")]
        public void IClickOnFormButton(String button_name)
        {
            HomePage home = new HomePage(driver);
            home.clickOnMenuButton(button_name);
        }

        [TechTalk.SpecFlow.Then(@"I should be on the (.*) Page")]
        public void ThenIShouldBeOnTheHomePage(String name)
        {
            HomePage home = new HomePage(driver);
            NUnit.Framework.Assert.AreEqual(home.getURL(name), driver.Url);
        }

        [TechTalk.SpecFlow.Then(@"I see the (.*) button active")]
        public void ISeeTheHomeButtonActive(String buttonId)
        {
            HomePage home = new HomePage(driver);
            NUnit.Framework.Assert.AreEqual(buttonId, home.getActiveNavbarButton());
        }

        [TechTalk.SpecFlow.Then(@"I get 404 error")]
        public void IgetError()
        {
            HomePage home = new HomePage(driver);
            NUnit.Framework.Assert.IsTrue( home.getSpecificTagText("h1").Contains("404 Error: File not found :-("));
        }

        [TechTalk.SpecFlow.Then(@"The (.*) tag contains (.*)")]
        public void IgetH1tag(String tagType, String message)
        {
            HomePage home = new HomePage(driver);
            NUnit.Framework.Assert.IsTrue(home.getSpecificTagText(tagType).Contains(message));
        }

        [TechTalk.SpecFlow.Then(@"I see on the Form page a form with one input box and one submit button")]
        public void ISeeOneInputandSubmitButton()
        {
            FormPage page = new FormPage(driver);
            NUnit.Framework.Assert.AreEqual(page.getFormInputTag("input"), "input");
            NUnit.Framework.Assert.AreEqual(page.getFormInputTag("submit"), "button");
            NUnit.Framework.Assert.AreEqual(page.getFormInputTag("formSubmitButtonTypeAttribute"), "submit");
        }

        [Given(@"I type (.*) in the input field and click Submit")]
        public void GivenThereAreNames(String p0)
        {
            FormPage page = new FormPage(driver);
            page.fillInputField(p0);
            page.clickSubmit();
        }

        [TechTalk.SpecFlow.Then(@"I should see (.*) on the page")]
        public void ThenIShouldSeeTheNames(String p0)
        {
            FormPageAfterSubmit page = new FormPageAfterSubmit(driver);
            NUnit.Framework.Assert.AreEqual(page.getText(), p0);
        }

        [TechTalk.SpecFlow.Then(@"I close the browser")]
        public void ICloseTheBrowser()
        {
            driver.Close();
        }
    }
}
