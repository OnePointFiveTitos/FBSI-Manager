using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class Phone
    {
        public static Array types = Enum.GetValues(typeof(PhoneTypes));
        public PhoneTypes type;
        public int areacode;
        public int prefix;
        public int line;
        public int extension;
    }//end class
}