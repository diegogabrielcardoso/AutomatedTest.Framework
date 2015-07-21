
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IJavaScriptAlert<T> 
    {
        T Acept(string message);
        T Dismiss(string message);
    }
}

