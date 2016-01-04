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
using System.IO;
using DBUtility;

namespace TransferCarPlatform.CarFolder
{
    public partial class CarEditForm : Form
    {
        private Car car;
        CarBLL carBll = new CarBLL();
        public CarEditForm()
        {
           
            InitializeComponent();
            labEidt.Text = "新增";
        }
        public CarEditForm(Car car)
        {
            this.car = car;
            InitializeComponent();
            labEidt.Text = "编辑";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (labEidt.Text == "编辑")
            {
                car.PlateNumber = txtPlateNumber.Text;
                car.Color = txtColor.Text;
                car.CarResource = txtCarResource.Text;
                car.Brand = txtBrand.Text;
                car.MotorcyleType = txtMotorcyleType.Text;
                try
                {
                    try
                    {

                        carBll.UpdateCar(car);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (txtUploadFile.Text != "" || !string.IsNullOrEmpty(txtUploadFile.Text))
                    {
                        byte[] temp = new byte[] { };
                        //driverBll.UpdateByIdNumber(driverlist.Identification_Number);
                        using (FileStream fs = new FileStream(txtUploadFile.Text, FileMode.Open, FileAccess.Read))
                        {
                            temp = new byte[fs.Length];
                            fs.Read(temp, 0, temp.Length);
                            fs.Close();
                        }
                        try
                        {
                            PictureHelper.UpdateByCarId(car.Id.ToString(), temp);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    MessageBox.Show("修改成功！");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            if (labEidt.Text == "新增")
            {
                car = new Car();
                car.PlateNumber = txtPlateNumber.Text;
                car.Color = txtColor.Text;
                car.CarResource = txtCarResource.Text;
                car.Brand = txtBrand.Text;
                car.MotorcyleType = txtMotorcyleType.Text;
                car.UseYear = txtUserYear.Text;
                carBll.InsertObject(car);
                using (FileStream fs = new FileStream(txtUploadFile.Text, FileMode.Open, FileAccess.Read))
                {
                    car.CarPicture = new byte[fs.Length];
                    fs.Read(car.CarPicture, 0, car.CarPicture.Length);
                    fs.Close();
                    try
                    {
                        PictureHelper.MemoryCarImage(car);
                        MessageBox.Show("添加成功");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("新增错误:" + ex.Message);
                    }
                }
               
            }
        }

        private void CarEditForm_Load(object sender, EventArgs e)
        {
            if (labEidt.Text == "编辑")
            {
                txtPlateNumber.Text = car.PlateNumber;
                txtColor.Text = car.Color;
                txtCarResource.Text = car.CarResource;
                txtBrand.Text = car.Brand;
                txtMotorcyleType.Text = car.MotorcyleType;
                using (MemoryStream memStream = new MemoryStream(PictureHelper.ExportImage(Convert.ToInt32(car.Id), "TB_Car", "CarPicture")))
                {
                    if (memStream != null || memStream.Length > 0)
                    {

                        this.picCar.Image = Image.FromStream(memStream);
                        txtUploadFile.Visible = false;
                        btnUploadFile.Visible = false;
                    }
                }  
                
            }
            if (labEidt.Text == "新增")
            { 
                
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "jpeg files(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                txtUploadFile.Text = ofd.FileName;
                this.picCar.Image = Image.FromFile(txtUploadFile.Text);
                txtUploadFile.Visible = false;
                btnUploadFile.Visible = false;
            }

        }
    }
}
