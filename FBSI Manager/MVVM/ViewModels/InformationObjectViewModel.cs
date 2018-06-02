using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class InformationObjectViewModel : ObservableObject
    {
        private InformationObject infoObj;
        public bool IsMain
        {
            get => infoObj.isMain;
            set
            {
                if (IsMain != value)
                {
                    infoObj.isMain = value;
                    OnPropertyChanged();
                }
            }
        }
        public Name PrimaryName
        {
            get => infoObj.AssociatedName;
            set
            {
                if (PrimaryName != value)
                {
                    infoObj.AssociatedName = value;
                    OnPropertyChanged();
                }
            }
        }

        public InformationObjectViewModel()
        {
            infoObj = new InformationObject();
        }
    }//end class
}