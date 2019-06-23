using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium;
using TestOfTestAut;
using TestOfTestAut.Framework;
using TestOfTestAut.Pages;

namespace portalTests
{
    [TestFixture]
    public class MainTest : BaseObject
    {

        [SetUp]
        public void beforeClass()
        {
            Driver = new ChromeDriver();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl("https://automated-testing.info/");
        }

        [TearDown]
        public void afterClass()
        {
            Driver.Close();
        }
        [Test]
        public static void SearchInfo()
        {
            var mainPage = MainPage.GetMainPage();
            mainPage.ClickSearchBtn();
            string searchText = "Facebook";
            mainPage.TypeText(searchText);
            string highlightText = mainPage.GetHighlightedText();
            string searchTermText = mainPage.GetSearchText();
            Assert.AreEqual(highlightText, searchTermText, "Expected highlight and search texts to be equal");
            mainPage.ClickSearchBtn();
            bool searchInputIsPresent = mainPage.SearchInputIsPresent();
            Assert.IsFalse(searchInputIsPresent); 
        }

    }
}
