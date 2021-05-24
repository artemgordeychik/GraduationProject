using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingFramework.Framework.Elements;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.CovTesting.AppStructure.Forms
{
    class AddFieldForm
    {
        private ITextBox YourQuestionTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='label']"), "Your question TextBox");
        private ITextBox DescriptionTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='description']"), "Description TextBox");
        private ITextBox OrderPriorityTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='orderNumber']"), "Order priority TextBox");
        private ICheckBox ActiveCheckBox => ElementsFactory.GetCheckBox(By.XPath("//*[@id='modal2']/div[1]/form/div[4]/label[1]/span"), "Active CheckBox");
        private ICheckBox RequiredCheckBox => ElementsFactory.GetCheckBox(By.XPath("//*[@id='modal2']/div[1]/form/div[4]/label[2]/span"), "Required CheckBox");
        private ICheckBox VisibleCheckBox => ElementsFactory.GetCheckBox(By.XPath("//*[@id='modal2']/div[1]/form/div[4]/label[3]/span"), "Visible CheckBox");
        private IComboBox QuestionTypeComboBox => ElementsFactory.GetComboBox(By.XPath("//*[@id='modal2']/div[1]/form/div[5]/div/input"), "Question type ComboBox");
        private ITextBox OptionTextBox => ElementsFactory.GetTextBox(By.XPath("//*[@id='option']"), "Option TextBox");
        private IButton AddButton => ElementsFactory.GetButton(By.XPath("//*[@id='modal2']/div[2]/a[1]"), "Add Button");
        private IButton CancelButton => ElementsFactory.GetButton(By.XPath("//*[@id='modal2']/div[2]/a[2]"), "Cancel Button");

        public void InputYourQuestion(string question)
        {
            YourQuestionTextBox.InputValue(question);
        }
        public void InputDescription(string description)
        {
            DescriptionTextBox.InputValue(description);
        }
        public void InputOrderPriority(int priority)
        {
            OrderPriorityTextBox.InputValue(priority.ToString());
        }
        public void ClickActiveCheckBox()
        {
            ActiveCheckBox.Click();
        }
        public void ClickRequiredCheckBox()
        {
            RequiredCheckBox.Click();
        }
        public void ClickVisibleCheckBox()
        {
            VisibleCheckBox.Click();
        }
        public void SelectFieldType(string type)
        {
            QuestionTypeComboBox.SelectFromlistByText(type);
        }
       
        public void InputOption(string option)
        {
            OptionTextBox.InputValue(option);
        }

        public void ClickAddButton()
        {
            AddButton.Click();
        }
        public void ClickCancelButton()
        {
            CancelButton.Click();
        }
    }
}
