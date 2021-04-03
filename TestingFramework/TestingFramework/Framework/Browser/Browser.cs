using OpenQA.Selenium;
using System;
using TestingFramework.Framework.Browser.Enums;
using TestingFramework.Framework.Resources;
using TestingFramework.Framework.Utils;

namespace TestingFramework.Framework.Browser
{
    public class Browser
    {
        private static IWebDriver driver;

        private static IWebDriver ForBrowser()
        {
            Enum.TryParse(ConfigurationsWorker.getConfigProperties("browser"), out BrowserName browser);
            if (driver == null)
            {
                driver = BrowserFactory.SetupDriver(browser);
            }
            return driver;
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void Setup()
        {
            driver = ForBrowser();
            Logger.MakeLog("Implicitly waiting");
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public static void Maximize()
        {
            Logger.MakeLog("Maximizing browser");
            GetDriver().Manage().Window.Maximize();
        }
    }
}
