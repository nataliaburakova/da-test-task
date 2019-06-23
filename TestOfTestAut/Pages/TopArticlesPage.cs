using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TestOfTestAut.Framework;

namespace TestOfTestAut.Pages
{
    public class TopArticlesPage : BaseObject
    {
        [FindsBy(How = How.PartialLinkText, Using = SELECT_TOPIC)]
        public IWebElement topic;

        [FindsBy(How = How.XPath, Using = TOP_BTN_LOCATOR)]
        public IWebElement topBtnElement;

        [FindsBy(How = How.XPath, Using = PERIOD_PATH)]
        public IWebElement period;

        [FindsBy(How = How.XPath, Using = PERIOD_QUARTER_PATH)]
        public IWebElement selectQuarter;

        [FindsBy(How = How.XPath, Using = TOPIC_ELEMENT)]
        public IWebElement checkTopic;

        [FindsBy(How = How.XPath, Using = TAG_FIELD_ELEMENT)]
        public IWebElement tagField;

        [FindsBy(How = How.XPath, Using = INPUT_FIELD)]
        public IWebElement inputTag;

        [FindsBy(How = How.XPath, Using = TAGS_LIST)]
        public IList<IWebElement> tagList;

        public static TopArticlesPage GetTopPage()
        {
            TopArticlesPage topArticlePage = new TopArticlesPage();
            InitPage(topArticlePage);
            return topArticlePage;
        }


        public void ClickTopBtn()
        {
            this.topBtnElement.Click();
        }

        public void ClickPeriod()
        {
            Utils.WaitForElementPresentByXPath(PERIOD_PATH);
            this.period.Click();
        }

        public void ClickQuarter()
        {
            Utils.WaitForElementPresentByXPath(PERIOD_QUARTER_PATH);
            selectQuarter.Click();
        }

        public bool CheckTitleTopic()
        {
            Utils.WaitForElementPresentByXPath(TOPIC_ELEMENT);
            bool statusTopic = checkTopic.Displayed;
            return statusTopic;
        }

        public void ClickTagsField()
        {
            this.tagField.Click();
        }

        public void InputTag(string Text)
        {
            System.Threading.Thread.Sleep(3000);
            this.inputTag.SendKeys(Text);
        }

        public void SelectTag()
        {
            this.topic.Click();
        }

        public bool CheckEntryOfTags()
        {
            String[] ListOfTagsText = new String[tagList.Count];
            int i = 0;
            bool flag = true;
            string ReferenceTag = "javascript";
            while (flag && i < tagList.Count)
            {
                flag = tagList[i].Text.ToLower().Contains(ReferenceTag);
                i++;
            }
            return flag;
        }

        public const string SELECT_TOPIC = "javascript";
        public const string TOP_BTN_LOCATOR = "//li[@id='ember30']/a";
        public const string PERIOD_PATH = "//div[contains(@class, 'top-lists')]/div/button";
        public const string PERIOD_QUARTER_PATH = "//div[contains(@class, 'select-kit-body')]/ul/li[3]/span[2]";
        public const string PERIOD_QUARTER_ELEMENT = "//ul/li[3]/span[2]";
        public const string TOPIC_ELEMENT = "//td[1]/span/a";
        public const string TAG_FIELD_ELEMENT = "//*[@id='main-outlet']/div[3]/div/section/ol/li[2]";
        public const string INPUT_FIELD = "//div[contains(@id, 'main-outlet')]/div[contains(@class, 'list-controls')]/div[1]/section/ol[1]/li[2]/div[2]/div[1]/input"; 
        public const string TAGS_LIST = "//tbody/tr/td[1]/div/div";
    }
}
