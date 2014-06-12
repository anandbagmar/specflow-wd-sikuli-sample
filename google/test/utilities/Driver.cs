using System;
using System.Drawing.Imaging;
using System.IO;
using google.test.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace google.test.utilities
{
    class Driver
    {
        private static ChromeDriver _chromeDriver;

        public static IWebDriver CreateChromeDriver()
        {
            Console.WriteLine("\tCreate Chrome Driver");
            if (null == RuntimeData.Get("driver"))
            {
                Console.WriteLine("\tDriver NOT created yet. Creating a new instance of the Chrome Driver.");
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.LeaveBrowserRunning = true;
                chromeOptions.AddArgument("test-type");
                chromeOptions.AddArgument("--start-maximized");

                DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
                capabilities.SetCapability(ChromeOptions.Capability, chromeOptions);

                _chromeDriver = new ChromeDriver(Directory.GetCurrentDirectory() + @"\\libraries", chromeOptions);
                _chromeDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
                RuntimeData.Save("driver", _chromeDriver);
                _chromeDriver.Navigate().GoToUrl("http://www.essenceoftesting.blogspot.com");
            }
            return RuntimeData.Get("driver") as ChromeDriver;
        }

        public static void CloseChromeDriver()
        {
            Console.WriteLine("\tClose Chrome Driver");
            _chromeDriver = RuntimeData.Get("driver") as ChromeDriver;
            if (_chromeDriver != null) _chromeDriver.Quit();
            RuntimeData.Remove("driver");
        }

        public static void TakeScreenShot(string fileName)
        {
            ITakesScreenshot _screenshotDriver = RuntimeData.Get("driver") as ITakesScreenshot;
            Screenshot screenshot = _screenshotDriver.GetScreenshot();
            string absoluteFilePath = Directory.GetCurrentDirectory() + @"\" + FileUtils.UniqueFileName(fileName) + ".png";
            Console.WriteLine("\tSaved screenshot: " + absoluteFilePath);
            screenshot.SaveAsFile(absoluteFilePath, ImageFormat.Png);
        }
    }
}
