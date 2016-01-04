using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using BLL;
using System.Configuration;
using DBUtility;
using Model;
using System.IO;
using TestLog4Net;
using System.Text.RegularExpressions;

namespace TransferCarPlatform
{
    public partial class Form1 : Form
    {
        //public static string CONNECT_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\translate.accdb";
        public static string CONNECT_STRING = string.Format(ConfigurationManager.ConnectionStrings["connecteAddress"].ToString(), AppDomain.CurrentDomain.BaseDirectory);
        public static string sheetName = ConfigurationManager.AppSettings["sheetName"].ToString();
        DriverListBLL driverListBll = new DriverListBLL();
        DriverBlackNameListBLL driverBlackNameListBLL = new DriverBlackNameListBLL();
        DriverAbnormalNameListBLL driverAbnormalNameListBLL = new DriverAbnormalNameListBLL();
        DriverWriteListBLL driverWriteListBLL = new DriverWriteListBLL();
        string[] FileNames;
        SummaryForm summaryForm = new SummaryForm();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnWriterData_Click(object sender, EventArgs e)
        {
            //dgvBlackList.dat
            //dgvBlackList.Columns.Clear();
            if (txtBlackList.Text.Length == 0)
            {
                MessageBox.Show("请选择导入数据的Execl文件");
            }
            else
            {
                Excel2Access(FileNames);
            }
        }


        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel文件(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                this.txtBlackList.Text = filePath;
            }
            FileNames = dlg.FileNames;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvBlackList.AutoGenerateColumns = false;


                string getblacklistsql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList ";

                try
                {
                    DataTable dtDriverList = driverListBll.FindAll_infos(getblacklistsql);
                    dgvBlackList.DataSource = dtDriverList;
                    
                }
                catch (Exception ex)
                {
                   // LogHelper.WriteLog(typeof(Form1), "初始化黑名单错误 :" + ex.Message);
                    MessageBox.Show("初始化黑名单错误 :");
                }

               
                dgvBlackList.Rows[0].Selected = false;


                //LogHelper.WriteLog(typeof(Form1), "初始化黑名单错误 :" + ex.Message);
             

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "delete * from  TB_BlacakList ";

            driverListBll.ExecuteSql(sql);
            string getblacklistsql = "select * from TB_BlacakList ";
            DataTable dtDriverList = driverListBll.FindAll_infos(getblacklistsql);

            dgvBlackList.DataSource = dtDriverList;
        }

