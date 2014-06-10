using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace google.test.utilities
{
    class Driver
    {
        private static ChromeDriver _chromeDriver = null;
        public static IWebDriver CreateChromeDriver()
        {
            if (null == _chromeDriver)
            {
                Console.WriteLine("Current directory: " + Directory.GetCurrentDirectory());
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.LeaveBrowserRunning = false;
                _chromeDriver = new ChromeDriver(Directory.GetCurrentDirectory() + @"\\libraries", chromeOptions);
                _chromeDriver.Navigate().GoToUrl("http://www.essenceoftesting.blogspot.com");
            }
            return _chromeDriver;
        }
    }
}
