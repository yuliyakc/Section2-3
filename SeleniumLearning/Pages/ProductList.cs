﻿using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Cast;
using OpenQA.Selenium.Support.Extensions;
using SeleniumLearning.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class ProductList
    {
        private const string PAGE_URL = "https://s2.orientwatch.co.uk/or/en_GB/products/watches/classic/c/classic";
        IWebDriver driver;
        public By SearchInput = By.CssSelector(".js-search-site-input");

        public ProductList(IWebDriver dr)
        {
            this.driver = dr;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(PAGE_URL);
        }

        public void Cookies()
        {
            //Task.Delay(2000).Wait();
            driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")).Click();
        }
        public void OpenSearch()
        {
            //Task.Delay(2000).Wait();
            driver.FindElement(By.CssSelector(".js-toggle-search")).Click();
        }

        public void SearchItem()
        {
            //Task.Delay(2000).Wait();
            IWebElement search = driver.FindElement(SearchInput);
            search.SendKeys("AC08003A");
            search.SendKeys(Keys.Enter);
        }

    }
}
