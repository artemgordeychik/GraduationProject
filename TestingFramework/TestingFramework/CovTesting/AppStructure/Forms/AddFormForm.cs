using OpenQA.Selenium;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.CovTesting.AppStructure.Forms
{
    class AddFormForm
    {
        private ITextBox NameTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='name']"), "Name TextBox");
        private ITextBox DescriptionTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='description']"), "Description TextBox");
        private ICheckBox AnonymousCheckBox => ElementsFactory.GetCheckBox(By.XPath("//*[@id='modal1']/div[1]/form/div[3]/label[1]/span"), "Anonymous CheckBox");
        private ICheckBox PublicCheckBox => ElementsFactory.GetCheckBox(By.XPath("//*[@id='modal1']/div[1]/form/div[3]/label[2]/span"), "Public CheckBox");
        private IButton AddButton => ElementsFactory.GetButton(By.XPath("//*[@id='modal1']/div[2]/a[1]"), "Add Button");
        private IButton CancelButton => ElementsFactory.GetButton(By.XPath("//*[@id='modal1']/div[2]/a[2]"), "Cancel Button");

        public void InputName(string name)
        {
            NameTextBox.InputValue(name);
        }
        public void InputDescription(string description)
        {
            DescriptionTextBox.InputValue(description);
        }
        public void ClickAnonymousCheckBox()
        {
            AnonymousCheckBox.Click();
        }
        public void ClickPublicCheckBox()
        {
            PublicCheckBox.Click();
        }

        public void ClickAddButton()
        {
            AddButton.Click();
        }
        public void ClickCancelButton()
        {
            CancelButton.Click();
        }
        public void FillForm(string name, string description, bool isAnonymous, bool isPublic)
        {
            NameTextBox.WaitForExist();
            NameTextBox.InputValue(name);
            DescriptionTextBox.InputValue(description);
            if (isAnonymous)
            {
                AnonymousCheckBox.Click();
            }
            if (isPublic)
            {
                PublicCheckBox.Click();
            }
            AddButton.Click();
        }


    }
}
