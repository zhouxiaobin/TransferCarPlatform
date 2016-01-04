using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using Model;
using System.IO;
using BLL;
using System.Text.RegularExpressions;

namespace TransferCarPlatform
{
    public partial class EditDriverForm : Form
    {
        public DriverList driverlist;
        public DriverListBLL driverBll = new DriverListBLL();
        public EditDriverForm()
        {
            InitializeComponent();
            labType.Text = "新增";
        }
        public EditDriverForm(DriverList driverList)
        {
            this.driverlist = driverList;
            InitializeComponent();
            labType.Text = "编辑";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

               
               
                if (labType.Text == "编辑")
                {
                    driverlist.User_ChineseName = txtUserChineseName.Text;
                    driverlist.User_EnglishName = txtUserEnglisthName.Text;
                    driverlist.Department_ChineseName = txtChineseDepartment.Text;
                    driverlist.Department_EnglishName = txEnglishDepartmentName.Text;
                    driverlist.Job = txtJob.Text;
                    driverlist.Sex = txtSex.Text;
                    driverlist.Birthdy = txtBirthdy.Text;
                    driverlist.Identification_Type = txtIdType.Text;
                    driverlist.Identification_Number = txtIdNumber.Text;
                    driverlist.Employer = txtDepartment.Text;
                    driverlist.Telephone = txtTelephone.Text;
                    driverlist.CurrentResidence = txtCurrentResident.Text;
                    driverlist.CensusRegister = txtHuji.Text;
                    try
                    {
                        driverBll.UpdateDriver(driverlist);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    if (txtPicture.Text != "" || !string.IsNullOrEmpty(txtPicture.Text))
                    {
                        try
                        {
                             byte[] temp =new  byte[]{};
                            //driverBll.UpdateByIdNumber(driverlist.Identification_Number);
                            using (FileStream fs = new FileStream(txtPicture.Text, FileMode.Open, FileAccess.Read))
                            {
                                temp = new byte[fs.Length];
                                fs.Read(temp, 0, temp.Length);
                                fs.Close();
                            }
                            PictureHelper.UpdateById(driverlist.Id, temp);
                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("上传图片错误"+ex.Message);
                        }
                    }
                    MessageBox.Show("修改成功");
                  
                }
                if (labType.Text == "新增")
                {
                    driverlist.User_ChineseName = txtUserChineseName.Text;
                    driverlist.User_EnglishName = txtUserEnglisthName.Text;
                    driverlist.Department_ChineseName = txtChineseDepartment.Text;
                    driverlist.Department_EnglishName = txEnglishDepartmentName.Text;
                    driverlist.Job = txtJob.Text;
                    driverlist.Sex = txtSex.Text;
                    driverlist.Birthdy = txtBirthdy.Text;
                    driverlist.Identification_Type = txtIdType.Text;
                    driverlist.Identification_Number = txtIdNumber.Text;
                    driverlist.Employer = txtDepartment.Text;
                    driverlist.Telephone = txtTelephone.Text;
                    driverlist.CurrentResidence = txtCurrentResident.Text;
                    driverlist.CensusRegister = txtHuji.Text;
                    FileStream fs = new FileStream(txtPicture.Text, FileMode.Open, FileAccess.Read);
                    driverlist.Photo = new byte[fs.Length];
                    fs.Read(driverlist.Photo, 0, driverlist.Photo.Length);
                    fs.Close();
                    PictureHelper.MemoryImage(driverlist);
                    MessageBox.Show("新增成功！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bntAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "jpeg files(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] temp = (System.IO.Path.GetFileName(ofd.FileName)).Split('.');//得到文件名

                string IdNumber = temp[0];
                if ((!Regex.IsMatch(IdNumber, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
                {
                    MessageBox.Show("请输入正确的身份证号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                txtPicture.Text = ofd.FileName;
                this.Pic.Image = Image.FromFile(txtPicture.Text);
                txtPicture.Visible = false;
                bntAddPicture.Visible = false;
            }
        }

        private void EditDriverForm_Load(object sender, EventArgs e)
        {
            if (labType.Text == "编辑")
            {
                txtUserChineseName.Text = driverlist.User_ChineseName;
                txtUserEnglisthName.Text = driverlist.User_EnglishName;
                txtChineseDepartment.Text = driverlist.Department_ChineseName;
                txEnglishDepartmentName.Text = driverlist.Department_EnglishName;
                driverlist.Job = txtJob.Text;
                txtSex.Text = driverlist.Sex;
                txtBirthdy.Text = driverlist.Birthdy;
                txtIdType.Text = driverlist.Identification_Type;
                txtIdNumber.Text = driverlist.Identification_Number;
                txtDepartment.Text = driverlist.Employer;
                txtTelephone.Text = driverlist.Telephone;
                txtCurrentResident.Text = driverlist.CurrentResidence;
                txtHuji.Text = driverlist.CensusRegister;
                using (MemoryStream memStream = new MemoryStream(PictureHelper.ExportImage(Convert.ToInt32(driverlist.Id), "TB_DriverList", "Photo")))
                {
                    if (memStream != null || memStream.Length > 0)
                    {

                        this.Pic.Image = Image.FromStream(memStream);
                        txtPicture.Visible = false;
                        bntAddPicture.Visible = false;
                    }
                }  
            }
        
        }

    }
}
