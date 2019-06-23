using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestOfTestAut.Framework
{
    class Utils : BaseObject
    {
        private const int DEFAULT_TIMEOUT = 30;

        public static void WaitForElementPresentByClassName(string locator, int timeOut = DEFAULT_TIMEOUT)
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator)));
        }

        public static void WaitForElementPresentById(string locator, int timeOut = DEFAULT_TIMEOUT)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
            wait.Until(ExpectedConditions.ElementExists(By.Id(locator)));
        }

        public static void WaitForElementPresentByXPath(string locator, int timeOut = DEFAULT_TIMEOUT)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
        }
    }
}
