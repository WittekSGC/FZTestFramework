using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class DriverClass
    {
        private IWebDriver driver;
        public DriverClass(string path, string mode)
        {
            switch (mode)
            {
                case "Chrome":
                    {
                        driver = new ChromeDriver() { Url = path};
                        //driver.Url = path;
                        break;
                    }
                case "Firefox":
                    {
                        driver = new FirefoxDriver();
                        driver.Url = path;
                        break;
                    }
                default:
                    {
                        throw new Exception("unknown mode driver");
                    }
            }
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }


    }
}
