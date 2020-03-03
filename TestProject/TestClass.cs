using NUnit.Framework;

namespace TestProject
{
    class TestClass : BasePage
    {
        static void Main()
        {
            TestClass test = new TestClass();
            test.FindSomeText();
        }

        [Test]
        public void FindSomeText()
        {
            GoogleStartPage googleStartPage = new GoogleStartPage();
            _driver.Manage().Window.Maximize();
            string strToFind = "meow cat";
            googleStartPage.SendingKeys(strToFind);
            googleStartPage.Submit();
            ResultPage resultPage = new ResultPage();
            Assert.IsTrue(resultPage.GetResultPage().Displayed);
        }
        //IWebDriver driver = new ChromeDriver("chromedriver");
        //INavigation navigation = driver.Navigate();
        //navigation.GoToUrl("http://google.com");
        //driver.Manage().Window.Maximize();
        //IWebElement searchField = driver.FindElement(By.Name("q"));            
        //searchField.SendKeys("Jojo");
        //searchField.SendKeys(Keys.Enter);
        //IWebElement searchResults = driver.FindElement(By.XPath("//*[@id = 'mBMHK']"));
        //Assert.IsTrue(searchResults.Displayed);
        //Console.ReadKey();
    }
}

