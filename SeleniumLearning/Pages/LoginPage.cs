using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Cast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class LoginPage //:BasePage
    {
        private const string PAGE_URL = "https://s2.orientwatch.co.uk/or/en_GB/login";
        IWebDriver driver; // поле класса, которое превратится в свойство объекта loginPage
        public string pageURL; // поле класса, которое превратится в свойство объекта loginPage
        public string pageName; // поле класса, которое превратится в свойство объекта loginPage

        public LoginPage(IWebDriver dr, string pageName, string newpageUrl)// : base(driver, PAGE_URL) { } создаем коснтруктор класса LoginPage
        {
            this.driver = dr; //при создании объекта (вызове конструктора класса) свойству этого объекта присваивается значение, переданное в конструктор в качестве аргумента
            this.pageName = pageName;
            this.pageURL = newpageUrl;
        
        }

        public void Open() 
        {
            this.driver.Navigate().GoToUrl(this.pageURL);
        }


        public void TypeEmail(string email) 
        
        {
            driver.FindElement(By.Id("j_username")).SendKeys(email);
        }

        public void TypePassword(string password)

        {
            driver.FindElement(By.Name("j_password")).SendKeys(password);
        }


    }
}
