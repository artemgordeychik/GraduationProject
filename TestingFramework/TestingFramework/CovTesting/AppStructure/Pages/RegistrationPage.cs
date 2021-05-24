using OpenQA.Selenium;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;
using TestingFramework.Framework.PageObjects;

namespace СoVTesting.AppStructure.Pages
{
    public class RegistrationPage
    {
        private ITextBox UsernameTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='username']"), "Username TextBox");
        private ITextBox EmailTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='email']"), "Email TextBox");
        private ITextBox PasswordTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='password']"), "Password TextBox");
        private ITextBox RepeatPasswordTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='repeatPassword']"), "Repeat password TextBox");
        private IButton SignInButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/form/div[5]/a[1]"), "Sign In Button");
        private IButton SignUpButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/form/div[5]/button"), "Sign Up Button");
        private IButton HomeButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/form/div[5]/a[2]"), "Home Button");
        public void MakeRegistration(string username, string email, string password, string repeatPassword)
        {
            UsernameTextBox.WaitForExist();
            UsernameTextBox.InputValue(username);
            EmailTextBox.InputValue(email);
            PasswordTextBox.InputValue(password);
            RepeatPasswordTextBox.InputValue(repeatPassword);
            SignUpButton.Click();
        }

    }
}
