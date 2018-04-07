using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Fuel_Replacement
{
    public struct Name
    {
        public enum GenerationTypes : byte
        {
            None,
            Jr,
            Sr,
            I,
            II,
            III,
            IV,
            V,
            VI,
            VII,
            VIII,
            IX,
            X
        }
        public bool isMainAssociatedName;
        public string first;
        public string middle;
        public string last;
        public GenerationTypes generation;
    }
}
