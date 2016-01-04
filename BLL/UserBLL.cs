using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return userDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo(int groupId)
        {
            return userDAL.FindAllInfo(groupId);
        }


        public bool ExecuteSql(string sql)
        {
            return userDAL.ExecuteSql(sql);
        }

        public bool InsertObject(User user)
        {
            return userDAL.InsertObject(user);
        }
        public DataTable SelectbyUser(User user)
        {
            return userDAL.SelectbyUser(user);
        }
        public void UpdateUser(User user)
        {
             userDAL.UpdateUser(user);
        }

        public void UpdateIsUseStatus(int Id)
        {
            userDAL.UpdateIsUseStatus(Id);
        }
        public void UpDateUserbyId(User user)
        {
            userDAL.UpDateUserbyId(user);
        }
        public void DeleteById(int Id)
        {
            userDAL.DeleteById(Id);
        }
    }
}
