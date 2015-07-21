using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class PanelElement : UIElement<PanelElement>
    {

        protected ButtonElement _button;
        protected CheckBoxElement _checkBox;
        protected LabelElement _label;
        protected RadioButtonElement _radioButton;
        protected TextBoxElement _textBox;
        protected ComboBoxElement _comboBox;
        protected ImageElement _image;
        protected TabElement _tab;
        protected TreeViewElement _treeView;
        protected PanelElement _panel;

        public PanelElement(UIItemContainer container) : base(container)
        {
        }

        public override PanelElement GetByIndex(int index)
        {
            _currentElement = _container.GetMultiple(SearchCriteria.ByControlType(typeof(Panel), _container.Framework))[index];
            return this;
        }

        public override PanelElement GetById(string idElement)
        {
            _currentElement = _container.Get<Panel>(idElement);
            _currentElement.Focus();
            _button = null;
            _checkBox = null;
            _label = null;
            _radioButton = null;
            _textBox = null;
            _comboBox = null;
            _image = null;
            _tab = null;
            _treeView = null;
            _panel = null;
            return this;
        }

        public PanelElement Panel()
        {
            return _panel ?? (_panel = new PanelElement((UIItemContainer)_currentElement));
        }

        public TreeViewElement TreeView()
        {
            return _treeView ?? (_treeView = new TreeViewElement((UIItemContainer)_currentElement));
        }

        public TabElement Tab()
        {
            return _tab ?? (_tab = new TabElement((UIItemContainer)_currentElement));
        }

        public ImageElement Image()
        {
            return _image ?? (_image = new ImageElement((UIItemContainer)_currentElement));
        }

        public ButtonElement Button()
        {
            return _button ?? (_button = new ButtonElement((UIItemContainer)_currentElement));
        }

        public CheckBoxElement CheckBox()
        {
            return _checkBox ?? (_checkBox = new CheckBoxElement((UIItemContainer)_currentElement));
        }
        public LabelElement Label()
        {
            return _label ?? (_label = new LabelElement((UIItemContainer)_currentElement));
        }
        public RadioButtonElement RadioButton()
        {
            return _radioButton ?? (_radioButton = new RadioButtonElement((UIItemContainer)_currentElement));
        }
        public TextBoxElement TextBox()
        {
            return _textBox ?? (_textBox = new TextBoxElement((UIItemContainer)_currentElement));
        }
        public ComboBoxElement ComboBox()
        {
            return _comboBox ?? (_comboBox = new ComboBoxElement((UIItemContainer)_currentElement));
        }
    }
}
