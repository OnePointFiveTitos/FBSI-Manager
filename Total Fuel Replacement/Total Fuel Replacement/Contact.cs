using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Fuel_Replacement
{
    public class Contact
    {
        public struct Phone
        {
            public enum PhoneTypes : byte
            {
                Home,
                Mobile,
                Work,
                Fax,
            }
            public int areaCode; //631
            public int prefix; //265
            public int lineNumber; //2002
            public int extension;
            public bool isMainContact;
            public bool isMainPhone;
            public bool isCallPreferred;
            public bool isTextPreferred;
            public PhoneTypes type;
            public Name associatedName;
        }

        public struct Email
        {
            public enum EmailTypes : byte
            {
                Personal,
                Work,
                Business
            }
            public string email; //johndoe
            public string domain; //outlook
            public string register; //.com .net .org
            public bool isMainContact;
            public bool isMainEmail;
            public EmailTypes type;
            public Name associatedName;
        }
    }
}