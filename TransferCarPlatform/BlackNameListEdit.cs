using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace TransferCarPlatform
{
    public partial class BlackNameListEdit : Form
    {
        private Driver driver;
        Form f1 = new Form();
        DriverListBLL driverListBll = new DriverListBLL();
        DriverListBLL driverList = new DriverListBLL();
        public BlackNameListEdit()
        {
            InitializeComponent();
        }
        public BlackNameListEdit(Form f1)
        {

            InitializeComponent();
            this.f1 = f1;
        }
        public BlackNameListEdit(Driver driver, Form f1)
        {

            InitializeComponent();
            this.f1 = f1;
            this.driver = driver;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "update TB_BlacakList set User_ChineseName='" + txtUser_ChineseName.Text + "',User_EnglishName='" + txtUser_EnglishName.Text + "',Department_EnglishName='" + txtDepartment_EnglishName.Text + "',Department_ChineseName='" + txtDepartment_ChineseName.Text + "',Job='" + txt_Job.Text + "',Birthdy='" + txtBirthdy.Text + "' ,Identification_Type='" + txtIdentification_Type.Text + "',Identification_Number='" + txtIdentification_Number.Text + "',Telephone='" + txtTELEPHONE.Text + "',Employer='" + txtEmployer.Text + "' where ID=" + driver.Id + "";
                if (driverList.ExecuteSql(sql))
                {
                    MessageBox.Show("保存成功");

                    string getblacklistsql = "select ID ,User_ChineseName as 中文,User_EnglishName as 英文,Department_ChineseName as 单位名称中文,Department_EnglishName as 单位名称英文,Job as 职务,Sex as 性别,Birthdy as 出生日期,Identification_Type as 身份证件类型,Identification_Number as 身份证件号码,Employer as 工作单位,TELEPHONE as 联系方式 from TB_BlacakList ";

                    DataTable dtDriverList = driverListBll.FindAll_infos(getblacklistsql);

                    DataGridView dgv = (DataGridView)(f1.Controls["tabContro1"].Controls["tabPage1"].Controls["dgvBlackList"]);
                    dgv.DataSource = dtDriverList;
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BlackNameListEdit_Load(object sender, EventArgs e)
        {
            txtUser_ChineseName.Text = driver.User_ChineseName;
            txtUser_EnglishName.Text = driver.User_EnglishName;
            txtDepartment_ChineseName.Text = driver.Department_ChineseName;
            txtDepartment_EnglishName.Text = driver.Department_EnglishName;
            txt_Job.Text = driver.Job;
            txtBirthdy.Text = driver.Birthdy;
            txtIdentification_Type.Text = driver.Identification_Type;
            txtIdentification_Number.Text = driver.Identification_Number;
            txtTELEPHONE.Text = driver.Telephone;
            txtEmployer.Text = driver.Employer;
        }
    }
}
