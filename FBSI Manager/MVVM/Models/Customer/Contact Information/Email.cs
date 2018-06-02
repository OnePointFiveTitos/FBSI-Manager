using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public class Email
    {
        public static Array types = Enum.GetValues(typeof(EmailTypes));
        public EmailTypes type;
        public string handle;
        public string domain;
        public string register;
    }//end class
}