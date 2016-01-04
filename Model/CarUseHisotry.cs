using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class CarUseHisotry
    {
       public int Id { get; set; }
       public int GroupId { get; set; }
       public string UserName { get; set; }
       public string Telephone { get; set; }
       public string DriverIdNumber { get; set; }
       public string CarIdNumber { get; set; }
       public string CreateTime { get; set; }
    }
}
