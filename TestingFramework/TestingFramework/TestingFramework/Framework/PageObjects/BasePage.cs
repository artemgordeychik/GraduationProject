using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestingFramework.Extensions;
using TestingFramework.Framework.BrowserUtils;

namespace TestingFramework.Framework.PageObjects
{
    public abstract class BasePage
    {
        public bool IsOpened;
        public By BaseLocator;
        public string nameOfPage;
        public string addressOfPage;

        public BasePage(By locator, string name, string address)
        {
            WebDriverWait downloadingWait = new WebDriverWait(BrowserManager.GetDriver(), TimeSpan.FromSeconds(30));
            downloadingWait.Until(ExpectedConditions.ElementExists(locator));
            IsOpened = BrowserManager.GetDriver().FindElement(locator).Displayed;
            nameOfPage = name;
            addressOfPage = address;
            Logger.MakeLog("Page: " + name + "; address: " + address);
        }

        public BaseForm GoToForm(BaseForm form)
        {
            return form;
        }

        public BaseMenu GoToMenu(BaseMenu menu)
        {
            return menu;
        }

    }
}
