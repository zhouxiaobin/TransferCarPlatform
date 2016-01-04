using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class DriverWriteList:Driver
    {
        public string IsDistribution { get; set; }
    }
}
