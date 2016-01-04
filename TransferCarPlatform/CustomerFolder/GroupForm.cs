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
    public partial class GroupForm : Form
    {
        public Group group;
        public GroupBLL groupBll = new GroupBLL();
        Form form = new Form();
        public GroupForm()
        {
            InitializeComponent();
        }
        public GroupForm(Group group,Form form)
        {
            InitializeComponent();
            this.group=group;
            this.form = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            group.GroupName = txtGroupName.Text;
            try
            {
                groupBll.UpdateByGroup(group);
                MessageBox.Show("修改成功");
                DataGridView dgv = (DataGridView)(form.Controls["panel1"].Controls["groupBox5"].Controls["dgvGroupList"]);
                dgv.DataSource = groupBll.FindAllInfo();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改分组名称错误:" + ex.Message);
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            txtGroupName.Text = group.GroupName;
        }
    }
}
