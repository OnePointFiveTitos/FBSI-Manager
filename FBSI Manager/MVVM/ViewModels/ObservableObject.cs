using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class ObservableObject : INotifyPropertyChanged
    {
        private bool isEditable;
        public bool IsEditable
        {
            get => isEditable;
            set
            {
                if (isEditable != value)
                {
                    isEditable = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool isHorizontal;
        public bool IsHorizontal
        {
            get => isHorizontal;
            set
            {
                if (isHorizontal != value)
                {
                    isHorizontal = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool isVertical;
        public bool IsVertical
        {
            get => isVertical;
            set
            {
                if (isVertical != value)
                {
                    isVertical = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableObject()
        {
            isEditable = true;
            isHorizontal = true;
            IsVertical = !isHorizontal;
        }//end ctor
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));//end
        public void ChangeOrientation()
        {
            IsHorizontal = !IsHorizontal;
            IsVertical = !IsVertical;
        }//end
    }//end class
}