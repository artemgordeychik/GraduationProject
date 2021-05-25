using OpenQA.Selenium;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Framework.PageObjects;

namespace TestingFramework.CovTesting.AppStructure.Menues
{
    public class MainMenu : BaseMenu
    {
        private IButton UserButton => ElementsFactory.GetButton(By.XPath("//a[contains(@data-target, 'user-dropdown')]"), "User Button");
        private IButton FormsButton => ElementsFactory.GetButton(By.XPath("//a[contains(@href, 'forms')]"), "Forms Button");
        private IButton ResponsesButton => ElementsFactory.GetButton(By.XPath("//a[contains(@href, 'responses')]"), "Responses Button");

        public string GetUserName()
        {
            return UserButton.GetText();
        }
        public void ClickFormsButton()
        {
            FormsButton.Click();
        }
        public void ClickResponsesButton()
        {
           ResponsesButton.Click();
        }


    }
}
