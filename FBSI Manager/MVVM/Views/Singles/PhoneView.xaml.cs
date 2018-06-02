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
    /// Interaction logic for PhoneView.xaml
    /// </summary>
    public partial class PhoneView : UserControl
    {
        private PhoneViewModel dataContext = new PhoneViewModel();
        public bool IsEditable
        {
            get => dataContext.IsEditable;
            set => dataContext.IsEditable = value;
        }
        public bool IsVertical
        {
            get => dataContext.IsVertical;
            set => dataContext.IsVertical = value;
        }
        public bool IsHorizontal
        {
            get => dataContext.IsHorizontal;
            set => dataContext.IsHorizontal = value;
        }
        public PhoneView()
        {
            InitializeComponent();
            DataContext = dataContext;
        }//end ctor
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            IsEditable = !IsEditable;
        }//end
    }//end class
}