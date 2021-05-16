using OpenQA.Selenium;
using TestingFramework.Extensions;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.Framework.Elements
{
    class TextBox : BaseElement, ITextBox
    {
        public TextBox(By nameOfSelector, string nameOfElement) : base(nameOfSelector, nameOfElement)
        {
        }

        public void InputValue(string value)
        {          
            Logger.MakeLog("Getting number of elements: " + name);
            GetElement().Clear();
            GetElement().SendKeys(value);
        }
    }
}
