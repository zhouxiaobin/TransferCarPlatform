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

namespace TransferCarPlatform
{
    public partial class CarRequirementMamage : Form
    {
        GroupBLL groupBLL = new GroupBLL();
        UserBLL userBLL = new UserBLL();
        DriverWriteListBLL driverWriteListBLL = new DriverWriteListBLL();
        DriverListBLL driverListBll = new DriverListBLL();
        ManageCarRequiredmentBLL manageCarRequiredmentBLL = new ManageCarRequiredmentBLL();
        CarBLL calBll = new CarBLL();
        CarUseHisotryBLL carUseHisotryBLL = new CarUseHisotryBLL();
        CarRequriedmentBLL carRequirementbll = new CarRequriedmentBLL();
        public CarRequirementMamage()
        {
            InitializeComponent();
        }

        private void btnGroupSelect_Click(object sender, EventArgs e)
        {

            Group group = new Group();
            group.GroupName = txtGroupName.Text;
            dgvGroupList1.DataSource = groupBLL.selectbyGroupName(group);
        }

        private void CarRequirementMamage_Load(object sender, EventArgs e)
        {
            dgvGroupList1.DataSource = groupBLL.FindAllInfo();
            dgvWriteDriverList.DataSource = driverWriteListBLL.FindAllInfo();
            dgvCarList.DataSource = calBll.FindAllInfo();
            dgvManagedInfo.DataSource = manageCarRequiredmentBLL.FindAllInfo();
        }

