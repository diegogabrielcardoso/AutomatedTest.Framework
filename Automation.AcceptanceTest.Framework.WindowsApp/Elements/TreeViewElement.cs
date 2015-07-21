using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UIItems.WPFUIItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class TreeViewElement : UIElement<TreeViewElement>
    {



        public TreeViewElement(UIItemContainer container)
            : base(container)
        {
            
        }

        public override TreeViewElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Tree), _container.Framework))[index];
            return this;
        }

        public TreeViewElement SelectCheckBoxInNodeByText(string text)
        {
            var selected = false;
            foreach (var node in ((Tree)_currentElement).Nodes)
            {
                var checkbox = node.Get<CheckBox>(SearchCriteria.ByControlType(ControlType.CheckBox));
                if (checkbox.Text == text)
                {
                    node.Select();
                    checkbox.Select();
                    selected = true;
                }
                
            }
            if (!selected)
            {
                throw  new Exception("Node not found");
            }
            return this;
        }

        
    }
}
