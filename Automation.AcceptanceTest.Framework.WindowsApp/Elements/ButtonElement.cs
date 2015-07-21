using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Automation.AcceptanceTest.Framework.Contracts.Web;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class ButtonElement : UIElement<ButtonElement>
    {
        public ButtonElement(UIItemContainer container)
            : base(container)
        {
        }

        public ButtonElement Click()
        {
            var button = (Button) _currentElement;
            button.Click();
            return this;
        }

        public override ButtonElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Button), _container.Framework))[index];
            return this;
        }

        public override ButtonElement GetById(string idElement)
        {
            _currentElement = _container.Get<Button>(idElement);
            return this;
        }
    }
}
