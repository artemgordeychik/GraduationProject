using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.Framework.Elements
{
    public class Button : BaseElement, IButton
    {
        public Button(By nameOfSelector, string nameOfElement) : base(nameOfSelector, nameOfElement)
        {

        }
    }
}
