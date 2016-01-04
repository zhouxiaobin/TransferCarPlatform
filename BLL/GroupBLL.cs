using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class GroupBLL
    {
        GroupDAL groupDAL = new GroupDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return groupDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo()
        {
            return groupDAL.FindAllInfo();
        }


        public bool ExecuteSql(string sql)
        {
            return groupDAL.ExecuteSql(sql);
        }

        public bool InsertObject(Group group)
        {
            return groupDAL.InsertObject(group);
        }

        public DataTable selectbyGroupName(Group group)
        {
            return groupDAL.selectbyGroupName(group);
        }

        public void UpdateByGroup(Group group)
        {
            groupDAL.UpdateByGroup(group);
        }
        public void DeleteByGroup(Group group)
        {
            groupDAL.DeleteByGroup(group);
        }
    }
}
