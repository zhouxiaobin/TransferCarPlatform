using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
  public  class CarRequriedmentDAL
    {
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public DataTable FindAllInfo(int Id)
        {
            string sql = " select  Id,GroupId,CarYaoqiu,CarYongtu,Other from TB_CarRequriedment where GroupId=" + Id + ";";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 新增单个数据
        /// </summary>
        /// <param name="driverAbnormalNameList"></param>
        /// <returns></returns>
        public bool InsertObject(CarRequirement carRequirement)
        {
            string sql = "insert into TB_CarRequriedment (GroupId,CarYaoqiu,CarYongtu,Other) values(" +
                carRequirement.GroupId + ",'" + carRequirement.CarYaoqiu + "','" + carRequirement.CarYongtu + "','" + carRequirement.Other + "' )";
            return AccessHelper.SQLExecute(sql);
        }
      /// <summary>
      /// 删除数据
      /// </summary>
      /// <param name="Id"></param>
      /// <returns></returns>
        public void DeleteCarRequirement(int Id)
        {
            string sql = " delete from TB_CarRequriedment where Id=" + Id + ";";
             AccessHelper.SQLExecute(sql);
        }

      /// <summary>
      /// 修改
      /// </summary>
      /// <param name="carRequirement"></param>
        public void UpdateCarRequirement(CarRequirement carRequirement)
        {
            string sql = "update TB_CarRequriedment set CarYaoqiu ='" + carRequirement.CarYaoqiu + "' ,CarYongtu ='" + carRequirement.CarYongtu + "',Other ='" + carRequirement.Other + "' where id =" + carRequirement .Id+ "";
            AccessHelper.SQLExecute(sql);
        }
    }
}
