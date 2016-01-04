using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Xml;


/// <summary>
/// DataTable与Model转换类
/// </summary>
/// Copyright (c) 2013 海南易建科技股份有限公司
/// 创 建 人：周斌
/// 创建日期：2013/12/19
/// 修 改 人：
/// 修改日期：
namespace DBUtility
{
    public class Common<T> where T : new()
    {
        /// <summary>
        /// 将DataTable转换成Model实体
        /// </summary>
        /// <param name="obj">Model名称</param>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static T Dt2Model(T obj, DataTable dt)
        {
            Type type = obj.GetType();
            PropertyInfo[] pis = type.GetProperties();
            for (int i = 0; i < pis.Length; i++)
            {
                //默认model层的实体类时间采用String格式
                if (dt.Rows[0][pis[i].Name.ToString()].GetType().Name.ToString().ToLower() == "datetime")
                    pis[i].SetValue(obj, dt.Rows[0][pis[i].Name.ToString()].ToString(), null);
                else
                    pis[i].SetValue(obj, dt.Rows[0][pis[i].Name.ToString()], null);
            }
            return (T)obj;
        }

        //public static T DataRow2Model(DataRow dr)
        //{
        //    if (dr == null)
        //    {
        //        return default(T);
        //    }

        //    T model = (T)Activator.CreateInstance(typeof(T));

        //    for (int i = 0; i < dr.Table.Columns.Count; i++)
        //    {
        //        PropertyInfo propertyInfo = model.GetType().GetProperty(dr.Table.Columns[i].ColumnName);

        //        if (propertyInfo != null && dr[i] != DBNull.Value)
        //            propertyInfo.SetValue(model, dr[i], null);
        //        else continue;
        //    }

        //    //foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
        //    //{
        //    //    if (dr.Table.Columns.Contains(propertyInfo.Name) && dr[propertyInfo.Name] != DBNull.Value)
        //    //        propertyInfo.SetValue(model, dr[propertyInfo.Name], null);
        //    //    else continue;
        //    //}
        //    return model;
        //}
        /// <summary>
        /// 将DataTable转换成IList
        /// </summary>
        /// <param name="dt">要转换的DataTable</param>
        /// <returns>返回IList</returns>
        public static IList<T> Dt2List(DataTable dt)
        {
            IList<T> list = new List<T>();
            Type type = typeof(T);
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                PropertyInfo[] propertys = t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    object value = dr[pi.Name];
                    if (value != DBNull.Value)
                    {
                        if(dr[pi.Name].GetType().Name.ToString().ToLower()=="datetime")
                            pi.SetValue(t, value.ToString(), null);
                        else
                            pi.SetValue(t, value, null);
                    }
                }
                list.Add(t);
            }
            return list;
        }

        /// <summary>
        /// 通过反射获得对象名称和自动增长ID
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>返回string[0]类名，string[1]自增ID</returns>
        public static string[] GetModelInfo(T obj)
        {
            string[] str = new string[2];
            Type T = obj.GetType();
            MethodInfo method = T.GetMethod("ReturnAutoID",
                                        BindingFlags.NonPublic
                                        | BindingFlags.Instance,
                                        null, new Type[] { }, null);
            //通过反射执行ReturnAutoID方法，返回AutoID值
            string AutoID = method.Invoke(obj, null).ToString();
            str[0] = T.Name.ToString();
            str[1] = AutoID;
            //返回该Obj的名称以及ReturnAutoID的值
            return str;
        }

        /// <summary>
        /// 获得XML对应name节点的值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetXmlByNode(string name)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("DBCfg.xml");
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("DBConfigure").ChildNodes;
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    XmlElement xe = (XmlElement)xn;
                    XmlNodeList node = xe.ChildNodes;
                    if (node[0].InnerText == name)
                    {//返回数据库字符串
                        return "server=" + node[1].InnerText
                                + ";database=" + Dencrypt(node[2].InnerText)
                                + ";uid=" + Dencrypt(node[3].InnerText)
                                + ";pwd=" + Dencrypt(node[4].InnerText) + ";";
                    }
                }
                return "";
            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public static bool UpdateXmlByNode(string XMLname, string ip, string uid, string pwd, string DBname)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("DBCfg.xml");
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("DBConfigure").ChildNodes;
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    XmlElement xe = (XmlElement)xn;
                    XmlNodeList node = xe.ChildNodes;
                    if (node[0].InnerText == XMLname)
                    {//返回数据库字符串
                        node[1].InnerText = ip;
                        node[2].InnerText = Encrypt(DBname);
                        node[3].InnerText = Encrypt(uid);
                        node[4].InnerText = Encrypt(pwd);
                        break;
                    }
                }
                xmlDoc.Save("DBCfg.xml");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static String Encrypt(String sourceString)
        {
            Char[] sourceArray = sourceString.ToCharArray();
            System.Text.StringBuilder temp = new System.Text.StringBuilder();
            for (Int32 i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = (Char)((sourceArray[i] ^ 'E') - '5');
                temp.Append(sourceArray[i].ToString());
            }
            return temp.ToString();
        }

        public static String Dencrypt(String ciphertext)
        {
            Char[] ciphertextArray = ciphertext.ToCharArray();
            System.Text.StringBuilder temp = new System.Text.StringBuilder();
            for (Int32 i = 0; i < ciphertextArray.Length; i++)
            {
                ciphertextArray[i] = (Char)((ciphertextArray[i] + '5') ^ 'E');
                temp.Append(ciphertextArray[i].ToString());
            }
            return temp.ToString();
        }
    }
}
