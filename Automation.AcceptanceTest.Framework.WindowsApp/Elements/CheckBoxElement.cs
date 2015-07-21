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
using TestStack.White.UIItems.ListBoxItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class CheckBoxElement : UIElement<CheckBoxElement>
    {
        public CheckBoxElement(UIItemContainer container)
            : base(container)
        {
        }

        public CheckBoxElement Check()
        {
            var check = (CheckBox) _currentElement;
            check.Checked = true;
            return this;
        }

        public override CheckBoxElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(CheckBox), _container.Framework))[index];
            return this;
        }

        public CheckBoxElement UnCheck()
        {
            var check = (CheckBox)_currentElement;
            check.Checked = false;
            return this;
        }

    }
}
