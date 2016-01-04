using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;
using DBUtility;

namespace TransferCarPlatform
{
    public partial class SummaryForm : Form
    {
        GroupBLL groupBLL = new GroupBLL();
        ManageCarRequiredmentBLL manageCarRequiredmentBLL = new ManageCarRequiredmentBLL();
        DriverWriteListBLL driverWriteListBLL = new DriverWriteListBLL();
        CarBLL carBll = new CarBLL();
        public SummaryForm()
        {
            InitializeComponent();
        }
        private void SummaryForm_Load(object sender, EventArgs e)
        {
            dgvSelectgroup.DataSource = groupBLL.FindAllInfo();
            dgvSummary.DataSource = manageCarRequiredmentBLL.FindAllInfo();
            this.dgvSummary.Columns[0].Frozen = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvSelectgroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageCarRequiredment manageCarRequiredment = new ManageCarRequiredment();
            int a = dgvSelectgroup.CurrentRow.Index;
            manageCarRequiredment.UserName = "";
            manageCarRequiredment.CarYaoqiu = "";
           manageCarRequiredment.GroupId = Convert.ToInt32(dgvSelectgroup.Rows[a].Cells["id"].Value.ToString());
           dgvSummary.DataSource = manageCarRequiredmentBLL.FindManageCustomer(manageCarRequiredment.GroupId);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //string sql = "select top 65535 *  into   [Excel 8.0;database=" + filename + "].[用户信息] from TB_ManageCarRequiredment";
            AccessHelper.Access2Excel("TB_ManageCarRequiredment");
        }

        private void dgvSelectgroup_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvSelectgroup, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               dgvSummary.DataSource=  manageCarRequiredmentBLL.FindManageCustomerByTiaojian(txtCar.Text, txtRequirement.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("查询错误" + ex.Message);
            }
        }

        private void dgvSummary_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvSummary, e);
        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSummary.Columns[e.ColumnIndex].Name == "删除")
            {
                ManageCarRequiredment manageCarRequiredment = new ManageCarRequiredment();
                manageCarRequiredment.Id = Convert.ToInt32(dgvSummary.CurrentRow.Cells["managerId"].Value.ToString());
                manageCarRequiredment.DriverId = Convert.ToInt32(dgvSummary.CurrentRow.Cells["driverId"].Value.ToString());
                manageCarRequiredment.CarId = Convert.ToInt32(dgvSummary.CurrentRow.Cells["carId"].Value.ToString());
                try
                {
                    manageCarRequiredmentBLL.DeleteObject(manageCarRequiredment);
                    driverWriteListBLL.UpdateIsUseStatus(manageCarRequiredment.DriverId,0);
                    carBll.UpdateIsUseStatus(manageCarRequiredment.CarId,0);
                    MessageBox.Show("删除成功");
                    //  DataTable carList = manageCarRequiredmentBLL.FindAll_infos(getblacklistsql);

                    // dgvSummary.DataSource = carList;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除失败" + ex.Message);
                }

            }
        }
    }
}