        /// <summary>
        /// Excel导入Access
        /// </summary>
        public void Excel2Access(string[] filenames)
        {
            try
            {
                for (int j = 0; j < filenames.Length; j++)
                {
                    OleDbConnectionStringBuilder connectStringBuilder = new OleDbConnectionStringBuilder();
                    connectStringBuilder.DataSource = filenames[j];
                    connectStringBuilder.Provider = "Microsoft.Jet.Oledb.4.0";
                    connectStringBuilder.Add("Extended Properties", "Excel 8.0");
                    using (OleDbConnection cn = new OleDbConnection(connectStringBuilder.ConnectionString))
                    {
                        DataSet ds = new DataSet();
                        string sql = string.Format("select * from [{0}$]", sheetName);
                        OleDbCommand cmdLiming = new OleDbCommand(sql, cn);
                        cn.Open();
                        using (OleDbDataReader dr = cmdLiming.ExecuteReader())
                        {
                            ds.Load(dr, LoadOption.OverwriteChanges, new string[] { sheetName });
                            DataTable dt = ds.Tables[sheetName];
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 4; i < dt.Rows.Count; i++)
                                {

                                    //写入数据库数据
                                    if (!(dt.Rows[i][0].ToString() == "" || string.IsNullOrEmpty(dt.Rows[i][0].ToString())))
                                    {
                                        string MySql = "insert into TB_BlacakList (User_ChineseName,User_EnglishName,Department_ChineseName,Department_EnglishName,Job,Sex,Birthdy,Identification_Type,Identification_Number,Employer,TELEPHONE) values('" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "','" + dt.Rows[i][6].ToString() + "','" + dt.Rows[i][7].ToString() + "','" + dt.Rows[i][8].ToString() + "','" + dt.Rows[i][9].ToString() + "','" + dt.Rows[i][10].ToString() + "','" + dt.Rows[i][11].ToString() + "')";
                                        AccessHelper.SQLExecute(MySql);
                                    }

                                }
                                MessageBox.Show("数据导入成功！");
                                string getblacklistsql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList ";
                                DriverListBLL driverListBll = new DriverListBLL();
                                DataTable dtDriverList = driverListBll.FindAll_infos(getblacklistsql);
                               
                                dgvBlackList.DataSource = dtDriverList;
                                dgvBlackList.Rows[0].Selected = false;

                            }
                            else
                            {
                                MessageBox.Show("请检查你的Excel中是否存在数据");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 行双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBlackList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string blakcListId = dgvBlackList.CurrentRow.Cells[0].Value.ToString();

            }
        }
        /// <summary>
        /// 判断不同的单元格中不同控件的处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBlackList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBlackList.Columns[e.ColumnIndex].Name == "buttonEdit")
            {
                
                DriverList driver = new DriverList();
                driver.Id = dgvBlackList.CurrentRow.Cells[2].Value.ToString();
                driver.User_ChineseName = dgvBlackList.CurrentRow.Cells[3].Value.ToString();
                driver.User_EnglishName = dgvBlackList.CurrentRow.Cells[4].Value.ToString();
                driver.Department_ChineseName = dgvBlackList.CurrentRow.Cells[5].Value.ToString();
                driver.Department_EnglishName = dgvBlackList.CurrentRow.Cells[6].Value.ToString();
                driver.Job = dgvBlackList.CurrentRow.Cells[7].Value.ToString();
                driver.Sex = dgvBlackList.CurrentRow.Cells[8].Value.ToString();
                driver.Birthdy = dgvBlackList.CurrentRow.Cells[9].Value.ToString();
                driver.Identification_Type = dgvBlackList.CurrentRow.Cells[10].Value.ToString();
                driver.Identification_Number = dgvBlackList.CurrentRow.Cells[11].Value.ToString();
                driver.Employer = dgvBlackList.CurrentRow.Cells[12].Value.ToString();
                driver.Telephone = dgvBlackList.CurrentRow.Cells[13].Value.ToString();
                Form blackNameListEdit = new BlackNameListEdit(driver,this);
                blackNameListEdit.Show();
            }
            if (dgvBlackList.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string getblacklistsql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList ";
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvBlackList.CurrentRow.Cells[2].Value.ToString());
                    string sql = "delete from TB_BlacakList where ID=" + id + "";
                    try
                    {
                        if (driverListBll.ExecuteSql(sql))
                        {
                            MessageBox.Show("删除成功");
                        
                            dgvBlackList.DataSource = driverListBll.FindAll_infos(getblacklistsql);
                            dgvBlackList.Rows[0].Selected = false;

                        }
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
              
                
              

                DataTable dtDriverList = driverListBll.FindAll_infos(getblacklistsql);

                dgvBlackList.DataSource = dtDriverList;
            }
        }

        /// <summary>
        /// 选择上传的司机名单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectDriverList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Excel文件(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.FileNames.Length; i++)
                {
                    string filePath = dlg.FileNames[i];
                    this.txtDriverListFileName.AppendText(filePath + "\r\n");
                }

            }
            FileNames = dlg.FileNames;
        }

        private void btnUploadDriverList_Click(object sender, EventArgs e)
        {
            //dgvBlackList.dat
            //dgvBlackList.Columns.Clear();
            if (txtDriverListFileName.Text.Length == 0)
            {
                MessageBox.Show("请选择导入数据的Execl文件");
            }
            else
            {
                Excel2Access(FileNames);
            }
        }

        private void btnGetBlackListSJ_Click(object sender, EventArgs e)
        {
            dgvBlackNameLsitSJ.DataSource = driverBlackNameListBLL.FindAllInfo();
            //dgvBlackNameLsitSJ.Columns[3].Visible = false;
            dgvBlackNameLsitSJ.Rows[0].Selected = false;
        }

        private void btnGetDriverListSJ_Click(object sender, EventArgs e)
        {
            dgvDriverListSJ.DataSource = driverListBll.FindAllInfo();
            dgvDriverListSJ.Columns[4].Visible = false;
        }

        private void btnComareObject_Click(object sender, EventArgs e)
        {
            driverListBll.Compare2BlackNameList();
            dgvDriverAbnormalSJ.DataSource = driverAbnormalNameListBLL.FindAllInfo();
            dgvDriverWriteListSJ.DataSource = driverWriteListBLL.FindAllInfo();
        }

        private void tabContro1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage3)
            {
                CarForm carForm = new CarForm();
                carForm.FormBorderStyle = FormBorderStyle.None;
                carForm.TopLevel = false; //指示子窗体非顶级窗体
                this.carPannel.Controls.Add(carForm);//将子窗体载入panel
                carForm.Dock = DockStyle.Fill;
                carForm.Show();
            }
            if (e.TabPage == tabPage4)
            {
                CustomerInfo customerInfoForm = new CustomerInfo();
                customerInfoForm.FormBorderStyle = FormBorderStyle.None;
                customerInfoForm.TopLevel = false; //指示子窗体非顶级窗体
                this.cusomterInfoPannel.Controls.Add(customerInfoForm);//将子窗体载入panel
                customerInfoForm.Dock = DockStyle.Fill;
                customerInfoForm.Show();
            }
            if (e.TabPage == tabPage5)
            {
                CarRequirementMamage carRequirementMamageForm = new CarRequirementMamage();
                carRequirementMamageForm.FormBorderStyle = FormBorderStyle.None;
                carRequirementMamageForm.TopLevel = false; //指示子窗体非顶级窗体
                this.carRequirementMamageFormpanel.Controls.Add(carRequirementMamageForm);//将子窗体载入panel
                carRequirementMamageFormpanel.Dock = DockStyle.Fill;
                carRequirementMamageForm.Show();
            }

            if (e.TabPage == tabPage7)
            {

                summaryForm.FormBorderStyle = FormBorderStyle.None;
                summaryForm.TopLevel = false; //指示子窗体非顶级窗体
                this.panel2.Controls.Add(summaryForm);//将子窗体载入panel
                carRequirementMamageFormpanel.Dock = DockStyle.Fill;
                summaryForm.Show();
            }
        }
        /// <summary>
        /// 为控件增加序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDriverListSJ_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            AutoSizeFormClass.AddXuHao(dgvDriverListSJ, e);
                  
        }

        /// <summary>
        /// 司机表格编辑、删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDriverListSJ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDriverListSJ.Columns[e.ColumnIndex].Name == "btnEditDriver")
            {
                Form blackNameListEdit = new EditDriverForm(GetDriverByRow());
                blackNameListEdit.Show();
            }
            if (dgvDriverListSJ.Columns[e.ColumnIndex].Name == "btnDeleteDriver")
            {

                try
                {
                    int Id = Convert.ToInt32(dgvDriverListSJ.CurrentRow.Cells["Id"].Value.ToString());
                    if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        driverListBll.DeleteById(Id);
                        MessageBox.Show("删除成功");
                        dgvDriverListSJ.DataSource = driverListBll.FindAllInfo();
                        dgvDriverListSJ.Columns[4].Visible = false;
                    }
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //新增司机
        private void btnAddDriver_Click(object sender, EventArgs e)
        {

            Form DriverListEdit = new EditDriverForm();
            DriverListEdit.Show();
        }


        /// <summary>
        ///获取司机列表每行的数据
        /// </summary>
        public DriverList GetDriverByRow()
        {
            DriverList driver = new DriverList();
            driver.Id = dgvDriverListSJ.CurrentRow.Cells["Id"].Value.ToString();
            driver.User_ChineseName = dgvDriverListSJ.CurrentRow.Cells["中文名称"].Value.ToString();
            driver.User_EnglishName = dgvDriverListSJ.CurrentRow.Cells["英文名称"].Value.ToString();
            driver.Department_ChineseName = dgvDriverListSJ.CurrentRow.Cells["单位中文名称"].Value.ToString();
            driver.Department_EnglishName = dgvDriverListSJ.CurrentRow.Cells["单位英文名称"].Value.ToString();
            driver.Job = dgvDriverListSJ.CurrentRow.Cells["职务"].Value.ToString();
            driver.Birthdy = dgvDriverListSJ.CurrentRow.Cells["出生日期"].Value.ToString();
            driver.Identification_Type = dgvDriverListSJ.CurrentRow.Cells["身份证件类型"].Value.ToString();
            driver.Identification_Number = dgvDriverListSJ.CurrentRow.Cells["身份证件号码"].Value.ToString();
            driver.Sex = dgvDriverListSJ.CurrentRow.Cells["性别"].Value.ToString();
            driver.Telephone = dgvDriverListSJ.CurrentRow.Cells["联系方式"].Value.ToString();
            return driver;
        }

        /// <summary>
        /// 批量上传证件照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadPics_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "jpeg files(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string[] fileNames  = ofd.FileNames;
                  byte [] tempByte=new byte[]{};
                for (int i = 0; i < fileNames.Length; i++)
                {
                    string filePath = fileNames[i];
                    string[] temp = (System.IO.Path.GetFileName(fileNames[i])).Split('.');//得到文件名

                    string IdNumber = temp[0];
                    if ((!Regex.IsMatch(IdNumber, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
                    {
                        MessageBox.Show("请输入正确的身份证号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    //driverListBll.UpdateByIdNumber(IdNumber);
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        tempByte = new byte[fs.Length];
                        fs.Read(tempByte, 0, tempByte.Length);
                        fs.Close();
                    }

                    PictureHelper.UpdateImage(IdNumber, tempByte);
                }
                //this.Pic.Image = Image.FromFile(txtPicture.Text);
            }
        }
        /// <summary>
        /// 按司机单位查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectByDepartment_Click(object sender, EventArgs e)
        {
            dgvDriverListSJ.DataSource = driverListBll.FindByDepartment(txtSelectByDepartment.Text);
        }

        private void dgvBlackList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvBlackList, e);
        }

        private void dgvBlackNameLsitSJ_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvBlackNameLsitSJ, e);
        }
    }
}
