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
    public class LoginPageTestEpson 
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();


        [Test]
        public void LoginTestEpson()
        {
            LoginPage loginPage = new LoginPage(driver, "my class", "https://epson-gb.cbnd-seikoepso3-s1-public.model-t.cc.commerce.ondemand.com/en_GB/login"); 
            loginPage.Open();
            string currentUrl = driver.Url;
            Assert.That(currentUrl, Is.EqualTo(loginPage.pageURL));
            loginPage.Cookies();
            loginPage.TypeEmail("yuliya.kozina@keenethics.com"); //на объекте loginPage вызываем метод TypeEmail и передаем ему параметр наш email
            loginPage.TypePassword("Password1!"); //на объекте loginPage вызываем метод TypePassword и передаем ему параметр наш password
            loginPage.LoginBtnClick();
            Task.Delay(2000).Wait();
            //driver.Quit();
        }
    }
}
