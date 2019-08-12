using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver(Environment.CurrentDirectory);
            driver.Url = "http://www.demoqa.com";
            Console.WriteLine("Hello World!");
        }
    }
}
