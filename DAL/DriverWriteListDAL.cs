using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class DriverWriteListDAL
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
            string sql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_WriteList where IsDistribution='0'";
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

        /// <summary>
        /// 新增单个数据
        /// </summary>
        /// <param name="driverAbnormalNameList"></param>
        /// <returns></returns>
        public bool InsertObject(DriverWriteList driverWriteList)
        {
            string sql = "insert into TB_WriteList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,IsDistribution) values('" +
                driverWriteList.User_ChineseName + "','" + driverWriteList.User_EnglishName + "','" + driverWriteList.Department_ChineseName + "','" +
                driverWriteList.Department_EnglishName + "','" + driverWriteList.Job + "','" +
                driverWriteList.Sex + "','" + driverWriteList.Birthdy + "','" +
                driverWriteList.Identification_Type + "','" + driverWriteList.Identification_Number + "','" + driverWriteList.Employer + "','" + driverWriteList.Telephone + "','0')";
            return AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="car"></param>
        public DataTable SelectbyWrierList(DriverWriteList driverWriteList)
        {
            string sql = "select  ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_WriteList where 1=1  ";
            if (!string.IsNullOrEmpty(driverWriteList.User_ChineseName) || driverWriteList.User_ChineseName != "")
            {
                sql += "and User_ChineseName like '%" + driverWriteList.User_ChineseName + "%'";
            }
            if (!string.IsNullOrEmpty(driverWriteList.Identification_Number) || driverWriteList.Identification_Number != "")
            {
                sql += "and Identification_Number  like'%" + driverWriteList.Identification_Number + "%'";
            }
           
            return AccessHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 修改数据是否被使用
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateIsUseStatus(int   Id,int status)
        {
            string sql = "update TB_WriteList set IsDistribution ='" + status + "' where id=" + Id + "";
            AccessHelper.SQLExecute(sql);
        }

   
    }
}
