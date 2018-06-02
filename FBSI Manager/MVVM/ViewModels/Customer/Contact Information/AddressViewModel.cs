using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class AddressViewModel : InformationObjectViewModel
    {
        private Address address;
        public Array Types { get => Address.types; }
        public Array States { get => Address.states; }
        public Array Abbreviations { get => Address.abbreviations; }
        public AddressTypes AddressType
        {
            get => address.type;
            set
            {
                if (address.type != value)
                {
                    address.type = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Name
        {
            get => address.name;
            set
            {
                if (address.name != value)
                {
                    address.name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string City
        {
            get => address.city;
            set
            {
                if (address.city != value)
                {
                    address.city = value;
                    OnPropertyChanged();
                }
            }
        }
        public StateTypes State
        {
            get => address.state;
            set
            {
                if (address.state != value)
                {
                    address.state = value;
                    OnPropertyChanged();
                }
            }
        }
        public StateAbbreviationTypes StateCode { get => (StateAbbreviationTypes)(byte)State; }
        public int ZipCode
        {
            get => address.zipcode;
            set
            {
                if (address.zipcode != value)
                {
                    address.zipcode = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FullAddress { get => string.Format($"{Name}, {City} {StateCode}, {ZipCode}"); }

        public AddressViewModel(Address address = null)
        {
            this.address = address ?? new Address();
        }//end ctor
    }//end class
}