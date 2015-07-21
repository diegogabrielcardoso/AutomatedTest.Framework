using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Custom;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WPFUIItems;
using Application = TestStack.White.Application;
using Panel = TestStack.White.UIItems.Panel;
using Window = TestStack.White.UIItems.WindowItems.Window;

namespace WindowsAppAnalyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Application _app;

        public MainWindow()
        {
            InitializeComponent();
            Closed += MainWindow_Closed;
            PathTextBox.Text =
                @"C:\Users\dcardoso\AppData\Local\Apps\2.0\0MEWO413.CKG\18DJXXD2.YMY\rdm...tion_0000000000000000_0004.0005_da4ba54c45d018db\RDM.exe";
        }


        private void MainWindow_Closed(object sender, EventArgs e)
        {
            if (_app != null)
            {
                _app.Close();
            }
        }



        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            Fill();
        }



        private void Fill()
        {
            WindowTreeview.Items.Clear();
            if (!string.IsNullOrEmpty(PathTextBox.Text))
            {
                _app = Application.AttachOrLaunch(new ProcessStartInfo(PathTextBox.Text));
                var elementList = new List<Element>();
                var index = 0;
                foreach (Window window in _app.GetWindows())
                {
                    WindowTreeview.Items.Add(CreateTreeItem(window, index));
                }
            }
        }

        private void CreateTree(IUIItem parent, Element parentElement)
        {
            var types = (from c in parent.GetMultiple(SearchCriteria.All) select c.GetType()).Distinct();
            var items = from c in parent.GetMultiple(SearchCriteria.All) select c;
            foreach (var type in types)
            {
                var elementType = new Element { Text = type.ToString().Split('.').Last() };
                var index = 0;
                IEnumerable<IUIItem> final;
                if (type == typeof(CustomUIItem))
                {
                    final = items.Where(n => n.GetType() == type);
                }
                else
                {
                    final = parent.GetMultiple(SearchCriteria.ByControlType(type, parent.Framework));
                }
                foreach (var control in final)
                {
                    var childElement = new Element
                    {
                        Text =
                            "[Index: " + index + "] - [ID: " + control.Id + "] - [Coordinates: " +
                            control.Bounds + "]",
                        Target = control
                    };
                    elementType.Elements.Add(childElement);
                    if (type == typeof(Panel) || type == typeof(CustomUIItem))
                    {
                        CreateTree(control, childElement);
                    }
                    index++;
                }
                parentElement.Elements.Add(elementType);
            }
        }

        private TreeViewItem CreateTreeItem(string type, Type control)
        {
            var item = new TreeViewItem();
            item.Header = type;
            item.Tag = control;
            item.Items.Add("Loading...");
            return item;
        }

        private TreeViewItem CreateTreeItem(IUIItem control, int index)
        {
            var item = new TreeViewItem();
            item.Header = "[Index: " + index + "] - [ID: " + control.Id + "] - [Coordinates: " +
                            control.Bounds + "]";
            item.Tag = control;
            try
            {
                switch (control.Framework)
                {
                    case WindowsFramework.None:
                    case WindowsFramework.Silverlight:
                    case WindowsFramework.Swt:
                    case WindowsFramework.Win32:
                    case WindowsFramework.WinForms:
                    case WindowsFramework.Wpf:
                        var types = (from c in control.GetMultiple(SearchCriteria.All) select c.GetType()).Distinct();
                        foreach (var type in types)
                        {
                            item.Items.Add(CreateTreeItem(type.ToString().Split('.').LastOrDefault(), type));
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                
               
            }
            

            return item;
        }


        private void WindowTreeview_OnExpanded(object sender, RoutedEventArgs e)
        {
            var item = e.Source as TreeViewItem;
            if (item.Items.Count == 1 && item.Items[0].ToString() == "Loading...")
            {
                item.Items.Clear();
                var parentItem = (IUIItem)((TreeViewItem)item.Parent).Tag;
                var childs = parentItem.GetMultiple(SearchCriteria.All).Where(n => n.GetType() == (Type)item.Tag);
                var index = 0;
                foreach (var child in childs)
                {
                    item.Items.Add(CreateTreeItem(child, index));
                    index++;
                }
            }
        }
    }
}
