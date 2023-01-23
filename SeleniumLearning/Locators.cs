using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;

namespace SeleniumLearning
{
    public class Locators
    {
        //xPath, Css, id, classname, name, tagname.
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
        public void LocatorsIdentification()
        {

            driver.FindElement(By.Id("j_username")).SendKeys("yuliya.kozina@keenethics.com");
            driver.FindElement(By.Name("j_password")).SendKeys("Password1!");
            // css selector & xpath
            //SelectElement s = new SelectElement(driver.FindElement(By.CssSelector("button[type='Submit']")));
            //s.SelectByIndex(1);
            //driver.FindElement(By.XPath("//button[contains(text(),'Log In')]")).Click();
            //driver.FindElement(By.XPath("//button[@class = 'btn-primary btn--checkout mt-auto']")).Click();
            Task.Delay(20000).Wait();
            driver.FindElement(By.CssSelector("#loginForm button[type='submit']")).Click();
            Task.Delay(5000).Wait();

        }
        public void SignOut()
        {
            Task.Delay(10000).Wait();
            driver.FindElement(By.CssSelector("a[href ='https://s2.orientwatch.co.uk/or/en_GB/logout']"));
        }
    }
}

