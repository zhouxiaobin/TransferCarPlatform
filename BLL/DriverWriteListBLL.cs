using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class DriverWriteListBLL
    {
        DriverWriteListDAL driverWriteListDAL= new DriverWriteListDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return driverWriteListDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo()
        {
            return driverWriteListDAL.FindAllInfo();
        }


        public bool ExecuteSql(string sql)
        {
            return driverWriteListDAL.ExecuteSql(sql);
        }

        public bool InsertObject(DriverWriteList driverAbnormalNameList)
        {
            return driverWriteListDAL.InsertObject(driverAbnormalNameList);
        }

        public DataTable SelectbyWrierList(DriverWriteList driverWriteList)
        {

            return driverWriteListDAL.SelectbyWrierList(driverWriteList);
        }

        public void UpdateIsUseStatus(int Id,int status)
        {
            driverWriteListDAL.UpdateIsUseStatus(Id, status);
        }
    }
}
