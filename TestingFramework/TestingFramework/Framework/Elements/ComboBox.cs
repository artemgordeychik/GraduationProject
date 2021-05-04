using OpenQA.Selenium.Support.UI;
using Polly;
using System;
using System.Collections.Generic;
using System.Text;
using TestingFramework.Framework.Utils;

namespace TestingFramework.Framework.Elements
{
    class ComboBox
    {
        private SelectElement selectElement;
        public void SelectFromListByIndex(int index)
        {
            Logger.MakeLog("Selecting from " + name + " by index");
            var policy = Policy.Handle<InvalidOperationException>().WaitAndRetry(30, t => TimeSpan.FromSeconds(1));
            policy.Execute(() =>
            {
                selectElement.SelectByIndex(index);
            });
        }

        public void SelectFromlistByText(string text)
        {
            Logger.MakeLog("Selecting from " + name + " by text");
            var policy = Policy.Handle<InvalidOperationException>().WaitAndRetry(30, t => TimeSpan.FromSeconds(1));
            policy.Execute(() =>
            {
                selectElement.SelectByText(text);
            });
        }

        public int GetColOfListElements()
        {
            Logger.MakeLog("Getting number of elements: " + name);
            return selectElement.Options.Count;
        }

        public string GetTextOfSelectedElement()
        {
            Logger.MakeLog("Getting text of selected element from " + name);
            return selectElement.SelectedOption.Text;
        }
    }
}
