using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using DBUtility;

namespace WindowsFormCase
{
    public partial class DBConfig : Form
    {
        public DBConfig()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //检查连接串是否可用并保存代码
            if (SqlConnFun("one", this.TxtIP.Text.Trim(), this.TxtUid.Text.Trim(), this.TxtPwd.Text.Trim(), this.TxtDBName.Text.Trim()))
            {
                MessageBox.Show("保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败，请检查连接串后重试！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //窗体加载初始配置
        private void DBConfig_Load(object sender, EventArgs e)
        {
            GetXmlByNode("one");
        }
        //获得name为one的数据库连接串信息
        public void GetXmlByNode(string name)
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
                        this.TxtIP.Text = node[1].InnerText;
                        this.TxtDBName.Text = Common<object>.Dencrypt(node[2].InnerText);
                        this.TxtUid.Text = Common<object>.Dencrypt(node[3].InnerText);
                        this.TxtPwd.Text = Common<object>.Dencrypt(node[4].InnerText);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        ///检查连接串是能够使用，并且保存
        /// </summary>
        /// <returns>返回是否保存成功</returns>
        public bool SqlConnFun(string XMLname, string ip, string uid, string pwd, string DBname)
        {
            string sqlconn_str = "server=" + ip + ";database=" + DBname + ";uid=" + uid + ";pwd=" + pwd + ";";
            SqlConnection sqlconn = new SqlConnection(sqlconn_str);
            try
            {
                sqlconn.Open();
                sqlconn.Close();
                return Common<object>.UpdateXmlByNode(XMLname, ip, uid, pwd, DBname);
            }
            catch (Exception e)
            {
                sqlconn.Close();
                return false;
            }
        }
        
    }
}
