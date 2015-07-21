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
    public class RadioButtonElement : UIElement<RadioButtonElement>
    {
        public RadioButtonElement(UIItemContainer container)
            : base(container)
        {
        }

        public RadioButtonElement Check()
        {
            var radio = (RadioButton)_currentElement;
            radio.Select();
            return this;
        }

        public override RadioButtonElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(RadioButton), _container.Framework))[index];
            return this;
        }

        public override RadioButtonElement GetById(string idElement)
        {
            _currentElement = _container.Get<RadioButton>(idElement);
            return this;
        }
    }
}
