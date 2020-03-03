using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class BasePage
    {
        private DriverClass driver = new DriverClass(@"https:\\google.com", "Chrome");
        public IWebDriver _driver;

        public BasePage()
        {
            _driver = driver.GetDriver();
        }

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public void CloseDriver()
        {
            _driver.Quit();
        }
    }
}
