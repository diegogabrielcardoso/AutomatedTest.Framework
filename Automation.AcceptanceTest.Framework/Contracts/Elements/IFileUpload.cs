
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IFileUpload<T> : IUIElementClickable<T>
    {        
        T Upload(string content);
    }
}