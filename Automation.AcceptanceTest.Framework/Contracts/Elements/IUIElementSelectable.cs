
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IUIElementSelectable<T> : IUIElement<T> 
    {
        T SelectByValue(string value);
        T SelectByIndex(int index);
        T SelectByText(string text);   
    }
}