using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DBUtility;
using System.Data;

namespace DAL
{
   public class CarUseHisotryDAL
    {
        /// <summary>
        /// 新增单个数据
        /// </summary>
        /// <param name="driverAbnormalNameList"></param>
        /// <returns></returns>
       public bool InsertObject(CarUseHisotry carUseHisotry)
        {
            string sql = "insert into TB_CarUseHisotry (GroupId,UserName,Telephone,DriverIdNumber,CarIdNumber,CreateTime) values(" +
                carUseHisotry.GroupId + ",'" + carUseHisotry.UserName + "','" + carUseHisotry.Telephone + "','" + carUseHisotry.DriverIdNumber + "','" +
                carUseHisotry.CarIdNumber + "','" + carUseHisotry.CreateTime + "' )";
            return AccessHelper.SQLExecute(sql);
        }

       /// <summary>
       /// 根司机身份证查找数据
       /// </summary>
       /// <param name="IdentifyNumber"></param>
       public DataTable FindObjectByDriverIdNumber(string DriverIdNumber)
       {
           string sql = "select GroupId,UserName,Telephone,DriverIdNumber,CarIdNumber from TB_CarUseHisotry where DriverIdNumber=" + DriverIdNumber + "";
           return AccessHelper.GetDataSet(sql);
       }
       /// <summary>
       /// 根车牌号查找数据
       /// </summary>
       /// <param name="IdentifyNumber"></param>
       public DataTable FindObjectByCarIdNumber(string CarIdNumber)
       {
           string sql = "select GroupId,UserName,Telephone,DriverIdNumber,CarIdNumber from TB_CarUseHisotry where DriverIdNumber=" + CarIdNumber + "";
           return AccessHelper.GetDataSet(sql);
       }
    }
}
