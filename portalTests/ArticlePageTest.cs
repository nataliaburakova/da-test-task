using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium;
using System;
using TestOfTestAut;
using TestOfTestAut.Framework;
using TestOfTestAut.Pages;

namespace portalTests
{
    [TestFixture]
    public class ArticlePageTest : BaseObject
    {

        [SetUp]
        public void beforeClass()
        {
            Driver = new ChromeDriver();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl("https://automated-testing.info/t/kak-nazhat-na-knopku-vopros-pro-ozhidanie/21287");
        }

        [TearDown]
        public void afterClass()
        {
            Driver.Close();
        }
        [Test]
        public static void ArticleElements()
        {
            var articlePage = ArticlePage.GetActiclePage();
            Console.WriteLine("Page title is: " + Driver.Title);
            bool result = articlePage.CheckListOfTags();
            Assert.IsTrue(result);
            string reference = "Aleksandr_Litovskij";
            string realAutor = articlePage.CheckAutor();
            Assert.AreEqual(reference, realAutor, "Expected another autor");
            int articlesAmount = articlePage.CheckTextOfArticle();
            Assert.AreEqual(articlesAmount, 4, "Article was edited or not found");

        }
    }
}

