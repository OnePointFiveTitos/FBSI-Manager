using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class PhoneViewModel : InformationObjectViewModel
    {
        private Phone phone;
        public Array Types { get => Phone.types; }
        public PhoneTypes PhoneType
        {
            get => phone.type;
            set
            {
                if (phone.type != value)
                {
                    phone.type = value;
                    OnPropertyChanged();
                }
            }
        }
        public int AreaCode
        {
            get => phone.areacode;
            set
            {
                if (phone.areacode != value)
                {
                    phone.areacode = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Prefix
        {
            get => phone.prefix;
            set
            {
                if (phone.prefix != value)
                {
                    phone.prefix = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Line
        {
            get => phone.line;
            set
            {
                if (phone.line != value)
                {
                    phone.line = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Extension
        {
            get => phone.extension;
            set
            {
                if (phone.extension != value)
                {
                    phone.extension = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FullNumber { get => string.Format($"{AreaCode}-{Prefix}-{Line}; Ext: {Extension}"); }

        public PhoneViewModel(Phone phone = null)
        {
            this.phone = phone ?? new Phone();
        }//end ctor
    }//end class
}