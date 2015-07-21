using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class LabelElement : UIElement<LabelElement>
    {
        public LabelElement(UIItemContainer container)
            : base(container)
        {
        }

        public override LabelElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Label),_container.Framework))[index];
            return this;
        }

        public string GetText()
        {
            var label = (Label) this._currentElement;
            return label.Text;
        }
    }
}
