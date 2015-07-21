using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.AcceptanceTest.Framework.Contracts.Web;
using TestStack.White;
using TestStack.White.UIItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public abstract class UIElementClickable<T> : UIElement<T>, IUIElementClickable<T>
        where T : UIElementClickable<T>
    {
        protected UIElementClickable(UIItemContainer container)
            : base(container)
        {
        }

        public T DoubleClick()
        {
            _currentElement.DoubleClick();
            return (T)this;
        }

        public T Click()
        {
            _currentElement.Click();
            return (T)this;
        }
    }
}
