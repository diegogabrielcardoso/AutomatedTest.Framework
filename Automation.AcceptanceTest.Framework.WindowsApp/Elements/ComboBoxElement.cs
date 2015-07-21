using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class ComboBoxElement : UIElement<ComboBoxElement>
    {
        public ComboBoxElement(UIItemContainer container)
            : base(container)
        {

        }

        public ComboBoxElement SelectByText(string text)
        {
            var combo = (ComboBox) _currentElement;
            combo.Items.Single(n=>n.Text == text).Select();
            return this;
        }

        public override ComboBoxElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(ComboBox), _container.Framework))[index];
            return this;
        }

        public ComboBoxElement SetText(string text)
        {
            var combo = (ComboBox) _currentElement;
            combo.SetValue(text);
            return this;
        }
    }
}
