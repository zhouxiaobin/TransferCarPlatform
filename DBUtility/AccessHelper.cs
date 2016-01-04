using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace DBUtility
{
    public abstract class AccessHelper
    {
        public static string CONNECT_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\translate.accdb";

        OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

        public AccessHelper()
        {
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataSet(string sql)
        {

                OleDbConnection conn = new OleDbConnection(CONNECT_STRING);
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
     
                    da.Fill(ds, "TABLE");

                conn.Close();
                return ds.Tables[0];

        }
       /// <summary>
       /// Access数据库的增删改查
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
        public static bool SQLExecute(string sql)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(CONNECT_STRING);
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                comm.Connection.Close();
                conn.Close();
                return true;
            }
            catch
            {
                throw;

            }
        }

        public static void Access2Excel(string table)
        {
            OleDbConnection con = new OleDbConnection();

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = ("Excel 文件(*.xls)|*.xls");//指定文件后缀名为Excel 文件。  
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFile.FileName;
                if (System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename);//如果文件存在删除文件。  
                }
                int index = filename.LastIndexOf("//");//获取最后一个/的索引  
                filename = filename.Substring(index + 1);//获取excel名称(新建表的路径相对于SaveFileDialog的路径)  
                //select * into 建立 新的表。  
                //[[Excel 8.0;database= excel名].[sheet名] 如果是新建sheet表不能加$,如果向sheet里插入数据要加$.　  
                //sheet最多存储65535条数据。  
                string sql = "select top 65535 *  into   [Excel 8.0;database=" + filename + "].[用户信息] from {0}";
               sql= string.Format(sql, table);
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "//translate.accdb";//将数据库放到debug目录下。  
                OleDbCommand com = new OleDbCommand(sql, con);
                con.Open();
                com.ExecuteNonQuery();

                MessageBox.Show("导出数据成功", "导出数据", MessageBoxButtons.OK, MessageBoxIcon.Information);




                con.Close();
            }
        }
    }
}
