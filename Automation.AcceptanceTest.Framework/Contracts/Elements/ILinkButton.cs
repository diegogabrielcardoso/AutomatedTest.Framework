namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface ILinkButton<T> : IUIElementClickable<T>
    {
        T ClickIfExists();
    }
}