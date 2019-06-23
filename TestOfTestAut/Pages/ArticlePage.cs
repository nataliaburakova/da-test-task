using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TestOfTestAut.Framework;

namespace TestOfTestAut.Pages
{
    public class ArticlePage : BaseObject

    {
        [FindsBy(How = How.ClassName, Using = LIST_OF_TAGS_CLASS)]
        [FindsBy(How = How.XPath, Using = LIST_OF_TAGS_ELEMENT)]
                public IWebElement listOfTags;

        [FindsBy(How = How.XPath, Using = AUTOR_NICKNAME_ELEMENT)]
        public IWebElement nickname;

                [FindsBy(How = How.XPath, Using = WHOLE_TEXT_ELEMENT)]
                public IList<IWebElement> textElement;


        public static ArticlePage GetActiclePage()
        {
            ArticlePage articlePage = new ArticlePage();
            InitPage(articlePage);
            return articlePage;
        }

        public bool CheckListOfTags()
        {
            bool statusListOfTags = listOfTags.Displayed;
            System.Threading.Thread.Sleep(3000);
            return statusListOfTags;
        }


        public string CheckAutor()
        {
            string autorTitle= nickname.Text;
            return autorTitle;
        }

        public int CheckTextOfArticle()
        {
            String[] ListOfWholeText = new String[textElement.Count];
            return textElement.Count;
        }

        public const string LIST_OF_TAGS_ELEMENT = "//div";
        public const string LIST_OF_TAGS_CLASS = "title-wrapper";
        public const string POST_STREAM = "post-stream";
        public const string AUTOR_NICKNAME_ELEMENT = "//div[1]/article/div/div[2]/div[1]/div/span[1]/a";
        public const string WHOLE_TEXT_ELEMENT = "//div[1]/article/div/div[2]/div[2]/div/p/br";
    }
}