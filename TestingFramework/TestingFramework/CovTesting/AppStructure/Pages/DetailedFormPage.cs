using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.CovTesting.AppStructure.Pages
{
    class DetailedFormPage
    {
        private IButton EditFormButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div[2]/button[1]"), "Edit Form Button");
        private IButton DeleteFormButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div[2]/button[2]"), "Delete Form Button");
        private IButton AddFieldButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div[2]/div/button"), "Add field Button");
    }
}
