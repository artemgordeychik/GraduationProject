using OpenQA.Selenium;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.Framework.Elements
{
    public class CheckBox : BaseElement, ICheckBox
    {
        public CheckBox(By nameOfSelector, string nameOfElement) : base(nameOfSelector, nameOfElement)
        { 
        }


    }
}
