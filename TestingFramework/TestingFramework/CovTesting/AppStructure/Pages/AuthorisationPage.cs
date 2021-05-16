using OpenQA.Selenium;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Framework.PageObjects;

namespace СoVTesting.AppStructure.Pages
{
    public class AuthorisationPage : BasePage
    {
        private ITextBox LoginTextBox => ElementsFactory.GetTextBox(By.Id("username"), "Login Text Box");
        private ITextBox PasswordTextBox => ElementsFactory.GetTextBox(By.XPath("//input[@id='password']"), "Password Text Box");
        private IButton SignInButton => ElementsFactory.GetButton(By.XPath("//button[contains(@type, 'submit')]"), "Sign In Button");
        private IButton SignUpButton => ElementsFactory.GetButton(By.XPath("//a[contains(text(), 'SIGN UP')]"), "Sign Up Button");
        private IButton HomeButton => ElementsFactory.GetButton(By.XPath("//a[contains(text(), 'HOME')]"), "Home Button");

        public AuthorisationPage() : base(By.Id("username"), "Authorisation page", "http://localhost:3000/signIn") 
        { 
        }

        public void MakeAuthorisation(string login, string password)
        {
            LoginTextBox.WaitForExist();
            LoginTextBox.InputValue(login);
            PasswordTextBox.InputValue(password);
            SignInButton.Click();
        }

        public HomePage GoToHomePage()
        {
            HomeButton.WaitForClickable();
            HomeButton.Click();
            return new HomePage();
        }

        public RegistrationPage GoToRegistrationPage()
        {
            SignUpButton.WaitForClickable();
            SignUpButton.Click();
            return new RegistrationPage();
        }
    }
}
