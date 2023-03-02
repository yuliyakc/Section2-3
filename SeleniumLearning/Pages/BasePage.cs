using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver; // создаем поле driver c типом IWebDriver
        public string pageURL;
       
        public BasePage(IWebDriver driver, string pageUrl)
        {
            this.driver = driver;
            this.pageURL = pageUrl;
        }

    }
}
