using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class Name : InformationObject
    {
        public static Array types = Enum.GetValues(typeof(GenerationTypes));
        public GenerationTypes type;
        public string first;
        public string middle;
        public string last;
    }//end class
}