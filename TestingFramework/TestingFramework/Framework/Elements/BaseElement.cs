using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Polly;
using TestingFramework.Framework.Utils;

namespace TestingFramework.Framework.Elements
{
    abstract class BaseElement
    {
        protected string name;
        protected By selector;
        protected IWebElement element;

        public BaseElement(By nameOfSelector, string nameOfElement)
        {selector = nameOfSelector;
            name = nameOfElement;
        }

        public IWebElement GetElement()
        {
            Browser.
            Logger.MakeLog("Getting element: " + name);
            return Browser.GetDriver().FindElement(selector);
        }

        public IReadOnlyCollection<IWebElement> GetElements()
        {
            Logger.MakeLog("Getting elements: " + name);
            return DriverForBrowser.GetDriver().FindElements(selector);
        }

        public int GetNumberOfElements()
        {
            Logger.MakeLog("Getting number of elements: " + name);
            return DriverForBrowser.GetDriver().FindElements(selector).Count;
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
