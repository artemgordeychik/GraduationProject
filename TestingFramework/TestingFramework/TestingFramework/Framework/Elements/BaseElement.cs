using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Polly;
using TestingFramework.Framework.BrowserUtils;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Extensions;
using OpenQA.Selenium.Support.UI;

namespace TestingFramework.Framework.Elements
{
    public abstract class BaseElement : IBaseElement
    {
        protected string name;
        protected By selector;
        protected IWebElement element;

        public BaseElement(By nameOfSelector, string nameOfElement)
        {
            selector = nameOfSelector;
            name = nameOfElement;
        }

        public IWebElement GetElement()
        {
            Logger.MakeLog("Getting element: " + name);
            return BrowserManager.GetDriver().FindElement(selector);
        }

        public IReadOnlyCollection<IWebElement> GetElements()
        {
            Logger.MakeLog("Getting elements: " + name);
            return BrowserManager.GetDriver().FindElements(selector);
        }

        public int GetNumberOfElements()
        {
            Logger.MakeLog("Getting number of elements: " + name);
            return BrowserManager.GetDriver().FindElements(selector).Count;
        }

        public bool IsVisible()
        {
            Logger.MakeLog("Check, that " + name + " is visible");
            return GetNumberOfElements() > 0;
        }

        public string GetText()
        {
            Logger.MakeLog("Getting text of element: " + name);
            return GetElement().Text;
        }

        public void WaitForClickable()
        {
            WebDriverWait downloadingWait = new WebDriverWait(BrowserManager.GetDriver(), TimeSpan.FromSeconds(30));
            downloadingWait.Until(ExpectedConditions.ElementToBeClickable(selector));
        }

        public void WaitForVisible()
        {
            WebDriverWait downloadingWait = new WebDriverWait(BrowserManager.GetDriver(), TimeSpan.FromSeconds(30));
            downloadingWait.Until(ExpectedConditions.ElementIsVisible(selector));
        }

        public void WaitForExist()
        {
            WebDriverWait downloadingWait = new WebDriverWait(BrowserManager.GetDriver(), TimeSpan.FromSeconds(30));
            downloadingWait.Until(ExpectedConditions.ElementExists(selector));
        }

        public void Click()
        {
            Logger.MakeLog("Click on " + name);
            var policy = Policy.Handle<InvalidOperationException>().WaitAndRetry(30, t => TimeSpan.FromSeconds(1));
            policy.Execute(() =>
            {
                GetElement().Click();
            });
        }
    }
}
