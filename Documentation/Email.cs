using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public enum EmailTypes : byte
    {
        Personal,
        Work
    }
    public class Email
    {
        public EmailTypes emailType;
        public EmailAddress address;
        public Name associatedName;
    }
    public struct EmailAddress
    {
        public string name;
        public string provider;
        public string domainRegister;
    }
}