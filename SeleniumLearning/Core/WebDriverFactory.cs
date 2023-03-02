using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning.Core
{
    public class WebDriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //закачай Chrome
                driver = new ChromeDriver(); // ініціалізація instance
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
    }
}
