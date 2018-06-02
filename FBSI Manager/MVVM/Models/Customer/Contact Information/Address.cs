using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class Address
    {
        public static Array types = Enum.GetValues(typeof(AddressTypes));
        public static Array states = Enum.GetValues(typeof(StateTypes));
        public static Array abbreviations = Enum.GetValues(typeof(StateAbbreviationTypes));
        public AddressTypes type;
        public string name;
        public string city;
        public StateTypes state;
        public int zipcode;
    }//end class
}