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
    public partial class CustomerInfor : Form
    {
        public User user;
        public UserBLL userBLL = new UserBLL();
        Form form = new Form();
        public CustomerInfor()
        {
            InitializeComponent();
        }
        public CustomerInfor(User user,Form form)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.UserName = txtCustomerName.Text;
            user.Telephone = txtTelephone.Text;
            try
            {
                userBLL.UpDateUserbyId(user);

                DataGridView dgv = (DataGridView)(form.Controls["panel1"].Controls["groupBox1"].Controls["dgvCustomerInfor"]);
                user.Id = 0;
                user.UserName = "";
                user.Telephone = "";
                dgv.DataSource = userBLL.SelectbyUser(user);
                MessageBox.Show("修改成功！");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("修改失败");
            }
        }

        private void CustomerInfor_Load(object sender, EventArgs e)
        {
            txtCustomerName.Text = user.UserName;
            txtTelephone.Text = user.Telephone;
        }
    }
}
