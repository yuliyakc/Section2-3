using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Cast;
using OpenQA.Selenium.Support.Extensions;
using SeleniumLearning.Core;
using SeleniumLearning.Pages_Epson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Pages
{
    public class ProductListEpson : BaseEpsonPage
    {
        private const string PAGE_URL = "https://epson-gb.cbnd-seikoepso3-s1-public.model-t.cc.commerce.ondemand.com/en_GB/products/printers/c/printers";
        
        public ProductListEpson(IWebDriver dr) : base(dr, PAGE_URL) { }

    }
}
