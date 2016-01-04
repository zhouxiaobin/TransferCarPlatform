using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class DriverAbnormalNameListBLL
    {
        DriverAbnormalNameListDAL driverAbnormalNameLisDAL = new DriverAbnormalNameListDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return driverAbnormalNameLisDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo()
        {
            return driverAbnormalNameLisDAL.FindAllInfo();
        }


        public bool ExecuteSql(string sql)
        {
            return driverAbnormalNameLisDAL.ExecuteSql(sql);
        }

        public bool InsertObject(DriverAbnormalNameList driverAbnormalNameList)
        {
            return driverAbnormalNameLisDAL.InsertObject(driverAbnormalNameList);
        }
    }
}
