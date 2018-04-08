using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public enum GenerationTypes : byte
    {
        None,
        Jr,
        Sr,
        II,
        III,
        IV,
        V
    }
    public enum CustomerStandingTypes : byte
    {
        New,
        Good,
        Bad,
        Asshole,
        Angel
    }
    public class Name
    {
        public string first;
        public string middle;
        public string last;
        public GenerationTypes generationType;
        public CustomerStandingTypes customerStandingType;
    }
}