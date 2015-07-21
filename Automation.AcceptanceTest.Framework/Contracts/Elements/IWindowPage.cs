
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IWindowPage<T> : IUIElementBase
    {
        T SwitchToLastWindow();
        T SwitchToWindow(string title);
    }
}