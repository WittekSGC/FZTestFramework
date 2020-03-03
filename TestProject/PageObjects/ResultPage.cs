using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class ResultPage : BasePage //id=gsr
    {
        By resultPage = By.Id("gsr");
        
        public IWebElement GetResultPage()
        {
            return _driver.FindElement(resultPage);
        }
    }
}
