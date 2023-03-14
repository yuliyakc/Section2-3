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
    public class LoginPageTest //: BaseTest  выносим общую функциональность в BaseTest
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();

        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver,"my class", "https://s2.orientwatch.co.uk/or/en_GB/login"); // создаем обьект страницы вызываем конструктор класса LoginPage, который возвращает ссылку на новый созданный объект этого класса и и эту сслыку помещает в переменную loginPage типа LoginPage
            loginPage.Open();
            string currentUrl = driver.Url;
            Assert.That(currentUrl, Is.EqualTo(loginPage.pageURL));
            loginPage.Cookies();
            loginPage.TypeEmail("yuliyakc21@gmail.com"); //на объекте loginPage вызываем метод TypeEmail и передаем ему параметр наш email
            loginPage.TypePassword("Password1!"); //на объекте loginPage вызываем метод TypePassword и передаем ему параметр наш password
            loginPage.LoginBtnClick();
            Task.Delay(2000).Wait();
            //driver.Quit();
        }
    }
}
