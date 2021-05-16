using OpenQA.Selenium;
using System;
using TestingFramework.Extensions;
using TestingFramework.Framework.Browser.Enums;
using TestingFramework.Framework.Resources;

namespace TestingFramework.Framework.BrowserUtils
{
    public class BrowserManager
    {
        private static IWebDriver driver;

        private BrowserManager() 
        {
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void Setup()
        {
            driver = CreateBrowserObject();
            Logger.MakeLog("Implicitly waiting");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public static void GoToAddress(string address)
        {
            GetDriver().Navigate().GoToUrl(address);
        }

        public static void Maximize()
        {
            Logger.MakeLog("Maximizing browser");
            driver.Manage().Window.Maximize();
        }

        private static IWebDriver CreateBrowserObject()
        {
            Enum.TryParse(ConfigurationsWorker.getConfigProperties("browser"), out BrowserName browser);
            if (driver == null)
            {
                driver = BrowserFactory.SetupDriver(browser);
            }
            return driver;
        }

        public static void Back()
        {
            Logger.MakeLog("Going back to the last page");
            GetDriver().Navigate().Back();
        }

        public static void Quit()
        {
            Logger.MakeLog("Exit from browser");
            driver.Quit();
            driver = null;
        }
    }
}
