using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingFramework.Framework.Elements.Interfaces
{
    public interface IBaseElement
    {
        IWebElement GetElement();

        IReadOnlyCollection<IWebElement> GetElements();

        int GetNumberOfElements();

        bool IsVisible();

        string GetText();

        void WaitForClickable();

        void WaitForVisible();

        void WaitForExist();
        void Click();
    }
}
