using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace ToolsQA
{
    class FormPage
    {
        private IWebDriver driver;
        private IWebElement formInputButton;
        private IWebElement formSubmitButton;
        private IWebElement helloText;

        private String formURL = "http://uitest.duodecadits.com/form.html";

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            formInputButton = driver.FindElement(By.Id("hello-input"));
            formSubmitButton = driver.FindElement(By.Id("hello-submit"));
        }

        public void fillInputField(String text)
        {
            formInputButton.SendKeys(text);
        }
        public String getText()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            helloText = driver.FindElement(By.Id("hello-text"));
            return helloText.Text;
        }

        public void clickSubmit()
        {
            formSubmitButton.Click();
        }

        public String getFormInputTag(String text)
        {
            if (text == "input")
            {
                return formInputButton.TagName;
            }
            else if (text == "submit")
            {
                return formSubmitButton.TagName;
            }
            else if (text == "formSubmitButtonTypeAttribute")
            {
                return formSubmitButton.GetAttribute("type");
            }
            else return null;
        }
    }
}
