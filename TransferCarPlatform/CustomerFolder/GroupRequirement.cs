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

namespace TransferCarPlatform.CustomerFolder
{
    public partial class GroupRequirement : Form
    {
        public CarRequirement carRequirement;
        public CarRequriedmentBLL carRequriedmentBLL = new CarRequriedmentBLL();
        Form form = new Form();
        public GroupRequirement()
        {
            InitializeComponent();
        }
        public GroupRequirement(CarRequirement carRequirement, Form form)
        {
            InitializeComponent();
            this.carRequirement = carRequirement;
            this.form = form;
            txtCarYaoqiu.Text = carRequirement.CarYaoqiu;
            txtCarYongtu.Text=carRequirement.CarYongtu;
            txtOther.Text = carRequirement.Other;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCarYaoqiu.Text != "")
            {
                carRequirement.CarYaoqiu = txtCarYaoqiu.Text;
            }
            if (txtCarYongtu.Text != "")
            { 
               carRequirement.CarYongtu=txtCarYongtu.Text;
            }
            if (txtOther.Text != "")
            {
                carRequirement.Other = txtOther.Text;
            }
            try
            {
                carRequriedmentBLL.UpdateCarRequirement(carRequirement);
                DataGridView dgv = (DataGridView)(form.Controls["panel1"].Controls["groupBox2"].Controls["dgvUserRequrement"]);
                dgv.DataSource = carRequriedmentBLL.FindAllInfo(carRequirement.GroupId);
                MessageBox.Show("修改成功");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("修改错误" + ex.Message);
            }
        }
    }
}
