using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Cast;
using OpenQA.Selenium.Support.Extensions;
using SeleniumLearning.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class LoginPage 
    {
        private const string PAGE_URL = "https://s2.orientwatch.co.uk/or/en_GB/login";
        IWebDriver driver; // поле driver класса LoginPage, которое превратится в свойство объекта loginPage
        public string pageURL; // поле класса, которое превратится в свойство объекта loginPage
        public string pageName; // поле класса, которое превратится в свойство объекта loginPage

        public LoginPage(IWebDriver dr, string pageName, string newpageUrl)// : base(driver, PAGE_URL) { } создаем коснтруктор класса LoginPage
        {
            this.driver = dr; //при создании объекта (вызове конструктора класса) свойству этого объекта присваивается значение, переданное в конструктор в качестве аргумента
            this.pageName = pageName;
            this.pageURL = newpageUrl;
        
        }
       //перегруженный конструктор (конструктор с одинаковым именем, но разной сигнатурой - с другим количеством параметров)
        // также любой метод класса может быть перегружен
        public LoginPage(IWebDriver dr)// : base(driver, PAGE_URL) { } создаем коснтруктор класса LoginPage
        {
            this.driver = dr; //при создании объекта (вызове конструктора класса) свойству этого объекта присваивается значение, переданное в конструктор в качестве аргумента
        }

        //loginPage.Open();
        //loginPage2.Open();
        public void Open() 
        {
            driver.Navigate().GoToUrl(pageURL);
        }  

        public void Cookies()
        {
            //Task.Delay(2000).Wait();
            driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")).Click();
        }


        public void TypeEmail(string email) 
        {
            driver.FindElement(By.Id("j_username")).SendKeys(email);
        }

        public void TypePassword(string password)
        {
            driver.FindElement(By.Id("j_password")).SendKeys(password);
        }

        public void LoginBtnClick()
        {
            //driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/button")).Click();
            //driver.ExecuteJavaScript("document.querySelector('#loginForm button[type=submit]').click()");
            SeleniumActions.ClickOn(driver, "#loginForm button[type=submit]");
        }

    }
}
