using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Core
{
    public static class SeleniumActions
    {
        public static void ClickOn(IWebDriver driver, string selector)
        {
            driver.ExecuteJavaScript($"document.querySelector('{selector}').click()");

        }
    }
}
