using OpenQA.Selenium;
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
    public class ProductListEpson
    {
        private const string PAGE_URL = "https://epson-gb.cbnd-seikoepso3-s1-public.model-t.cc.commerce.ondemand.com/en_GB/products/printers/c/printers";
        IWebDriver driver;
        public By SearchInput = By.CssSelector(".js-search-site-input");

        public ProductListEpson(IWebDriver dr)
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
            driver.FindElement(By.CssSelector("#siteSearchLabel")).Click();
        }

        public void SearchItem()
        {
            //Task.Delay(2000).Wait();
            IWebElement search = driver.FindElement(SearchInput);
            search.SendKeys("EcoTank ET-2850");
            search.SendKeys(Keys.Enter);
        }

    }
}
