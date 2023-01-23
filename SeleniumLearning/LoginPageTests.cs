using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirst
    {
        IWebDriver driver; //сюди буде збережено посилання до драйвера браузера, зберігаємо інстанс об'єкту, який ми ініціалізуємо

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //закачай Chrome
            driver = new ChromeDriver(); // ініціалізація instance
            driver.Manage().Window.Maximize();
            driver.Url = "https://orient-gb.cbnd-seikoepso3-s2-public.model-t.cc.commerce.ondemand.com/orientstorefront/en_GB/login";
        }

        [Test]
        public void openHomePageTest()
        {

            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            //driver.Close();
        }
    }
}
