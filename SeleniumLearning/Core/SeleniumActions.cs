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
        public static void ClickOn(IWebDriver driver, string selector) //обертка для вызова метода веб-драйвера по выполнению java script в браузере во время теста
        {
            driver.ExecuteJavaScript($"document.querySelector('{selector}').click()"); // интерполяция строки $ показывает, что внутри будут переменные

        }
    }
}

// создаем статический метод ClickOn, который принадлежит самому классу (вызывается на классе, а не объекту класса)

