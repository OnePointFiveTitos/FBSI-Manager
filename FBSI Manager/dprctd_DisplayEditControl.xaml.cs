using System;
using System.Collections.Generic;
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
    /// Interaction logic for DisplayEditControl.xaml
    /// </summary>
    public partial class DisplayEditControl : UserControl
    {
        public DisplayEditControl()
        {
            InitializeComponent();
        }

        private void Display_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Display.Visibility = Visibility.Collapsed;
            Edit.Visibility = Visibility.Visible;
            Edit.Text = Display.Content as string;
            Edit.Focus();
        }

        private void Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Display.Visibility = Visibility.Visible;
                Edit.Visibility = Visibility.Collapsed;
                Display.Content = Edit.Text;
            }
        }

        private void Edit_LostFocus(object sender, RoutedEventArgs e)
        {
            Display.Visibility = Visibility.Visible;
            Edit.Visibility = Visibility.Collapsed;
            Display.Content = Edit.Text;
        }
    }
}