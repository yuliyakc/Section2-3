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
    public class BaseTest
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();
        public LoginPage loginPage = new LoginPage(driver);
    }
}
