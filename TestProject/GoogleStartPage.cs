using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class GoogleStartPage : BasePage
    {
        By searchInput = By.Name("q");
        //By submitButton = By.Name("");
        
        public void SendingKeys(string text)
        {
            var element = FindElement(searchInput);
            element.Clear();
            element.SendKeys(text);
        }

        public void Submit()
        {
            IWebElement submit = FindElement(searchInput);
            submit.Submit();
        }
        //добавить класс страницы ResultPage, реализовать метод теста (Assert)
        //!!!NUnit!!!
        //аннотации
    }
}
