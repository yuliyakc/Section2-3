using NUnit.Allure.Core;
using OpenQA.Selenium;
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
    public class AddToCardPageTestEpson
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();


        [Test]
        public void AddToCardTestEpson()
        {
            ProductListEpson productListPage = new(driver);
            productListPage.Open();
            productListPage.Cookies();
            productListPage.OpenSearch();
            bool isElementPresent = driver.FindElements(productListPage.SearchInput).Count > 0;
            Assert.IsTrue(isElementPresent, "Element was found.");
            productListPage.SearchItem("EcoTank ET-2850");
        }
    }
}
