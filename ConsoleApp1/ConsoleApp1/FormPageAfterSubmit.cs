using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace ToolsQA
{
    class FormPageAfterSubmit
    {
        private IWebDriver driver;
        private IWebElement helloText;

        public FormPageAfterSubmit(IWebDriver driver)
        {
            this.driver = driver;
            helloText = driver.FindElement(By.Id("hello-text"));
        }

        public String getText()
        {
            helloText = driver.FindElement(By.Id("hello-text"));
            return helloText.Text;
        }
    }
}
