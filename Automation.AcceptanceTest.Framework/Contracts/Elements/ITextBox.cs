
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface ITextBox<T> : IUIElementClickable<T>
    {        
        T SendKeys(string content);
        T Empty();
    }
}