namespace TestingFramework.Framework.Elements.Interfaces
{
    public interface IComboBox : IBaseElement
    {
        void SelectFromListByIndex(int index);

        void SelectFromlistByText(string text);

        int GetColOfListElements();

        string GetTextOfSelectedElement();
    }
}
