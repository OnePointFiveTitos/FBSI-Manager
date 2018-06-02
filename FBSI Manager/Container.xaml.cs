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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FBSI_Manager
{
    /// <summary>
    /// Interaction logic for Container.xaml
    /// </summary>
    public partial class Container : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private bool isHorizontal;
        public bool IsHorizontal
        {
            get => isHorizontal;
            set
            {
                isHorizontal = value;
                OnPropertyChanged();
            }
        }
        private bool isVertical;
        public bool IsVertical
        {
            get => isVertical;
            set
            {
                isVertical = value;
                OnPropertyChanged();
            }
        }
        public Container()
        {
            InitializeComponent();
            isHorizontal = true;
            IsVertical = !isHorizontal;
        }

        private void AddName_Click(object sender, RoutedEventArgs e)
        {
            Names.Children.Add(new NameView()
            {
                IsHorizontal = IsHorizontal,
                IsVertical = IsVertical
            });
        }

        private void AddAddress_Click(object sender, RoutedEventArgs e)
        {
            Addresses.Children.Add(new AddressView()
            {
                IsHorizontal = IsHorizontal,
                IsVertical = IsVertical
            });
        }

        private void AddPhone_Click(object sender, RoutedEventArgs e)
        {
            Phones.Children.Add(new PhoneView()
            {
                IsHorizontal = IsHorizontal,
                IsVertical = IsVertical
            });
        }

        private void AddEmail_Click(object sender, RoutedEventArgs e)
        {
            Emails.Children.Add(new EmailView()
            {
                IsHorizontal = IsHorizontal,
                IsVertical = IsVertical
            });
        }

        private void OrientationItem_Click(object sender, RoutedEventArgs e)
        {
            IsHorizontal = !IsHorizontal;
            isVertical = !IsVertical;

            List<UIElementCollection> panels = new List<UIElementCollection>()
            {
                Names.Children,
                Addresses.Children,
                Phones.Children,
                Emails.Children
            };

            foreach (var collection in panels)
            {
                foreach (var item in collection)
                {
                    ((item as UserControl).DataContext as ObservableObject).ChangeOrientation();
                }
            }
        }
    }
}
