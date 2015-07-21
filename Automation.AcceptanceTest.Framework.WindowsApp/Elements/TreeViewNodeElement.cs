using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.TreeItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class TreeViewNodeElement : UIElement<TreeViewNodeElement>
    {
        public TreeViewNodeElement(UIItemContainer container)
            : base(container)
        {
        }

        public void FromElement(IUIItem item)
        {
            _currentElement = item;
        }


        public TreeViewNodeElement Select()
        {
            var node = (TreeNode) _currentElement;
            node.Select();
            return this;
        }
    }
}
