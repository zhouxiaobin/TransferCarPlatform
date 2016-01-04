using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    public class CarBLL
    {
         CarDAL carDAL = new CarDAL();
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos(string sql)
        {
            return carDAL.FindAll_infos(sql);
        }
        public DataTable FindAllInfo()
        {
            return carDAL.FindAllInfo();
        }


        public bool ExecuteSql(string sql)
        {
            return carDAL.ExecuteSql(sql);
        }

        public bool InsertObject(Car car)
        {
            return carDAL.InsertObject(car);
        }
        public DataTable SelectbyCar(Car car)
        {
            return  carDAL.SelectbyCar(car);
        }
        public void UpdateIsUseStatus(int Id,int status)
        {
            carDAL.UpdateIsUseStatus(Id, status);
        }
        public void UpdateCar(Car car)
        {
            carDAL.UpdateCar(car);
        }
        public void DeleteByCarId(int Id)
        {
            carDAL.DeleteByCarId(Id);
        }
    }
}
