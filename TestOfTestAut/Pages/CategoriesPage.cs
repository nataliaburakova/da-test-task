using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TestOfTestAut.Framework;

namespace TestOfTestAut.Pages
{
    public class CategoriesPage : BaseObject
    {
        [FindsBy(How = How.XPath, Using = DIFFERENT_QUESTIONS_PATH)]
        public IWebElement differentQuestions;

        [FindsBy(How = How.XPath, Using = BASIC_KNOWLEDGE_PATH)]
        public IWebElement basicKnowlages;

        [FindsBy(How = How.XPath, Using = JOB_PATH)]
        public IWebElement job;

        public static CategoriesPage GetCategoriesPage()
        {
            CategoriesPage categoriesPage = new CategoriesPage();
            InitPage(categoriesPage);
            return categoriesPage;
        }


        public bool CheckCategories()
        {
            bool result = differentQuestions.Displayed;
            return result;
        }

        public bool CheckBasicKnowlages()
        {
            bool result = basicKnowlages.Displayed;
            return result;
        }

        public bool CheckJob()
        {
            bool result = job.Displayed;
            return result;
        }

        public const string DIFFERENT_QUESTIONS_PATH = ".//*[text()='общие вопросы']/..";
        public const string BASIC_KNOWLEDGE_PATH = ".//*[text()='база знаний']/..";
        public const string JOB_PATH = ".//*[text()='работа']/..";

    }
}
