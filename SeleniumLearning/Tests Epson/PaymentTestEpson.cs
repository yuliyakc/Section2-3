using AngleSharp.Dom;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumLearning.Core;
using SeleniumLearning.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumLearning.Tests
{
    [AllureNUnit]
    public class PaymentTestEpson
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();


        [Test]
        public async Task ProductListTestEpson()
        {
            ProductListEpson productListPage = new ProductListEpson(driver);
            productListPage.Open();
            productListPage.Cookies();
            productListPage.OpenSearch();
            bool isElementPresent = driver.FindElements(productListPage.SearchInput).Count > 0;
            Assert.IsTrue(isElementPresent, "Element was found.");
            productListPage.SearchItem("EcoTank ET-2850");
            productListPage.AddItem();
            await Task.Delay(TimeSpan.FromSeconds(5));
            productListPage.GoToCheckout();
            productListPage.Checkout();
            productListPage.LoginEmail("yuliya.kozina@keenethics.com");
            productListPage.LoginPassword("Password1!");
            productListPage.SubmitCheckout();
            await Task.Delay(TimeSpan.FromSeconds(3));
            //productListPage.FirstNameOrder("Yuliya");
            //productListPage.LastNameOrder("Kozina");
            //productListPage.TelephoneNameOrder("888529720");
            productListPage.EnterAddressLink();
            productListPage.AddressLine1("Flat 11, The Foundry");
            productListPage.Town("Newcastle upon Tyne");
            productListPage.PostCode("NE2 1YL");
            productListPage.SaveAndContinueOrder();
            productListPage.ShipmentMethodNext();
            productListPage.BillingSaveAndContinue();
            productListPage.PaymentMethodCC();
            productListPage.SwitchToIframe();
        }
    }
}
