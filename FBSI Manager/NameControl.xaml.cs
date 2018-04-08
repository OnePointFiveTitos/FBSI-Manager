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
    /// Interaction logic for NameControl.xaml
    /// </summary>
    public partial class NameControl : UserControl
    {
        bool inEditMode;
        Visibility vis = Visibility.Visible;
        Visibility coll = Visibility.Collapsed;
        string[] infos = { "First:", "Middle:", "Last:" };
        public NameControl()
        {
            InitializeComponent();
            inEditMode = false;
            PopulateControls();
            Generation.ItemsSource = Manager.GenerationTypes;
        }
        void PopulateControls()
        {
            for (int i = 0; i < infos.Length; i++)
            {
                EditDisplayControl ctrl = new EditDisplayControl();
                ctrl.Info.Content = infos[i];
                ctrl.Display.Content = "n/a";
                Controls.Children.Add(ctrl);
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            inEditMode = !inEditMode;

            Primary.Visibility = inEditMode ? vis : coll;
            PrimaryLabel.Content = (bool)Primary.IsChecked ? "Primary" : "Associated";
            PrimaryLabel.Visibility = !inEditMode ? vis : coll;

            Generation.Visibility = inEditMode ? vis : coll;
            GenerationLabel.Content = Generation.SelectedItem;
            GenerationLabel.Visibility = !inEditMode ? vis : coll;

            foreach (var item in Controls.Children)
            {
                if (item is EditDisplayControl)
                {
                    (item as EditDisplayControl).ChangeState(inEditMode);
                }
            }
        }
    }
}