        private void btnSelectWriteDriver_Click(object sender, EventArgs e)
        {
            DriverWriteList driverWriteList = new DriverWriteList();
            driverWriteList.User_ChineseName = txtDriverName.Text;
            driverWriteList.Identification_Number = txtUserIdNumber.Text;
            dgvWriteDriverList.DataSource = driverWriteListBLL.SelectbyWrierList(driverWriteList);
        }

        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            int a = dgvGroupList1.CurrentRow.Index;
            user.UserName = "";
            user.Telephone = "";
            user.CarRequirement = "";
            user.GroupId = Convert.ToInt32(dgvGroupList1.Rows[a].Cells["id"].Value.ToString());
            dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user);
        }

        private void dgvCustomerInfor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             User user = new User();
             int a = dgvGroupList1.CurrentRow.Index;
            user.UserName = "";
            user.Telephone = "";
            user.CarRequirement = "";
            user.GroupId = Convert.ToInt32(dgvGroupList1.Rows[a].Cells["id"].Value.ToString());
           dgvCarReuirment.DataSource= userBLL.SelectbyUser(user);
        }

        private void dgvWriteDriverList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = dgvWriteDriverList.CurrentRow.Index;
            txtdriverNameManage.Text = dgvWriteDriverList.Rows[currentIndex].Cells["中文"].Value.ToString();
            //string driverIdNumber = dgvWriteDriverList.Rows[currentIndex].Cells["Identification_Number"].Value.ToString();
        }

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = dgvCarList.CurrentRow.Index;
            txtCarManage.Text = dgvCarList.Rows[currentIndex].Cells["品牌"].Value.ToString();
        }

        private void btnSaveManageCar_Click(object sender, EventArgs e)
        {
            if (txtdriverNameManage.Text == "")
            {
                MessageBox.Show("请配置司机");
                return;
            }
            if (txtCarManage.Text == "")
            {
                MessageBox.Show("请配置车辆");
                return;
            }
            CarUseHisotry carUseHisotry = new CarUseHisotry();
            if (dgvCustomerInfor.CurrentRow == null) {
                MessageBox.Show("请选择人员进行配置");
                return;
            }
            int currentDriverListIndex = dgvWriteDriverList.CurrentRow.Index;
            int driverId = Convert.ToInt32(dgvWriteDriverList.Rows[currentDriverListIndex].Cells["DriverId"].Value);
            carUseHisotry.DriverIdNumber = dgvWriteDriverList.Rows[currentDriverListIndex].Cells["身份证件号码"].Value.ToString();

            int currentCarListIndex = dgvCarList.CurrentRow.Index;
            int carId = Convert.ToInt32(dgvCarList.Rows[currentCarListIndex].Cells["CarId"].Value);
            carUseHisotry.CarIdNumber = dgvCarList.Rows[currentCarListIndex].Cells["车牌号"].Value.ToString();

            int currentUserListIndex = dgvCustomerInfor.CurrentRow.Index;
            int userId = Convert.ToInt32(dgvCustomerInfor.Rows[currentUserListIndex].Cells["Id"].Value);
            int groupId = dgvGroupList1.CurrentRow.Index;
            carUseHisotry.GroupId = Convert.ToInt32(dgvGroupList1.Rows[groupId].Cells["GroupId"].Value);

            int currentCustomerListIndex = dgvCustomerInfor.CurrentRow.Index;
            string currentCustomerUserName = dgvCustomerInfor.Rows[currentCustomerListIndex].Cells["用户名"].Value.ToString();
            carUseHisotry.UserName = dgvCustomerInfor.Rows[currentCustomerListIndex].Cells["用户名"].Value.ToString();
            carUseHisotry.Telephone = dgvCustomerInfor.Rows[currentCustomerListIndex].Cells["联系方式"].Value.ToString();
            carUseHisotry.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            int currentCarReuirmentIndex = dgvCarReuirment.CurrentRow.Index;
            string CarYaoqiu = dgvCarReuirment.Rows[currentCarReuirmentIndex].Cells["CarYaoqiu"].Value.ToString();
            string CarYongtu = dgvCarReuirment.Rows[currentCarReuirmentIndex].Cells["CarYongtu"].Value.ToString();
            string Other = dgvCarReuirment.Rows[currentCarReuirmentIndex].Cells["Other"].Value.ToString();

            //userBLL.UpdateIsUseStatus(userId);
            //User user = new User();
            //user.Id = carId;
            //dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user);

            ManageCarRequiredment manageCarRequiredment = new ManageCarRequiredment();
            manageCarRequiredment.GroupId = Convert.ToInt32(dgvGroupList1.Rows[groupId].Cells["GroupId"].Value);
            manageCarRequiredment.UserName = currentCustomerUserName;
            manageCarRequiredment.DriverId = driverId;
            manageCarRequiredment.CarId = carId;
            manageCarRequiredment.CarYaoqiu = CarYaoqiu;
            manageCarRequiredment.CarYongtu = CarYaoqiu;
            manageCarRequiredment.Other = CarYaoqiu;
           
            manageCarRequiredment.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); 
            try
            {
                manageCarRequiredmentBLL.InsertObject(manageCarRequiredment);
            }
            catch (Exception ex)
            {

                MessageBox.Show("编辑信息错误");
            }

            driverWriteListBLL.UpdateIsUseStatus(driverId,1);
            calBll.UpdateIsUseStatus(carId,1);
            dgvWriteDriverList.DataSource = driverWriteListBLL.FindAllInfo();
            dgvCarList.DataSource = calBll.FindAllInfo();

             

            dgvManagedInfo.DataSource = manageCarRequiredmentBLL.FindAllInfo();
            MessageBox.Show("编辑成功!");
            try
            {
                carUseHisotryBLL.InsertObject(carUseHisotry);
            }
            catch (Exception ex)
            {

                MessageBox.Show("插入历史数据表错误");
                return;
            }
        }



        private void dgvGroupList_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            int a = dgvGroupList1.CurrentRow.Index;
            user.UserName = "";
            user.Telephone = "";
            user.CarRequirement = "";
            user.GroupId = Convert.ToInt32(dgvGroupList1.Rows[a].Cells["GroupId"].Value.ToString());
            try
            {
                dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user);
                dgvCarReuirment.DataSource = carRequirementbll.FindAllInfo(user.GroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据错误" + ex.Message);
            }
        }

        //private void dgvCustomerInfor_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    User user = new User();
        //    int a = dgvCustomerInfor.CurrentRow.Index;
        //    user.UserName = "";
        //    user.Telephone = "";
        //    user.CarRequirement = "";
        //    user.Id = Convert.ToInt32(dgvCustomerInfor.Rows[a].Cells["Id"].Value.ToString());
        //    dgvCarReuirment.DataSource = userBLL.SelectbyUser(user);
        //}

        private void dgvCustomerInfor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvCustomerInfor, e);
        }

        private void dgvCarReuirment_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvCarReuirment, e);
        }

        private void dgvWriteDriverList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvWriteDriverList, e);
        }

        private void dgvGroupList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvGroupList1, e);
        }

        private void btnGroupSelect_Click_1(object sender, EventArgs e)
        {
            Group group = new Group();
            group.GroupName = txtGroupName.Text;
            dgvGroupList1.DataSource = groupBLL.selectbyGroupName(group);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.MotorcyleType = txtCarType.Text;
            car.Color = txtColor.Text;
            car.PlateNumber = "";
            car.UseYear = "";
            car.CarResource = "";
            car.Brand = "";
            dgvCarList.DataSource = calBll.SelectbyCar(car);
        }

        private void dgvManagedInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvManagedInfo, e);
        }

    }
}
