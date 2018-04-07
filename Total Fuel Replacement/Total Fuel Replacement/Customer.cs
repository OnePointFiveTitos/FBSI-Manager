using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Fuel_Replacement
{


    /// <summary>
    /// Customer class will contain smaller substructs and classes. It'll be the main data container for all customer information. GUI elements will be handled separately
    /// </summary>
    class Customer
    {
        public Name mainName; 
        public List<Name> associatedNames;
        public List<Address> addresses;
        public Contact contact; //one contact instance contains one or more phones and/or emails
        public StringBuilder notes;
    }
}