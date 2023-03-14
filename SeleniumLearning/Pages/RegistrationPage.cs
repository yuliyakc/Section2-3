using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class RegistrationPage
    {
        private const string PAGE_URL = "https://s2.orientwatch.co.uk/or/en_GB/login";
        IWebDriver driver; // поле класса, которое превратится в свойство объекта RegistrationPage

        public RegistrationPage(IWebDriver dr)// : base(driver, PAGE_URL) { } создаем коснтруктор класса LoginPage
        {
            this.driver = dr; //при создании объекта (вызове конструктора класса) свойству этого объекта присваивается значение, переданное в конструктор в качестве аргумента

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
            driver.FindElement(By.Id("register.firstName")).SendKeys("Yuliya");
        }

        public void LastName(string lastName)
        {
            driver.FindElement(By.Id("register.lastName")).SendKeys("Kozina");
        }

        public void EmailAddress(string emailAddress)
        {
            var targetEmail = Faker.Internet.Email();
            driver.FindElement(By.Id("register.email")).SendKeys(targetEmail);
        }

        public void ConfirmEmailAddress(string confirmEmailAddress)
        {
            var targetEmail = Faker.Internet.Email();
            driver.FindElement(By.Id("register.confirmEmail")).SendKeys(targetEmail);
        }


    }
}
