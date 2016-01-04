using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class DriverBlackNameListBLL
    {
        DriverBlackNameListDAL driverBlackNameListDAL = new DriverBlackNameListDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return driverBlackNameListDAL.FindAll_infos(sql);
        }

        public DataTable FindAllInfo()
        {
            return driverBlackNameListDAL.FindAllInfo();
        }

        public DataTable FindObjectByIdentifyNumber(string IdentifyNumber)
        {
            return driverBlackNameListDAL.FindObjectByIdentifyNumber(IdentifyNumber);
        }

        public bool ExecuteSql(string sql)
        {
            return driverBlackNameListDAL.ExecuteSql(sql);
        }
    }
}
