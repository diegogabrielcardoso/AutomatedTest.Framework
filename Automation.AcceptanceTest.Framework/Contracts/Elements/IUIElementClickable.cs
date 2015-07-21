
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IUIElementClickable<T> : IUIElement<T>
    {
        T Click();
        T DoubleClick();
    }
}

