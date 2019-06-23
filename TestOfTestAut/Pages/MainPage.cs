using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TestOfTestAut.Framework;

namespace TestOfTestAut.Pages
{
    public class MainPage : BaseObject
    {

        [FindsBy(How = How.ClassName, Using = SEARCH_INPUT_CLASSNAME)]
        public IWebElement searchInput;

        [FindsBy(How = How.Id, Using = SEARCH_TERM_ID)]
        public IWebElement searchTermElement;

        [FindsBy(How = How.Id, Using = SEARCH_BUTTON_ID)]
        public IWebElement searchButton;

        [FindsBy(How = How.ClassName, Using = SEARCH_HIGHLIGHT_CLASSNAME)]
        public IWebElement searchHighlightElement;

        public static MainPage GetMainPage()
        {
            MainPage mainPage = new MainPage();
            InitPage(mainPage);
            return mainPage;
        }
        public bool SearchInputIsPresent()
        {
            try
            {
                Utils.WaitForElementPresentByClassName(SEARCH_INPUT_CLASSNAME, 2);
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException error)
            {
                return false;
            }
        }
        public void TypeText(string text)
        {
            this.searchTermElement.SendKeys(text);
        }

        public void ClickSearchBtn()
        {
            this.searchButton.Click();
        }

        public string GetHighlightedText()
        {
            Utils.WaitForElementPresentByClassName(SEARCH_HIGHLIGHT_CLASSNAME);
            return this.searchHighlightElement.Text.ToLower();
        }

        public string GetSearchText()
        {
            Utils.WaitForElementPresentById(SEARCH_TERM_ID);
            return this.searchTermElement.GetAttribute("value").ToLower();
        }

        public const string SEARCH_INPUT_CLASSNAME = "search-input";
        public const string SEARCH_TERM_ID = "search-term";
        public const string SEARCH_HIGHLIGHT_CLASSNAME = "search-highlight";
        public const string SEARCH_BUTTON_ID = "search-button";
    }
}
