using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using Model;

namespace DAL
{
    public class CarDAL
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
            string sql = "select Id ,PlateNumber ,Color ,Brand ,UseYear ,MotorcyleType  from TB_Car where IsDistribution ='0'";
            return AccessHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 根据车牌号查找数据
        /// </summary>
        /// <param name="IdentifyNumber"></param>
        public DataTable FindObjectByPlateNumber(string PlateNumber)
        {
            string sql = "select ID ,PlateNumber ,Color ,Brand ,UseYear ,MotorcyleType  from TB_Car where PlateNumber='" + PlateNumber + "'";
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
        public bool InsertObject(Car car)
        {
            string sql = "insert into TB_Car (PlateNumber,Color,Brand,UseYear,MotorcyleType) values('" +
                car.PlateNumber + "','" + car.Color + "','" + car.Brand + "','" +
                car.UseYear + "','" + car.MotorcyleType + "' )";
            return AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="car"></param>
        public DataTable SelectbyCar(Car car)
        {
            string sql = "select  ID ,PlateNumber,Color ,Brand ,UseYear ,MotorcyleType,CarResource  from TB_Car where 1=1  ";
            if (!string.IsNullOrEmpty(car.PlateNumber) || car.PlateNumber!="")
            {
                sql += "and PlateNumber like '%" + car.PlateNumber + "%'";
            }
            if (!string.IsNullOrEmpty(car.Color) || car.Color != "")
            {
                sql += "and Color like'%" + car.Color + "%'";
            }
            if (!string.IsNullOrEmpty(car.Brand) || car.Brand != "")
            {
                sql += "and Brand like'%" + car.Brand + "%'";
            }
            if (!string.IsNullOrEmpty(car.UseYear) || car.UseYear != "")
            {
                sql += "and UseYear like'%" + car.UseYear + "%'";
            }
            if (!string.IsNullOrEmpty(car.MotorcyleType) || car.MotorcyleType != "")
            {
                sql += "and MotorcyleType like'%" + car.MotorcyleType + "%'";
            }
            if (!string.IsNullOrEmpty(car.CarResource) || car.CarResource != "")
            {
                sql += "and CarResource like'%" + car.CarResource + "%'";
            }
            return AccessHelper.GetDataSet(sql);
        }

        public void UpdateIsUseStatus(int Id,int status)
        {
            string sql = "update TB_Car set IsDistribution ='" + status + "' where id=" + Id + "";
            AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 编辑司机数据
        /// </summary>
        /// <param name="Id"></param>
        public void UpdateCar(Car car)
        {
            string sql = "update TB_Car set ";
            if (!string.IsNullOrEmpty(car.PlateNumber) || car.PlateNumber != "")
            {
                sql += "PlateNumber='" + car.PlateNumber + "'";
            }
            if (!string.IsNullOrEmpty(car.Color) || car.Color != "")
            {
                sql += ",Color='" + car.Color + "'";
            }
            if (!string.IsNullOrEmpty(car.Brand) || car.Brand != "")
            {
                sql += ",Brand='" + car.Brand + "'";
            }
            if (!string.IsNullOrEmpty(car.UseYear) || car.UseYear != "")
            {
                sql += ",UseYear='" + car.UseYear + "'";
            }
            if (!string.IsNullOrEmpty(car.MotorcyleType) || car.MotorcyleType != "")
            {
                sql += ",MotorcyleType='" + car.MotorcyleType + "'";
            }
            if (!string.IsNullOrEmpty(car.CarResource) || car.CarResource != "")
            {
                sql += ",CarResource='" + car.CarResource + "'";
            }

            sql += "   where id=" + car.Id + "";
            AccessHelper.SQLExecute(sql);
        }

        /// <summary>
        /// 删除Id
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public void DeleteByCarId(int Id)
        {
            string sql = "delete from TB_Car where id=" + Id + "";
            AccessHelper.SQLExecute(sql);
        }
    }
}
