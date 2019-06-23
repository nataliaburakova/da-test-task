using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TestOfTestAut;
using TestOfTestAut.Framework;
using TestOfTestAut.Pages;

namespace portalTests
{
    public class CategoriesTest : BaseObject
    {
        [SetUp]
        public void beforeClass()
        {
            Driver = new ChromeDriver();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl("https://automated-testing.info/categories");
        }

        [TearDown]
        public void afterClass()
        {
            Driver.Close();
        }
        [Test]
        public static void CategoriesPageTest()
        {
            var categories = CategoriesPage.GetCategoriesPage();
            categories.CheckCategories();
            categories.CheckBasicKnowlages();
            categories.CheckJob();

        }
    }
}
