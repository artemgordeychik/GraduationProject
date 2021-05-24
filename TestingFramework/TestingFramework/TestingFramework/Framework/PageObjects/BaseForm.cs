using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestingFramework.Framework.BrowserUtils;

namespace TestingFramework.Framework.PageObjects
{
    public abstract class BaseForm
    {
        public bool IsOpened;
        public By BaseLocator;

        public BaseForm(By locator)
        {
            WebDriverWait downloadingWait = new WebDriverWait(BrowserManager.GetDriver(), TimeSpan.FromSeconds(30));
            downloadingWait.Until(ExpectedConditions.ElementExists(locator));
            IsOpened = BrowserManager.GetDriver().FindElement(locator).Displayed;
        }

    }
}
