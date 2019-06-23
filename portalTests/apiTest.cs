using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace portalTests
{
    [TestFixture]
    public class apiTest
    {
        public class EntPoindCheck
        {
            [Test]
            public async Task CheckMainPage()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://automated-testing.info/");
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK, "Expected status code 200");
            }
            [Test]
            public async Task CheckOneCategotyPage()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://automated-testing.info/c/webdriver");
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK, "Expected status code 200");
            }
            [Test]
            public async Task CheckArticlePage()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://automated-testing.info/t/kak-nazhat-na-knopku-vopros-pro-ozhidanie/21287");
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK, "Expected status code 200");
            }
            [Test]
            public async Task CheckTopPage()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://automated-testing.info/top");
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK, "Expected status code 200");
            }
            [Test]
            public async Task CheckAllCategoriesPage()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://automated-testing.info/categories");
                var resContent = response.Content.ReadAsStringAsync();
                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK, "Expected status code 200");
            }

        }
    }
}
