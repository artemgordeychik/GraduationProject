using OpenQA.Selenium;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Framework.PageObjects;

namespace СoVTesting.AppStructure.Pages
{
    public class HomePage : BasePage
    {
        private IButton SignInButton => ElementsFactory.GetButton(By.XPath("//a[contains(@class, 'log-in')]"), "Sign In Button");

        public HomePage() : base(By.XPath("//h1[contains(text(), 'HOME')]"), "Home page", "http://localhost:3000/")
        {
        }
        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

        public void GoToAuthorisationPage()
        {
            SignInButton.Click();
        } 
    }
}
