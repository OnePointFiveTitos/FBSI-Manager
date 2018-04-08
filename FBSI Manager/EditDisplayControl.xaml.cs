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
    /// Interaction logic for EditDisplayControl.xaml
    /// </summary>
    public partial class EditDisplayControl : UserControl
    {
        Visibility vis = Visibility.Visible;
        Visibility coll = Visibility.Collapsed;
        public EditDisplayControl()
        {
            InitializeComponent();
        }

        public void ChangeState(bool mode)
        {
            Info.Visibility = mode ? vis : coll;
            Display.Visibility = !mode ? vis : coll;
            Input.Visibility = mode ? vis : coll;
            if (!mode)
            {
                Display.Content = Input.Text;
            }
            else
            {
                Input.Text = Display.Content as string;
            }
        }
    }
}