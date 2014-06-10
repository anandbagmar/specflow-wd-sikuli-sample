using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using google.test.utilities;
using OpenQA.Selenium;

namespace google.test.Utilities
{
    class PageUtils
    {
        public static void NavigateTo(string url)
        {
            var driver = RuntimeData.Get("driver") as IWebDriver;
            driver.Navigate().GoToUrl(url);
        }
    }
}
