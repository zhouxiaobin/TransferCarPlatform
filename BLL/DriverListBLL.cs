using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
  public  class DriverListBLL
    {
      DriverListDAL driverListDAL = new DriverListDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return driverListDAL.FindAll_infos(sql);
        }

        public DataTable FindAllInfo()
        {
            return driverListDAL.FindAllInfo();
        }

        public bool ExecuteSql(string sql)
        {
            return driverListDAL.ExecuteSql(sql);
        }

        public void Compare2BlackNameList()
        {
             driverListDAL.Compare2BlackNameList();
        }

        public void DeleteById(int id)
        {
            driverListDAL.DeleteById(id);
        }

        public void UpdateDriver(DriverList driverList)
        {
            driverListDAL.UpdateDriver(driverList);
        }

        public void UpdateByIdNumber(string IdNumber)
        {
            driverListDAL.UpdateByIdNumber(IdNumber);
        }

        public DataTable FindByDepartment(string department)
        {
            return    driverListDAL.FindByDepartment(department);
        }
    }
}
