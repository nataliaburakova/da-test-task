using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Selenium;

namespace TestOfTestAut.Framework
{
    public class BaseObject
    {

        public static ChromeDriver Driver;
        public static DefaultSelenium Selenium;

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(Driver, pageClass);
        }
    }
}
