using OpenQA.Selenium;
using System;
using TestingFramework.Framework.Browser.Enums;
using TestingFramework.Framework.Resources;
using TestingFramework.Framework.Utils;

namespace TestingFramework.Framework.BrowserUtils
{
    public class Browser
    {
        private static IWebDriver driver;

        private Browser() 
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
