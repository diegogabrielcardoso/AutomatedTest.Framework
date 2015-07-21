
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IFrame<T> : IUIElement<T>
    {
        T SwitchToFrame(string nameFrame);
        T SwitchToFrame(int indexFrame);
        T SwitchToDefault();
    }
}