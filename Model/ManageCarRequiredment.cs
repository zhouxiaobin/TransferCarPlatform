using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ManageCarRequiredment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int GroupId { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }
        public string CreateTime { get; set; }
        public string CarYaoqiu { get; set; }
        public string CarYongtu { get; set; }
        public string Other { get; set; }
    }
}
