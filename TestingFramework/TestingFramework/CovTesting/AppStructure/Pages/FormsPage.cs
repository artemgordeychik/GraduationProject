using OpenQA.Selenium;
using TestingFramework.CovTesting.AppStructure.Forms;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.CovTesting.AppStructure.Pages
{
    class FormsPage// : BaseForm
    {
        private IButton AddFormButton => ElementsFactory.GetButton(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div[2]/div/button"), "Add Form Button");
        private ILabel FormLabel(string formName) => ElementsFactory.GetLabel(By.XPath($"//a[contains(@href, '/forms') and text()='{formName}']"), $"{formName} form label");
        public void ClickAddFormButton()
        {
            AddFormButton.Click();
        }
        public void SelectForm(string form)
        {
            FormLabel(form).Click();
        }

        public AddFormForm  ClickToAddFormButton()
        {
            AddFormButton.Click();
            return new AddFormForm();
        }
    }
}
