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
using TransferCarPlatform.CustomerFolder;

namespace TransferCarPlatform
{
    public partial class CustomerInfo : Form
    {
        GroupBLL groupBLL = new GroupBLL();
        UserBLL userBLL = new UserBLL();
        CarRequriedmentBLL carRequirementbll = new CarRequriedmentBLL();
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("分组名称不能为空");
                return;
            }
            group.GroupName = txtGroupName.Text;
            try
            {
                groupBLL.InsertObject(group);
                dgvGroupList.DataSource = groupBLL.FindAllInfo();
                MessageBox.Show("保存成功");
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存数据错误" + ex.Message);
            }

        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            dgvGroupList.DataSource = groupBLL.FindAllInfo();
        }

        private void btnGroupSelect_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.GroupName = txtGroupNameSelect.Text;
            dgvGroupList.DataSource = groupBLL.selectbyGroupName(group);
        }

        private void btnSaveCustomerInfo_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.UserName = txtCustomerInfo.Text;
            user.Telephone = txtTelephone.Text;
            int a = dgvGroupList.CurrentRow.Index;
            user.GroupId=Convert.ToInt32( dgvGroupList.Rows[a].Cells["id"].Value.ToString());
            user.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            try
            {
                userBLL.InsertObject(user);
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存错误！" + ex.Message);
            }
            try
            {
                dgvCustomerInfor.DataSource = userBLL.FindAllInfo(user.GroupId);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("更新列表错误" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = textBox3.Text;
            int a = dgvGroupList.CurrentRow.Index;
            user.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());
            user.Telephone = "";
            try
            {
                dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("查询错误" + ex.Message);
            }
        }

        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
            int a = dgvGroupList.CurrentRow.Index;
            user.UserName = "";
            user.Telephone = "";
            user.CarRequirement = "";
            user.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());

            try
            {
                dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user);
                dgvUserRequrement.DataSource = carRequirementbll.FindAllInfo(user.GroupId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("写入数据错误" + ex.Message);
            }
        }


        private void btnSaveCarRequment_Click(object sender, EventArgs e)
        {
            try
            {
                CarRequirement carRequirement = new Model.CarRequirement();
                carRequirement.CarYaoqiu = txtCarRequirement.Text;
                carRequirement.CarYongtu = txtCarPurpose.Text;
                carRequirement.Other = txtOther.Text;
                carRequirement.GroupId = Convert.ToInt32(dgvGroupList.CurrentRow.Cells["id"].Value.ToString());
                carRequirement.CreatTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                try
                {
                    carRequirementbll.InsertObject(carRequirement);
                    MessageBox.Show("保存成功!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("保存错误!");
                }
                try
                {
                    dgvUserRequrement.DataSource = carRequirementbll.FindAllInfo(carRequirement.GroupId);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("更新列表错误!");
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void dgvGroupList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvGroupList, e);
        }

        private void dgvCustomerInfor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvCustomerInfor, e);
        }


        private void dgvCustomerInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomerInfor.Columns[e.ColumnIndex].Name == "编辑")
            {
                User userEdit = new User();
                userEdit.Id = Convert.ToInt32(dgvCustomerInfor.CurrentRow.Cells["CustomerId"].Value.ToString());
                userEdit.UserName = dgvCustomerInfor.CurrentRow.Cells["姓名"].Value.ToString();
                userEdit.Telephone = dgvCustomerInfor.CurrentRow.Cells["联系电话"].Value.ToString();
                int a = dgvGroupList.CurrentRow.Index;
                userEdit.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());
                CustomerInfor cusomerrInofr = new CustomerInfor(userEdit,this);
                cusomerrInofr.Show();
            }
            if (dgvCustomerInfor.Columns[e.ColumnIndex].Name == "删除")
            {
                int Id = Convert.ToInt32(dgvCustomerInfor.CurrentRow.Cells["CustomerId"].Value.ToString());
               try
               {
                   userBLL.DeleteById(Id);
                   User user1 = new User();
                   int a = dgvGroupList.CurrentRow.Index;
                   user1.UserName = "";
                   user1.Telephone = "";
                   user1.CarRequirement = "";
                   user1.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());
                   dgvCustomerInfor.DataSource = userBLL.SelectbyUser(user1);
                   MessageBox.Show("删除成功");
               }
               catch (Exception ex)
               {

                   MessageBox.Show("删除失败:" + ex.Message);
               }
            }
        }

        private void dgvUserRequrement_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AutoSizeFormClass.AddXuHao(dgvUserRequrement, e);
        }

        //private void dgvCustomerInfor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    User user = new User();
        //    user.UserName = "";
        //    user.Telephone = "";
        //    user.CarRequirement = "";
        //    user.Id = Convert.ToInt32(dgvCustomerInfor.CurrentRow.Cells["CustomerId"].Value.ToString());
        //    dgvUserRequrement.DataSource = userBLL.SelectbyUser(user);
        //}

        private void dgvGroupList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroupList.Columns[e.ColumnIndex].Name == "btnEditGroup")
            {

                Group groupEdit = new Group();
                groupEdit.Id = Convert.ToInt32(dgvGroupList.CurrentRow.Cells[2].Value.ToString());
                groupEdit.GroupName = dgvGroupList.CurrentRow.Cells[3].Value.ToString();
                groupEdit.CreatTime = DateTime.Now.ToString();
                GroupForm carEditForm = new GroupForm(groupEdit,this);
                carEditForm.Show();


            }
            if (dgvGroupList.Columns[e.ColumnIndex].Name == "btnDeleteGroup")
            {
                Group groupEdit = new Group();
                groupEdit.Id = Convert.ToInt32(dgvGroupList.CurrentRow.Cells[2].Value.ToString());
                try
                {
                    groupBLL.DeleteByGroup(groupEdit);
                    MessageBox.Show("删除成功");
                    dgvGroupList.DataSource = groupBLL.FindAllInfo();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除分组失败:" + ex.Message);
                }
            }
        }

        private void dgvUserRequrement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserRequrement.Columns[e.ColumnIndex].Name == "UpdateRequirment")
            {

                CarRequirement carRequirement = new CarRequirement();
                carRequirement.Id = Convert.ToInt32(dgvUserRequrement.CurrentRow.Cells["RequirmentId"].Value.ToString());
                carRequirement.CarYaoqiu = dgvUserRequrement.CurrentRow.Cells["CarYaoqiu"].Value.ToString();
                carRequirement.CarYongtu = dgvUserRequrement.CurrentRow.Cells["CarYongtu"].Value.ToString();
                carRequirement.Other = dgvUserRequrement.CurrentRow.Cells["Other"].Value.ToString();
                 int a = dgvGroupList.CurrentRow.Index;
                 carRequirement.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());
                GroupRequirement groupRequirement = new GroupRequirement(carRequirement, this);
                groupRequirement.Show();


            }
            if (dgvUserRequrement.Columns[e.ColumnIndex].Name == "DeleteRequirment")
            {
                CarRequirement carRequirement = new CarRequirement();
                carRequirement.Id = Convert.ToInt32(dgvUserRequrement.CurrentRow.Cells["RequirmentId"].Value.ToString());
                int a = dgvGroupList.CurrentRow.Index;
                carRequirement.GroupId = Convert.ToInt32(dgvGroupList.Rows[a].Cells["id"].Value.ToString());
                try
                {
                    carRequirementbll.DeleteCarRequirement(carRequirement.Id);
                    MessageBox.Show("删除成功");
                    dgvUserRequrement.DataSource = carRequirementbll.FindAllInfo(carRequirement.GroupId);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除分组需求失败:" + ex.Message);
                }
            }
        }



    }
}
