using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;
using System.Data.OleDb;

namespace DAL
{
    public class DriverListDAL
    {
        public string CONNECT_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\translate.accdb";
        static string getAllObectSql="select ID ,User_ChineseName ,User_EnglishName ,Department_ChineseName ,Department_EnglishName ,Job ,Sex ,Birthdy ,Identification_Type ,Identification_Number ,Employer ,TELEPHONE  from TB_DriverList";
        DriverBlackNameListDAL driverListDal = new DriverBlackNameListDAL();
        DriverAbnormalNameListDAL driverAbnormalNameListDAL = new DriverAbnormalNameListDAL();
        DriverWriteListDAL driverWriteListDAL = new DriverWriteListDAL();
        /// <summary>
        /// 获取s
        /// </summary>
        /// <returns>返回查询DataTable</returns>
        public DataTable FindAll_infos(string sql)
        {
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

        public DataTable FindAllInfo()
        {
            return AccessHelper.GetDataSet(getAllObectSql);
        }

        /// <summary>
        /// 根据单位查找
        /// </summary>
        /// <returns></returns>
        public DataTable FindByDepartment(string department)
        {
            string sql = "select * from TB_DriverList where Employer like '%" + department + "%'";
            return AccessHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 司机数据比对黑名单数据
        /// </summary>
        public void Compare2BlackNameList()
        {
            OleDbConnection conn = new OleDbConnection(CONNECT_STRING);
            OleDbDataAdapter da = new OleDbDataAdapter(getAllObectSql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLE");
            DataTable dt = ds.Tables["TABLE"];//获得数据集中的第一张表
            for(int i=0;i<dt.Rows.Count;i++)//循环数据表中的每一行
            {
                DataRow dr = dt.Rows[i];
                string Identification_Number = dr["Identification_Number"].ToString();
                if ((driverListDal.FindObjectByIdentifyNumber(Identification_Number)).Rows.Count > 0)
                {
                    DriverAbnormalNameList driverAbnormalNameList = CommonHelper.DataRow2DriverAbnormal(dr);
                    driverAbnormalNameListDAL.InsertObject(driverAbnormalNameList);

                }
                else
                {
                    DriverWriteList driverWriteList = CommonHelper.DataRow2DriverWrite(dr);
                    driverWriteListDAL.InsertObject(driverWriteList);
                }
             }

        }

        /// <summary>
        /// 新增单个数据
        /// </summary>
        /// <param name="driverAbnormalNameList"></param>
        /// <returns></returns>
        public bool InsertObject(DriverWriteList driverWriteList)
        {
            string sql = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,) values('" +
                driverWriteList.User_ChineseName + "','" + driverWriteList.User_EnglishName + "','" + driverWriteList.Department_ChineseName + "','" +
                driverWriteList.Department_EnglishName + "','" + driverWriteList.Job + "','" +
                driverWriteList.Sex + "','" + driverWriteList.Birthdy + "','" +
                driverWriteList.Identification_Type + "','" + driverWriteList.Identification_Number + "','" + driverWriteList.Employer + "','" + driverWriteList.Telephone + "')";
            return AccessHelper.SQLExecute(sql);
        }

        public void DeleteById(int id)
        {
            string sql = "delete from TB_DriverList where id=" + id + "";
            AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 编辑司机数据
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateDriver(DriverList driverList)
        {
            string sql = "update TB_DriverList set ";
            if (!string.IsNullOrEmpty(driverList.User_ChineseName) || driverList.User_ChineseName != "")
            {
                sql += "User_ChineseName='" + driverList.User_ChineseName + "'";
            }
            if (!string.IsNullOrEmpty(driverList.User_EnglishName) || driverList.User_EnglishName != "")
            {
                sql += ",User_EnglishName='" + driverList.User_EnglishName + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Department_ChineseName) || driverList.Department_ChineseName != "")
            {
                sql += ",Department_ChineseName='" + driverList.Department_ChineseName + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Department_EnglishName) || driverList.Department_EnglishName != "")
            {
                sql += ",Department_EnglishName='" + driverList.Department_EnglishName + "'";
            }

            if (!string.IsNullOrEmpty(driverList.Job) || driverList.Job != "")
            {
                sql += ",Job='" + driverList.Job + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Sex) || driverList.Sex != "")
            {
                sql += ",Sex='" + driverList.Sex + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Birthdy) || driverList.Birthdy != "")
            {
                sql += ",Birthdy='" + driverList.Birthdy + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Identification_Type) || driverList.Identification_Type != "")
            {
                sql += ",Identification_Type='" + driverList.Identification_Type + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Identification_Number) || driverList.Identification_Number != "")
            {
                sql += ",Identification_Number='" + driverList.Identification_Number + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Employer) || driverList.Employer != "")
            {
                sql += ",Employer='" + driverList.Employer + "'";
            }
            if (!string.IsNullOrEmpty(driverList.Telephone) || driverList.Telephone != "")
            {
                sql += ",TELEPHONE='" + driverList.Telephone + "'";
            }

            sql += "   where id=" + driverList.Id + "";
            AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 上传更新图片的数据
        /// </summary>
        /// <param name="IdNumber"></param>
        public void UpdateByIdNumber(string IdNumber)
        {
            string sql = "update TB_WriteList set Identification_Number='" + IdNumber + "' where Identification_Number='" + IdNumber + "'";
            AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 删除Id
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public void DeleteByCarId (int Id)
        {
            string sql="delete from TB_Car where id="+Id+"";
            AccessHelper.SQLExecute(sql);
        }

    }
}
