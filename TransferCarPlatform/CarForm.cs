using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DBUtility;
using BLL;
using System.Configuration;
using Model;
using TransferCarPlatform.CarFolder;
using System.IO;

namespace TransferCarPlatform
{
    public partial class CarForm : Form
    {
        string[] FileNames;
        public static string sheetName = ConfigurationManager.AppSettings["sheetName"].ToString();
        CarBLL carBLL = new CarBLL();
        string getblacklistsql = "select ID ,PlateNumber,Color ,Brand ,UseYear ,MotorcyleType,CarResource from TB_Car";
        public CarForm()
        {
            InitializeComponent();
        }

        private void btnSelecetCarFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Excel文件(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.FileNames.Length; i++)
                {
                    string filePath = dlg.FileNames[i];
                    this.txtCarLog.AppendText(filePath + "\r\n");
                }

            }
            FileNames = dlg.FileNames;
        }

        private void btnUploadCarFile_Click(object sender, EventArgs e)
        {
            //dgvBlackList.dat
            //dgvBlackList.Columns.Clear();
            if (txtCarLog.Text.Length == 0)
            {
                MessageBox.Show("请选择导入数据的Execl文件");
            }
            else
            {
                Excel2Access(FileNames);
            }
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
                                        string MySql = "insert into TB_Car (PlateNumber,Color,Brand,UseYear,MotorcyleType) values('" + dt.Rows[i][1].ToString() + "','" +
                                            dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" +
                                            dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "')";
                                        AccessHelper.SQLExecute(MySql);
                                    }

                                }
                                MessageBox.Show("数据导入成功！");

                                CarBLL carBLL = new CarBLL();
                                DataTable carList = carBLL.FindAll_infos(getblacklistsql);

                                dgvCarList.DataSource = carList;

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.PlateNumber = "";
            car.Brand = txtBrand.Text;
            car.MotorcyleType = txtMotorcyleType.Text;
            car.Color = txtColor.Text; ;
            car.UseYear = txtUseYear.Text;
            car.CarResource = txtCarResource.Text;
            try
            {

                DataTable carList = carBLL.SelectbyCar(car);
                dgvCarList.DataSource = carList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            DataTable carList = carBLL.FindAll_infos(getblacklistsql);

            dgvCarList.DataSource = carList;
        }

        private void dgvCarList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
          e.RowBounds.Location.Y,
          dgvCarList.RowHeadersWidth - 4,
          e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvCarList.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvCarList.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarList.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                Form carEditForm= new CarEditForm(GetCarByRow());
                carEditForm.Show();

            }

            if (dgvCarList.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int id = Convert.ToInt32(dgvCarList.CurrentRow.Cells[2].Value.ToString());
                try
                {
                    carBLL.DeleteByCarId(id);
                    MessageBox.Show("删除成功");
                    DataTable carList = carBLL.FindAll_infos(getblacklistsql);

                    dgvCarList.DataSource = carList;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除失败" + ex.Message);
                }
                
            }
        }

        /// <summary>
        ///获取司机列表每行的数据
        /// </summary>
        public Car GetCarByRow()
        {
            Car carModel = new Car();
            carModel.Id =Convert.ToInt32( dgvCarList.CurrentRow.Cells["Id"].Value.ToString());
            carModel.PlateNumber = dgvCarList.CurrentRow.Cells["PlateNumber"].Value.ToString();
            carModel.Color = dgvCarList.CurrentRow.Cells["Color"].Value.ToString();
            carModel.Brand = dgvCarList.CurrentRow.Cells["Brand"].Value.ToString();
            carModel.UseYear = dgvCarList.CurrentRow.Cells["UseYear"].Value.ToString();
            carModel.MotorcyleType = dgvCarList.CurrentRow.Cells["MotorcyleType"].Value.ToString();
            carModel.CarResource = dgvCarList.CurrentRow.Cells["CarResource"].Value.ToString();

            return carModel;
        }

        private void tbnAddNewCar_Click(object sender, EventArgs e)
        {
            CarEditForm carEditForm = new CarEditForm();
            carEditForm.Show();
        }

        /// <summary>
        /// 批量上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "jpeg files(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string[] fileNames = ofd.FileNames;
                byte[] tempByte = new byte[] { };
                for (int i = 0; i < fileNames.Length; i++)
                {
                    string filePath = fileNames[i];
                    string[] temp = (System.IO.Path.GetFileName(fileNames[i])).Split('.');//得到文件名
                    string PlateNumber = temp[0];
                    //driverListBll.UpdateByIdNumber(IdNumber);
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        tempByte = new byte[fs.Length];
                        fs.Read(tempByte, 0, tempByte.Length);
                        fs.Close();
                    }

                    try
                    {
                        PictureHelper.UpdateImageByPlateNumber(PlateNumber, tempByte);

                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                }
                MessageBox.Show("上传成功");
                //this.Pic.Image = Image.FromFile(txtPicture.Text);
            }
        }
    }
}
