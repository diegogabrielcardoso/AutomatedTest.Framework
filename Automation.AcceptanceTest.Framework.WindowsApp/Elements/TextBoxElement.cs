using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.WindowsAPI;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class TextBoxElement : UIElementClickable<TextBoxElement>
    {
        public TextBoxElement(UIItemContainer container)
            : base(container)
        {
        }

        public override TextBoxElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(TextBox), _container.Framework))[index];
            return this;
        }

        public TextBoxElement SendSpecialKey(KeyboardInput.SpecialKeys key)
        {
            var textbox = (TextBox)_currentElement;
            textbox.KeyIn(key);
            return this;
        }

        public TextBoxElement SetText(string value)
        {
            var textbox = (TextBox) _currentElement;
            textbox.Text = value;
            return this;
        }

    }
}
