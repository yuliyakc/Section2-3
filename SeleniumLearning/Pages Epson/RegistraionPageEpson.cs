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
    public class RegistrationPageEpson
    {
        private const string PAGE_URL = "https://epson-gb.cbnd-seikoepso3-s1-public.model-t.cc.commerce.ondemand.com/en_GB/login";
        IWebDriver driver; 

        public RegistrationPageEpson(IWebDriver driver)
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

        public void FirstName(string firstName)
        {
            driver.FindElement(By.Id("register.firstName")).SendKeys(firstName);
        }

        public void LastName(string lastName)
        {
            driver.FindElement(By.Id("register.lastName")).SendKeys(lastName);
        }

        public void EmailAddress(string emailAddress)
        {
            driver.FindElement(By.Id("register.email")).SendKeys(emailAddress);
        }

        public void ConfirmEmailAddress(string confirmEmailAddress)
        {
            driver.FindElement(By.Id("register.confirmEmail")).SendKeys(confirmEmailAddress);
        }

        public void TypePassword(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void TypeConfirmPassword(string confirmPassword)
        {
            driver.FindElement(By.Id("register.checkPwd")).SendKeys(confirmPassword);
        }

        public void CustomerPersonal()
        {
            SeleniumActions.ClickOn(driver, "[for=\"PERSONAL\"]");

        }

        public void termsAndConditions()
        {
            SeleniumActions.ClickOn(driver, "[for=\"registerChkTermsConditions\"]");

        }

        public void RegisterBtnClick()
        {
            SeleniumActions.ClickOn(driver, "#epsonRegisterForm button[type=submit]");

        }


    }
}
