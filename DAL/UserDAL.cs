using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class UserDAL
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
        public DataTable FindAllInfo(int groupId)
        {
            string sql = "select ID ,UserName as 用户名,Telephone as 联系方式 from TB_User where GroupId=" + groupId + "";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据车牌号查找数据
        /// </summary>
        /// <param name="IdentifyNumber"></param>
        public DataTable FindObjectById(User user)
        {
            string sql = "select ID ,UserName as 用户名,Telephone as 联系方式 from TB_User where Id=" + user.Id + "";
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
        public bool InsertObject(User user)
        {
            string sql = "insert into TB_User (UserName,Telephone,GroupId,CreateTime) values('" +
                user.UserName + "','" + user.Telephone + "',"+user.GroupId+",'"+user.CreateTime+"' )";
            return AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="car"></param>
        public DataTable SelectbyUser(User user)
        {
            string sql = "select * from TB_User where 1=1  ";
            if (!string.IsNullOrEmpty(user.UserName) || user.UserName != "")
            {
                sql += "and UserName like '%" + user.UserName + "%'";
            }
            if (!string.IsNullOrEmpty(user.Telephone) || user.Telephone != "")
            {
                sql += "and Telephone like '%" + user.Telephone + "%'";
            }
            if (user.Id != 0) {
                sql += "and id=" + user.Id + "";
            }
            sql += "and GroupId=" + user.GroupId + "";
            return AccessHelper.GetDataSet(sql);
        }

        public void UpdateUser(User user)
        {
            string sql = "update  TB_User set CarRequirement ='" + user.CarRequirement + "',CarPurpose='"+
                user.CarPurpose + "',Other='"+user.Other+"' where id="+user.Id+"";
         
             AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 通过Id修改名字和联系方式
        /// </summary>
        /// <param name="user"></param>
        public void UpDateUserbyId(User user)
        { 
            string sql="update TB_User set UserName='"+user.UserName+"',Telephone ='"+user.Telephone+"' where id="+user.Id+"";
            AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 修改数据是否被使用
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateIsUseStatus(int Id)
        {
            string sql = "update TB_User set IsDistribution ='1' where id=" + Id + "";
            AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 删除数据byId
        /// </summary>
        /// <param name="Id"></param>
        public void DeleteById(int Id)
        {
            string sql = "delete from  TB_User where Id=" + Id + "";
            AccessHelper.SQLExecute(sql);
        }
    }
}
