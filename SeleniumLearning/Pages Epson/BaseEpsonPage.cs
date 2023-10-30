using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumLearning.Core;
using SeleniumLearning.Pages;
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
            //driver.FindElement(By.Id("addToCartButton")).Click();
            driver.FindElement(By.ClassName("js-buy-now")).Click();
        }

        public void GoToCheckout()
        {
            driver.FindElements(By.ClassName("js-continue-checkout-button"))[0].Click();
        }

        public void Checkout()
        {
            driver.FindElements(By.ClassName("js-continue-checkout-button"))[0].Click();
        }

        public void LoginEmail(String loginName)
        {
            driver.FindElement(By.CssSelector("#j_username")).SendKeys(loginName);
        }

        public void LoginPassword(String password) 
        {
            driver.FindElement(By.CssSelector("#j_password")).SendKeys(password);
        }

        public void SubmitCheckout()
        {
            driver.FindElements(By.ClassName("btn"))[4].Click();
        }

        public void FirstNameOrder(String firstNameOrder)
        {
            driver.FindElement(By.CssSelector("#first-name")).SendKeys(firstNameOrder);
        }
        public void LastNameOrder(String lastNameOrder)
        {
            driver.FindElement(By.CssSelector("#last-name")).SendKeys(lastNameOrder);
        }
        public void TelephoneNameOrder(String telephoneOrder)
        {
            driver.FindElement(By.CssSelector("#telephone")).SendKeys(telephoneOrder);
        }

        public void EnterAddressLink()
        {
            driver.FindElement(By.CssSelector("a[data-address-finder-toggle='off']")).Click();
        }

        public void AddressLine1(String addressLine1)
        {
            driver.FindElement(By.CssSelector("#line-1")).SendKeys(addressLine1);
        }
        public void Town(String town)
        {
            driver.FindElement(By.CssSelector("#town")).SendKeys(town);
        }
        public void PostCode(String postCode)
        {
            driver.FindElement(By.CssSelector("#postcode")).SendKeys(postCode);
        }
        public void SaveAndContinueOrder()
        {
            driver.FindElements(By.ClassName("btn"))[1].Click();
        }

        public void ShipmentMethodNext()
        {
            driver.FindElements(By.ClassName("btn"))[0].Click();
        }

        public void BillingSaveAndContinue()
        {
            driver.FindElements(By.ClassName("btn"))[1].Click();
        }

        public void PaymentMethodCC()
        {
            driver.FindElement(By.CssSelector("input[value='adyen_cc']")).Click();
        }

        public void SwitchToIframe()
        {
            IWebElement iframeElement = driver.FindElements(By.ClassName("js-iframe"))[0];
            driver.SwitchTo().Frame(iframeElement);
          //  driver.FindElement(By.CssSelector("input[value='encryptedCardNumber']")).SendKeys("4444 3333 2222 1111");
        }
    }
}
