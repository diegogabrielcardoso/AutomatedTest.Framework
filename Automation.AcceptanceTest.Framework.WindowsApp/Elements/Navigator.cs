using Automation.AcceptanceTest.Framework.Contracts;
using System.Diagnostics;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace Automation.AcceptanceTest.Framework.WindowsApp.Elements
{
    public class Navigator : INavigatorBase
    {
        private Application _runningApp;
        private int _windowId;
        private Window _container;

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

        public Navigator(string applicationExecutable)
        {
            _runningApp = Application.AttachOrLaunch(new ProcessStartInfo(applicationExecutable));
        }

        public Navigator UseWindow(int windowIndex)
        {
            _windowId = windowIndex;
            _container = _runningApp.GetWindows()[windowIndex];
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
            return _panel ?? (_panel = new PanelElement(_container));
        }

        public TreeViewElement TreeView()
        {
            return _treeView ?? (_treeView = new TreeViewElement(_container));
        }

        public TabElement Tab()
        {
            return _tab ?? (_tab = new TabElement(_container));
        }

        public ImageElement Image()
        {
            return _image ?? (_image = new ImageElement(_container));
        }

        public ButtonElement Button()
        {
            return _button ?? (_button = new ButtonElement(_container));
        }

        public CheckBoxElement CheckBox()
        {
            return _checkBox ?? (_checkBox = new CheckBoxElement(_container));
        }
        public LabelElement Label()
        {
            return _label ?? (_label = new LabelElement(_container));
        }
        public RadioButtonElement RadioButton()
        {
            return _radioButton ?? (_radioButton = new RadioButtonElement(_container));
        }
        public TextBoxElement TextBox()
        {
            return _textBox ?? (_textBox = new TextBoxElement(_container));
        }
        public ComboBoxElement ComboBox()
        {
            return _comboBox ?? (_comboBox = new ComboBoxElement(_container));
        }
    }
}
