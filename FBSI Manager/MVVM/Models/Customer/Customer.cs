using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class Customer
    {
        public IList<Name> names;
        public IList<Address> addresses;
        public IList<Phone> phones;
        public IList<Email> emails;
    }//end class
}