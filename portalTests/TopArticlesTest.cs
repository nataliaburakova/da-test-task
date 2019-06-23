using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium;
using TestOfTestAut;
using TestOfTestAut.Framework;
using TestOfTestAut.Pages;

namespace portalTests
{
    public class TopArticlesTest : BaseObject
    {
        [SetUp]
        public void beforeClass()
        {
            Driver = new ChromeDriver();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl("https://automated-testing.info/top");
        }

        [TearDown]
        public void afterClass()
        {
            Driver.Close();
        }
        [Test]
        public static void CheckArticle()
        {
            var topPage = TopArticlesPage.GetTopPage();
            topPage.ClickPeriod();
            topPage.ClickQuarter();
            bool titleIsDisplayed = topPage.CheckTitleTopic();
            Assert.IsTrue(titleIsDisplayed);
            topPage.ClickTagsField();
            string tag = "Java";
            topPage.InputTag(tag);
            topPage.SelectTag();
            bool entryOfTags = topPage.CheckEntryOfTags();
            Assert.IsTrue(entryOfTags);
        }
    }
}
