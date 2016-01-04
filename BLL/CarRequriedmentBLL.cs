using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Model;


namespace BLL
{
   public class CarRequriedmentBLL
    {
       CarRequriedmentDAL carRequriedmentDAL = new CarRequriedmentDAL();
         /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
       public DataTable FindAllInfo(int Id)
       {
         return    carRequriedmentDAL.FindAllInfo(Id);
       }

       /// <summary>
       /// 新增单个数据
       /// </summary>
       /// <param name="driverAbnormalNameList"></param>
       /// <returns></returns>
       public bool InsertObject(CarRequirement carRequirement)
       {
           return carRequriedmentDAL.InsertObject(carRequirement);
       }

       /// <summary>
       /// 删除数据
       /// </summary>
       /// <param name="Id"></param>
       /// <returns></returns>
       public void DeleteCarRequirement(int Id)
       {
           string sql = " delete from TB_CarRequriedment where Id=" + Id + ";";
            carRequriedmentDAL.DeleteCarRequirement(Id);
       }
       /// <summary>
       /// 修改数据
       /// </summary>
       /// <param name="carRequirement"></param>
       public void UpdateCarRequirement(CarRequirement carRequirement)
       {
           carRequriedmentDAL.UpdateCarRequirement(carRequirement);
       }
    }
}
