using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FBSI_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isEditable;
        public MainWindow()
        {
            InitializeComponent();
            isEditable = true;
        }//end ctor

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            isEditable = !isEditable;

            //temp code
            nameItem.IsEditable = addressItem.IsEditable = phoneItem.IsEditable = emailItem.IsEditable = isEditable;

            //the commented code below is only meant for the UserControls directly within the scope of hte TestPanel 

            //foreach (var item in TestPanel.Children)
            //{
            //    if (item is UserControl)
            //    {
            //        ((item as UserControl).DataContext as ObservableObject).IsEditable = isEditable;
            //    }
            //}

            //foreach (UserControl item in TestPanel.Children.OfType<UserControl>())
            //{
            //    ObservableObject obsObj = item.DataContext as ObservableObject;
            //    obsObj.IsEditable = isEditable;
            //}
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }//end class
}
