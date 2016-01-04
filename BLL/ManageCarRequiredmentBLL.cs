using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    public class ManageCarRequiredmentBLL
    {
        ManageCarRequiredmentDAL manageCarRequiredmentDAL = new ManageCarRequiredmentDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return manageCarRequiredmentDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo()
        {
            return manageCarRequiredmentDAL.FindAllInfo();
        }


        public bool ExecuteSql(string sql)
        {
            return manageCarRequiredmentDAL.ExecuteSql(sql);
        }

        public bool InsertObject(ManageCarRequiredment manageCarRequiredment)
        {
            return manageCarRequiredmentDAL.InsertObject(manageCarRequiredment);
        }
        public DataTable SelectbyUser(ManageCarRequiredment manageCarRequiredment)
        {
            return manageCarRequiredmentDAL.SelectbyManageCarRequiredment(manageCarRequiredment);
        }
        public void UpdateUser(ManageCarRequiredment manageCarRequiredment)
        {
            manageCarRequiredmentDAL.UpdateManageCarRequiredment(manageCarRequiredment);
        }
        public DataTable FindManageCustomer(int id)
        {
          return  manageCarRequiredmentDAL.FindManageCustomer(id);
        }
        public DataTable FindManageCustomerByTiaojian(string carName, string requirement)
        {
            return manageCarRequiredmentDAL.FindManageCustomerByTiaojian(carName, requirement);
        }
        public bool DeleteObject(ManageCarRequiredment manageCarRequiredment)
        {
            return manageCarRequiredmentDAL.DeleteObject(manageCarRequiredment);
        }
    }
}
