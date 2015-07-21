using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class ImageElement : UIElement<ImageElement>
    {
        public ImageElement(UIItemContainer container)
            : base(container)
        {
        }

        public override ImageElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Image), _container.Framework))[index];
            return this;
        }

        public ImageElement Click()
        {
            _currentElement.Click();
            return this;
        }

    }
}
