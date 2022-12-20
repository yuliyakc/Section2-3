using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirst
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        
        }

        [Test]
        public void Test1()
        {

            driver.Url = "https://orient-gb.cbnd-seikoepso3-s2-public.model-t.cc.commerce.ondemand.com/orientstorefront/en_GB";


        }
    }
}
