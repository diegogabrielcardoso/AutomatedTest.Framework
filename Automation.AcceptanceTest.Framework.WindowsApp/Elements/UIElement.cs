using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.AcceptanceTest.Framework.Contracts.Web;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public abstract class UIElement<T> :
        IUIElement<T>
        where T : UIElement<T>
    {
        #region global_variables
        protected IUIItem _currentElement = null;
        protected UIItemContainer _container;

        #endregion

        #region constructors
        public UIElement(UIItemContainer container)
        {
            _container = container;
        }
        #endregion

        #region internal_methods


        #endregion

        #region public_methods
        public T GetByCss(string cssLocator)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(string idElement)
        {
            _currentElement = _container.Get<IUIItem>(idElement);
            return (T)this;
        }

        public virtual T GetByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public T GetByLinkText(string text)
        {
            throw new NotImplementedException();
        }
        public T GetByName(string nameElement)
        {
            throw new NotImplementedException();
        }

        public T GetByTagName(string tagName)
        {
            throw new NotImplementedException();
        }
        public T GetByXPath(string xPathQuery)
        {
            throw new NotImplementedException();
        }
        public T SendKeySpace()
        {
            throw new NotImplementedException();
        }
        public T GetChildBy(string tagName, string nameToSearch = "", string valueToSearch = "", int? index = null)
        {
            throw new NotImplementedException();
        }

        public bool Exists()
        {
            try
            {
                return this._currentElement != null;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
