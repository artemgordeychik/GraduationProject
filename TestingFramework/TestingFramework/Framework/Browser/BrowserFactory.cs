using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TestingFramework.Framework.Browser.Enums;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingFramework.Framework.Browser
{
    class BrowserFactory
    {
        public static IWebDriver SetupDriver(BrowserName browserName)
        {

            switch (browserName)
            {
                case BrowserName.Chrome:
                    return new ChromeDriver(ChromeDriverSetup());
                default:
                    throw new Exception($"You've set {browserName} which is not supported option. Please choose among two options: \n'chrome' \n 'firefox'");
            }
        }

        private static ChromeOptions ChromeDriverSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeOptions();
        }

        private static FirefoxOptions FirefoxDriverSetup()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxOptions();
        }
    }
}

