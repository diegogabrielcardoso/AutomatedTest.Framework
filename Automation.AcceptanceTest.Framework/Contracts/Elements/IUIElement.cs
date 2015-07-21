
namespace Automation.AcceptanceTest.Framework.Contracts.Web
{
    public interface IUIElement<T> : IUIElementBase
    {
        T GetByName(string nameElement);
        T GetByLinkText(string nameElement);
        T GetById(string idElement);
        T GetByCss(string cssLocator);
        T GetByXPath(string xPathQuery);
        T SendKeySpace();
    }
}

