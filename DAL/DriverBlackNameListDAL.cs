using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class DriverBlackNameListDAL
    {
        /// <summary>
        /// 获取s
        /// </summary>
        /// <returns>返回查询DataTable</returns>
        public DataTable FindAll_infos(string sql)
        {
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public DataTable FindAllInfo()
        {
            string sql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList ";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据身份证查找数据
        /// </summary>
        /// <param name="IdentifyNumber"></param>
        public DataTable FindObjectByIdentifyNumber(string IdentifyNumber)
        {
            string sql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList where Identification_Number='" + IdentifyNumber + "'";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 增删改查
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ExecuteSql(string sql)
        {
            return AccessHelper.SQLExecute(sql); 
        }


    }
}
