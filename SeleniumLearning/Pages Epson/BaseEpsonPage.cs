using OpenQA.Selenium;
using SeleniumLearning.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages_Epson
{
    public class BaseEpsonPage
    {
        protected IWebDriver driver; // создаем поле driver c типом IWebDriver
        public string pageURL;
        public By SearchInput = By.CssSelector(".js-search-site-input");// SearchInput это поле класса ProductListEpson типа By
       
        public BaseEpsonPage(IWebDriver driver, string pageUrl)
        {
            this.driver = driver;
            this.pageURL = pageUrl;
        }
        public void Open()
        {
            driver.Navigate().GoToUrl(pageURL);
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

        public void SearchItem(String itemName)
        {
            //Task.Delay(2000).Wait();
            IWebElement search = driver.FindElement(SearchInput);
            search.SendKeys(itemName);
            search.SendKeys(Keys.Enter);
        }
        public void AddItem()
        {
            driver.FindElement(By.Id("addToCartButton")).Click();
        }

        public void GoToCheckout()
        {
            driver.FindElements(By.ClassName("js-continue-checkout-button"))[0].Click();
        }

    }
}
