using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using Microsoft.Win32;

namespace SeleniumLearning
{
    public class Registration
    {
        IWebDriver driver; //сюди буде збережено посилання до драйвера браузера, зберігаємо інстанс об'єкту, який ми ініціалізуємо

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //закачай Chrome
            driver = new ChromeDriver(); // ініціалізація instance
            driver.Manage().Window.Maximize();
            driver.Url = "https://s2.orientwatch.co.uk/or/en_GB/login";
        }

        [Test]
        public void openRegistrationPageTest()
        {
            driver.FindElement(By.Id("register.firstName")).SendKeys("Yuliya");
            driver.FindElement(By.Id("register.lastName")).SendKeys("Kozina");
            driver.FindElement(By.Id("register.email")).SendKeys("test1@gmail.com");
            driver.FindElement(By.Id("register.confirmEmail")).SendKeys("test1@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Password1!");
            driver.FindElement(By.Id("register.checkPwd")).SendKeys("Password1!");
            Task.Delay(10000).Wait();
            driver.FindElement(By.CssSelector("input[id='register.marketingConsent']")).Click();
            driver.FindElement(By.CssSelector("input[id='registerChkTermsConditions']")).Click();

        }
    }
}
