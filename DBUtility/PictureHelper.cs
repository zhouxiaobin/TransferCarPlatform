using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Model;
using System.Drawing;
using System.Data;


namespace DBUtility
{
    public static class PictureHelper
    {
        public static void MemoryImage( DriverList driverList)
        {
          
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            command.CommandText = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,Photo,CensusRegister,CurrentResidence)  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            command.Parameters.AddWithValue("@User_ChineseName", driverList.User_EnglishName);
            command.Parameters.AddWithValue("@User_EnglishName", driverList.Department_EnglishName);
            command.Parameters.AddWithValue("@Department_ChineseName", driverList.Department_ChineseName);
            command.Parameters.AddWithValue("@Department_EnglishName", driverList.Department_EnglishName);
            command.Parameters.AddWithValue("@Job", driverList.Job);
            command.Parameters.AddWithValue("@Sex", driverList.Sex);
            command.Parameters.AddWithValue("@Birthdy", driverList.Birthdy);
            command.Parameters.AddWithValue("@Identification_Type", driverList.Identification_Type);
            command.Parameters.AddWithValue("@Identification_Number", driverList.Identification_Number);
            command.Parameters.AddWithValue("@Employer", driverList.Employer);
            command.Parameters.AddWithValue("@TELEPHONE", driverList.Employer);
            command.Parameters.AddWithValue("@Photo", driverList.Photo);
            command.Parameters.AddWithValue("@CensusRegister", driverList.CensusRegister);
            command.Parameters.AddWithValue("@CurrentResidence", driverList.CensusRegister);

            command.Connection = conn;

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }

        /// <summary>
        /// 上传图片byIdNumber
        /// </summary>
        /// <param name="Idnumber"></param>
        /// <param name="date"></param>
        public static void UpdateImage(string Idnumber, byte[] date)
        {
              OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "update TB_DriverList set Photo=@Photo where Identification_Number='" + Idnumber + "'";
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
           // command.CommandText = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,Photo,CensusRegister,CurrentResidence)  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";

            command.Parameters.AddWithValue("@Photo", date);


            command.Connection = conn;

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }
        /// <summary>
        /// 更新byId
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="date"></param>
        public static void UpdateById(string Id, byte[] date)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "update TB_DriverList set Photo=@Photo where Id=" + Id + "";
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            // command.CommandText = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,Photo,CensusRegister,CurrentResidence)  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";

            command.Parameters.AddWithValue("@Photo", date);


            command.Connection = conn;

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }

        public static byte[] ExportImage(int Id,string tableName,string columName)
        {
            DataSet ds = new DataSet();  
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "select * from " + tableName + " where Id=" + Id + "";
            command.Connection = conn;
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            try
            {
                //ds = new DataSet();  
                conn.Open();
                adapter.Fill(ds, "picture");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.Close();
                command = null;
                adapter = null;
            }

            byte[] data = (byte[])ds.Tables["picture"].Rows[0][columName];
            return data;
           
        }

        /// <summary>
        /// 存储汽车图片
        /// </summary>
        /// <param name="car"></param>
        public static void MemoryCarImage(Car car)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            command.CommandText = "insert into TB_Car (PlateNumber,Color,Brand,UseYear,MotorcyleType,CarResource,CarPicture)  values(@PlateNumber,@Color,@Brand,@UseYear,@MotorcyleType,@CarResource,@CarPicture)";
            command.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
            command.Parameters.AddWithValue("@Color", car.Color);
            command.Parameters.AddWithValue("@Brand", car.Brand);
            command.Parameters.AddWithValue("@UseYear", car.UseYear);
            command.Parameters.AddWithValue("@MotorcyleType", car.MotorcyleType);
            command.Parameters.AddWithValue("@CarResource", car.CarResource);
            command.Parameters.AddWithValue("@CarPicture", car.CarPicture);
        

            command.Connection = conn;

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }

        /// <summary>
        /// 上传汽车图片by车牌号
        /// </summary>
        /// <param name="Idnumber"></param>
        /// <param name="date"></param>
        public static void UpdateImageByPlateNumber(string PlateNumber, byte[] date)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "update TB_Car set CarPicture=@CarPicture where PlateNumber='" + PlateNumber + "'";
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            // command.CommandText = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,Photo,CensusRegister,CurrentResidence)  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";

            command.Parameters.AddWithValue("@CarPicture", date);


            command.Connection = conn;

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }

        /// <summary>
        /// 更新byId
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="date"></param>
        public static void UpdateByCarId(string Id, byte[] date)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "update TB_Car set CarPicture=@CarPicture where Id=" + Id + "";
            //command.CommandText = "insert into TB_DriverList  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";
            // command.CommandText = "insert into TB_DriverList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE,Photo,CensusRegister,CurrentResidence)  values(@User_ChineseName,@User_EnglishName,@Department_ChineseName,@Department_EnglishName,@Job,@Sex,@Birthdy,@Identification_Type,@Identification_Number,@Employer,@TELEPHONE,@Photo,@CensusRegister,@CurrentResidence)";

            command.Parameters.AddWithValue("@CarPicture", date);
            command.Connection = conn;
            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            command = null;
        }
    }
}
