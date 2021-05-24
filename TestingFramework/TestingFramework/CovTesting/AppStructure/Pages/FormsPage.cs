using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Framework.PageObjects;

namespace TestingFramework.CovTesting.AppStructure.Pages
{
    class FormsPage// : BaseForm
    {
        private IButton AddFormButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div[2]/div/button"), "Add Form Button");
    }
}
