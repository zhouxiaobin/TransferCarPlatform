using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;

namespace DBUtility
{
    public static class CommonHelper
    {
       
        public static DriverAbnormalNameList DataRow2DriverAbnormal(DataRow dr)
        {
            DriverAbnormalNameList driverAbnormalNameList = new DriverAbnormalNameList();
            //driverAbnormalNameList.User_ChineseName = dr["中文"].ToString();
            //driverAbnormalNameList.User_EnglishName = dr["英文"].ToString();
            //driverAbnormalNameList.Department_ChineseName = dr["单位名称中文"].ToString();
            //driverAbnormalNameList.Department_EnglishName = dr["单位名称英文"].ToString();
            // driverAbnormalNameList.Job=dr["职务"].ToString();
            // driverAbnormalNameList.Sex=dr["性别"].ToString();
            // driverAbnormalNameList.Birthdy=dr["出生日期"].ToString();
            // driverAbnormalNameList.Identification_Type=dr["身份证件类型"].ToString();
            // driverAbnormalNameList.Identification_Number=dr["身份证件号码"].ToString();
            // driverAbnormalNameList.Employer=dr["工作单位"].ToString();
            // driverAbnormalNameList.Telephone=dr["联系方式"].ToString();

            driverAbnormalNameList.User_ChineseName = dr["User_ChineseName"].ToString();
            driverAbnormalNameList.User_EnglishName = dr["User_EnglishName"].ToString();
            driverAbnormalNameList.Department_ChineseName = dr["Department_ChineseName"].ToString();
            driverAbnormalNameList.Department_EnglishName = dr["Department_EnglishName"].ToString();
            driverAbnormalNameList.Job = dr["Job"].ToString();
            driverAbnormalNameList.Sex = dr["Sex"].ToString();
            driverAbnormalNameList.Birthdy = dr["Birthdy"].ToString();
            driverAbnormalNameList.Identification_Type = dr["Identification_Type"].ToString();
            driverAbnormalNameList.Identification_Number = dr["Identification_Number"].ToString();
            driverAbnormalNameList.Employer = dr["Employer"].ToString();
            driverAbnormalNameList.Telephone = dr["Telephone"].ToString();
             return driverAbnormalNameList;
        }
        public static DriverWriteList DataRow2DriverWrite(DataRow dr)
        {
            DriverWriteList driverWriteList = new DriverWriteList();
            //driverWriteList.User_ChineseName = dr["中文"].ToString();
            //driverWriteList.User_EnglishName = dr["英文"].ToString();
            //driverWriteList.Department_ChineseName = dr["单位名称中文"].ToString();
            //driverWriteList.Department_EnglishName = dr["单位名称英文"].ToString();
            //driverWriteList.Job = dr["职务"].ToString();
            //driverWriteList.Sex = dr["性别"].ToString();
            //driverWriteList.Birthdy = dr["出生日期"].ToString();
            //driverWriteList.Identification_Type = dr["身份证件类型"].ToString();
            //driverWriteList.Identification_Number = dr["身份证件号码"].ToString();
            //driverWriteList.Employer = dr["工作单位"].ToString();
            //driverWriteList.Telephone = dr["联系方式"].ToString();

            driverWriteList.User_ChineseName = dr["User_ChineseName"].ToString();
            driverWriteList.User_EnglishName = dr["User_EnglishName"].ToString();
            driverWriteList.Department_ChineseName = dr["Department_ChineseName"].ToString();
            driverWriteList.Department_EnglishName = dr["Department_EnglishName"].ToString();
            driverWriteList.Job = dr["Job"].ToString();
            driverWriteList.Sex = dr["Sex"].ToString();
            driverWriteList.Birthdy = dr["Birthdy"].ToString();
            driverWriteList.Identification_Type = dr["Identification_Type"].ToString();
            driverWriteList.Identification_Number = dr["Identification_Number"].ToString();
            driverWriteList.Employer = dr["Employer"].ToString();
            driverWriteList.Telephone = dr["Telephone"].ToString();
            return driverWriteList;
        }
    }
}
