using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public int GroupId { get; set; }
        public string  CarRequirement{get;set;}
        public string CarPurpose { get; set; }
        public string Other { get; set; }
        public string IsDistribution { get; set; }
        public string CreateTime { get; set; }
    }
}
