using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace ToolsQA
{
    class HomePage
    {
        private IWebDriver driver;
        private IWebElement menuButtonElement;
        private String homeURL = "http://uitest.duodecadits.com/";
        private String formURL = "http://uitest.duodecadits.com/form.html";
        public String getURL(String Url)
        {
            if (Url == "home")
            {
                return homeURL;
            }
            else if (Url == "form")
            {
                return formURL;
            }
            else return null;
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickOnMenuButton(String buttonName)
        {

            setValue(buttonName);
            menuButtonElement.Click();
        }

        public String getActiveNavbarButton()
        {
            IWebElement navbarActiveButton = driver.FindElement(By.CssSelector("#navbar ul li.active"));
            return navbarActiveButton.Text;
        }

        public String getSpecificTagText(String tagType)
        {
            IWebElement navbarActiveButton = driver.FindElement(By.CssSelector(tagType));
            return navbarActiveButton.Text;
        }

        public void setValue(String UIelementID)
        {
            menuButtonElement = driver.FindElement(By.Id(UIelementID));
        }
    }
}
