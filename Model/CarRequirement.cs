using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CarRequirement
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string CarYaoqiu { get; set; }
        public string CarYongtu { get; set; }
        public string Other { get; set; }
        public string CreatTime { get; set; }
    }
}
