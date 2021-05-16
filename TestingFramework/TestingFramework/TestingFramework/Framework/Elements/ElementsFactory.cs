using OpenQA.Selenium;
using TestingFramework.Framework.Elements.Interfaces;

namespace TestingFramework.Framework.Elements
{
    public static class ElementsFactory
    {
        public static IButton GetButton(By locator, string name)
        {
            return new Button(locator, name);
        }

        public static ICheckBox GetCheckBox(By locator, string name)
        {
            return new CheckBox(locator, name);
        }

        public static IComboBox GetComboBox(By locator, string name)
        {
            return new ComboBox(locator, name);
        }

        public static ILabel GetLabel(By locator, string name)
        {
            return new Label(locator, name);
        }

        public static ITextBox GetTextBox(By locator, string name)
        {
            return new TextBox(locator, name);
        }
    }
}
