using OpenQA.Selenium;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.Framework.Elements
{
    public class Label : BaseElement, ILabel
    {
        public Label (By nameOfSelector, string nameOfElement) : base(nameOfSelector, nameOfElement)
        { 
        }
    }
}
