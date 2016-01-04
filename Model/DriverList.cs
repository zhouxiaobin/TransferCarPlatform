using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class DriverList:Driver
    {
        public byte[] Photo { get; set; }
        public string CensusRegister { get; set; }
        public string CurrentResidence { get; set; }
    }
}
