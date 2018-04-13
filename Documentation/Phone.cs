using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public enum PhoneTypes : byte
    {
        Home,
        Work,
        Mobile,
        Fax
    }
    public class Phone
    {
        public PhoneTypes phoneType;
        public PhoneNumber number;
        public Name associatedName;
    }
    public struct PhoneNumber
    {
        public int areaCode;
        public int prefix;
        public int lineNumber;
        public int extension;
    }
}