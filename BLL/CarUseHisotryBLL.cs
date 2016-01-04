using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
   public class CarUseHisotryBLL
    {

       CarUseHisotryDAL carUseHisotryDAL = new CarUseHisotryDAL();
       public void InsertObject(CarUseHisotry carUseHisotry)
       {
            carUseHisotryDAL.InsertObject(carUseHisotry);
       }
       public DataTable FindObjectByDriverIdNumber(string DriverIdNumber)
       {
           return carUseHisotryDAL.FindObjectByDriverIdNumber(DriverIdNumber);
       }

       public DataTable FindObjectByCarIdNumber(string CarIdNumber)
       {
           return carUseHisotryDAL.FindObjectByDriverIdNumber(CarIdNumber);
       }
    }
}
