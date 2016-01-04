using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class ManageCarRequiredmentDAL
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
            string sql = "    select a.Id as managerId,c.Id as managerDriverId,d.Id as manageCarId, UserName as 姓名,CarYaoqiu as 用车需求,GroupName as 分组名称,User_ChineseName as 中文名称,Identification_Number as 身份证号,Brand as 汽车品牌,PlateNumber as 车牌号 from ((TB_ManageCarRequiredment a inner join TB_Group b on a.GroupId=b.Id ) inner join TB_WriteList c on a.DriverId=c.ID)  inner join TB_Car d on a.CarId=D.Id";
           // string sql = " select a.UserName,a.CarRequriedment,b.GroupName from TB_ManageCarRequiredment a left join TB_Group b on a.GroupId=b.Id";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 双击选择分组成员编辑信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable FindManageCustomer(int id)
        {
            string sql = "select UserName as 姓名,CarYaoqiu as 用车需求,GroupName as 分组名称,User_ChineseName as 中文名称,Identification_Number as 身份证号,Brand as 汽车品牌,PlateNumber as 车牌号 from ((TB_ManageCarRequiredment a inner join TB_Group b on a.GroupId=b.Id ) inner join TB_WriteList c on a.DriverId=c.ID)  inner join TB_Car d on a.CarId=D.Id where GroupId=" + id + "";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据条件进行查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable FindManageCustomerByTiaojian(string carName,string requirement)
        {

            string sql = "select UserName as 姓名,CarYaoqiu as 用车需求,GroupName as 分组名称,User_ChineseName as 中文名称,Identification_Number as 身份证号,Brand as 汽车品牌,PlateNumber as 车牌号 from ((TB_ManageCarRequiredment a inner join TB_Group b on a.GroupId=b.Id ) inner join TB_WriteList c on a.DriverId=c.ID)  inner join TB_Car d on a.CarId=D.Id where 1=1";
            if (!string.IsNullOrEmpty(carName) || carName != "")
            {
                sql += "and Brand like '%" + carName + "%'";
            }
            if (!string.IsNullOrEmpty(requirement) || requirement != "")
            {
                sql += "and CarRequriedment like '%" + requirement + "%'";
            }
            return AccessHelper.GetDataSet(sql);
        }
        /// <summary>
        /// 根据主键号查找数据
        /// </summary>
        /// <param name="IdentifyNumber"></param>
        public DataTable FindObjectById(ManageCarRequiredment manageCarRequiredment)
        {
            string sql = "select ID ,UserName as 用户名,GroupId as 关联的分组id,CarId as 关联车辆,DriverId as 关联司机,CarYaoqiu as 用车需求 from TB_ManageCarRequiredment where Id=" + manageCarRequiredment.Id + "";
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
        public bool InsertObject(ManageCarRequiredment manageCarRequiredment)
        {
            string sql = "insert into TB_ManageCarRequiredment (UserName,CarId,DriverId,GroupId,CreateTime,CarYaoqiu,CarYongtu,Other) values('" +
                manageCarRequiredment.UserName + "'," + manageCarRequiredment.CarId + "," + manageCarRequiredment.DriverId + "," + manageCarRequiredment.GroupId + ",'" + manageCarRequiredment.CreateTime + "','" + manageCarRequiredment.CarYaoqiu + "','" + manageCarRequiredment.CarYongtu + "','" + manageCarRequiredment.Other + "' )";
            return AccessHelper.SQLExecute(sql);
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="manageCarRequiredment"></param>
        /// <returns></returns>
        public bool DeleteObject(ManageCarRequiredment manageCarRequiredment)
        {
            string sql = "delete  from TB_ManageCarRequiredment where id=" + manageCarRequiredment.Id + "";
            return AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="car"></param>
        public DataTable SelectbyManageCarRequiredment(ManageCarRequiredment manageCarRequiredment)
        {
            string sql = "select * from TB_ManageCarRequiredment where 1=1  ";
            if (!string.IsNullOrEmpty(manageCarRequiredment.UserName) || manageCarRequiredment.UserName != "")
            {
                sql += "and UserName='" + manageCarRequiredment.UserName + "'";
            }
            if ( manageCarRequiredment.DriverId != 0)
            {
                sql += "and DriverId=" + manageCarRequiredment.DriverId + "";
            }
            if (manageCarRequiredment.GroupId != 0)
            {
                sql += "and GroupId=" + manageCarRequiredment.GroupId + "";
            }
            if (manageCarRequiredment.CarId != 0)
            {
                sql += "and CarId=" + manageCarRequiredment.CarId + "";
            }
            if (!string.IsNullOrEmpty(manageCarRequiredment.CarYaoqiu) || manageCarRequiredment.CarYaoqiu != "")
            {
                sql += "and CarRequriedment='" + manageCarRequiredment.CarYaoqiu + "'";
            }
            return AccessHelper.GetDataSet(sql);
        }

        public void UpdateManageCarRequiredment(ManageCarRequiredment manageCarRequiredment)
        {
            string sql = "update  TB_ManageCarRequiredment set UserName ='" + manageCarRequiredment.UserName + "',GroupId=" +
                manageCarRequiredment.GroupId + ",DriverId=" + manageCarRequiredment.DriverId + ",CarRequriedment ='" + manageCarRequiredment.CarYaoqiu +
                "' where id=" + manageCarRequiredment.Id + "";
         
             AccessHelper.SQLExecute(sql);
        }

    }
}
