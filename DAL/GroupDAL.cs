using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class GroupDAL
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
            string sql = "select ID ,GroupName  from TB_Group";
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
        public bool InsertObject(Group group) {
            string sql = "insert into TB_Group (GroupName) values ('" + group.GroupName + "')";
            return AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public DataTable selectbyGroupName(Group group)
        {
            string sql = "select * from TB_Group where 1 =1 ";
            if (!string.IsNullOrEmpty(group.GroupName) || group.GroupName != "")
            {
                sql += "and GroupName like'%" + group.GroupName + "%'";
            }
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="group"></param>
        public void UpdateByGroup(Group group)
        {
            string sql = "update TB_Group set GroupName ='" + group.GroupName + "' where id="+group.Id+"";
             AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="group"></param>
        public void DeleteByGroup(Group group)
        {
            string sql = "delete from TB_Group where id=" + group.Id + "";
            AccessHelper.SQLExecute(sql);
        }
    }
}
