using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class TabElement : UIElement<TabElement>
    {
        public TabElement(UIItemContainer container)
            : base(container)
        {
        }

        public override TabElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Tab), _container.Framework))[index];
            return this;
        }

        public TabElement Click()
        {
            ((Tab)_currentElement).SelectTabPage(0);
            return this;
        }
    }
}
