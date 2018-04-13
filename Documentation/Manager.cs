using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBSI_Manager
{
    public static class Manager
    {
        public static Array GenerationTypes = Enum.GetValues(typeof(GenerationTypes));
        public static Array CustomerStandingTypes = Enum.GetValues(typeof(CustomerStandingTypes));
    }
}