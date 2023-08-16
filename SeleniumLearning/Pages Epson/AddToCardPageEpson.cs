using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumLearning.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class AddToCardPageEpson
    {
        private const string PAGE_URL = "https://epson-gb.cbnd-seikoepso3-s1-public.model-t.cc.commerce.ondemand.com/en_GB/products/printers/c/printers";
        IWebDriver driver;

        public AddToCardPageEpson(IWebDriver driver)
        {
            this.driver = driver; //при создании объекта (вызове конструктора класса) свойству этого объекта присваивается значение, переданное в конструктор в качестве аргумента

        }

        public void Open()
        {
            this.driver.Navigate().GoToUrl(PAGE_URL);
        }

        public void Cookies()
        {
            //Task.Delay(2000).Wait();
            driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")).Click();
        }

        //нужно добавить поиск элемента, можно ли использовать уже созданные методы и вызывать их в нужном тесте
        public void AddToCard()
        {
            driver.FindElement(By.Id("addToCartButton")).Click();        
        }

    }
}
