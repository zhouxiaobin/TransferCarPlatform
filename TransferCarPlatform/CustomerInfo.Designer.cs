namespace TransferCarPlatform
{
    partial class CustomerInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.btnEditGroup = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDeleteGroup = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分组名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGroupSelect = new System.Windows.Forms.Button();
            this.txtGroupNameSelect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.cmbGroupType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUserRequrement = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCarPurpose = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveCarRequment = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCarRequirement = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCustomerInfor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnSaveCustomerInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.编辑 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.删除 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateRequirment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DeleteRequirment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.RequirmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarYaoqiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarYongtu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequrement)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfor)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox5.Controls.Add(this.dgvGroupList);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Location = new System.Drawing.Point(9, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 465);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "分组信息";
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.AllowUserToAddRows = false;
            this.dgvGroupList.AllowUserToDeleteRows = false;
            this.dgvGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupList.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditGroup,
            this.btnDeleteGroup,
            this.Id,
            this.分组名称});
            this.dgvGroupList.GridColor = System.Drawing.Color.Silver;
            this.dgvGroupList.Location = new System.Drawing.Point(17, 232);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowTemplate.Height = 23;
            this.dgvGroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupList.Size = new System.Drawing.Size(250, 206);
            this.dgvGroupList.TabIndex = 3;
            this.dgvGroupList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupList_CellContentClick);
            this.dgvGroupList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupList_CellDoubleClick);
            this.dgvGroupList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvGroupList_RowPostPaint);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.HeaderText = "";
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.ReadOnly = true;
            this.btnEditGroup.Text = "编辑";
            this.btnEditGroup.UseColumnTextForLinkValue = true;
            this.btnEditGroup.Width = 50;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.HeaderText = "";
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.ReadOnly = true;
            this.btnDeleteGroup.Text = "删除";
            this.btnDeleteGroup.UseColumnTextForLinkValue = true;
            this.btnDeleteGroup.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // 分组名称
            // 
            this.分组名称.DataPropertyName = "GroupName";
            this.分组名称.HeaderText = "分组名称";
            this.分组名称.Name = "分组名称";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "双击组名，查询同组中的用户信息";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnGroupSelect);
            this.panel4.Controls.Add(this.txtGroupNameSelect);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(7, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 56);
            this.panel4.TabIndex = 1;
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.Location = new System.Drawing.Point(181, 14);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(75, 23);
            this.btnGroupSelect.TabIndex = 2;
            this.btnGroupSelect.Text = "查询";
            this.btnGroupSelect.UseVisualStyleBackColor = true;
            this.btnGroupSelect.Click += new System.EventHandler(this.btnGroupSelect_Click);
            // 
            // txtGroupNameSelect
            // 
            this.txtGroupNameSelect.Location = new System.Drawing.Point(54, 14);
            this.txtGroupNameSelect.Name = "txtGroupNameSelect";
            this.txtGroupNameSelect.Size = new System.Drawing.Size(100, 21);
            this.txtGroupNameSelect.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "组名：";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSaveGroup);
            this.panel3.Controls.Add(this.cmbGroupType);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtGroupName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(7, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 117);
            this.panel3.TabIndex = 0;
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Location = new System.Drawing.Point(181, 87);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGroup.TabIndex = 4;
            this.btnSaveGroup.Text = "保存";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // cmbGroupType
            // 
            this.cmbGroupType.FormattingEnabled = true;
            this.cmbGroupType.Location = new System.Drawing.Point(57, 55);
            this.cmbGroupType.Name = "cmbGroupType";
            this.cmbGroupType.Size = new System.Drawing.Size(121, 20);
            this.cmbGroupType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "类别:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(57, 13);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 21);
            this.txtGroupName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "组名:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 459);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.dgvUserRequrement);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Location = new System.Drawing.Point(677, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 444);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用车需求";
            // 
            // dgvUserRequrement
            // 
            this.dgvUserRequrement.AllowUserToAddRows = false;
            this.dgvUserRequrement.AllowUserToDeleteRows = false;
            this.dgvUserRequrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserRequrement.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserRequrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRequrement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateRequirment,
            this.DeleteRequirment,
            this.RequirmentId,
            this.CarYaoqiu,
            this.CarYongtu,
            this.Other});
            this.dgvUserRequrement.Location = new System.Drawing.Point(24, 214);
            this.dgvUserRequrement.Name = "dgvUserRequrement";
            this.dgvUserRequrement.RowTemplate.Height = 23;
            this.dgvUserRequrement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserRequrement.Size = new System.Drawing.Size(448, 221);
            this.dgvUserRequrement.TabIndex = 2;
            this.dgvUserRequrement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRequrement_CellContentClick);
            this.dgvUserRequrement.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUserRequrement_RowPostPaint);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.txtCarPurpose);
            this.panel7.Controls.Add(this.txtOther);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.btnSaveCarRequment);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.txtCarRequirement);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(24, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(467, 169);
            this.panel7.TabIndex = 1;
            // 
            // txtCarPurpose
            // 
            this.txtCarPurpose.Location = new System.Drawing.Point(99, 44);
            this.txtCarPurpose.Name = "txtCarPurpose";
            this.txtCarPurpose.Size = new System.Drawing.Size(126, 21);
            this.txtCarPurpose.TabIndex = 7;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(99, 71);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(266, 80);
            this.txtOther.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "其他:";
            // 
            // btnSaveCarRequment
            // 
            this.btnSaveCarRequment.Location = new System.Drawing.Point(371, 128);
            this.btnSaveCarRequment.Name = "btnSaveCarRequment";
            this.btnSaveCarRequment.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCarRequment.TabIndex = 4;
            this.btnSaveCarRequment.Text = "保存";
            this.btnSaveCarRequment.UseVisualStyleBackColor = true;
            this.btnSaveCarRequment.Click += new System.EventHandler(this.btnSaveCarRequment_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "车辆用途:";
            // 
            // txtCarRequirement
            // 
            this.txtCarRequirement.Location = new System.Drawing.Point(99, 7);
            this.txtCarRequirement.Name = "txtCarRequirement";
            this.txtCarRequirement.Size = new System.Drawing.Size(126, 21);
            this.txtCarRequirement.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "车辆要求:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.dgvCustomerInfor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(303, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户信息";
            // 
            // dgvCustomerInfor
            // 
            this.dgvCustomerInfor.AllowUserToAddRows = false;
            this.dgvCustomerInfor.AllowUserToDeleteRows = false;
            this.dgvCustomerInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerInfor.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编辑,
            this.删除,
            this.CustomerId,
            this.姓名,
            this.联系电话});
            this.dgvCustomerInfor.Location = new System.Drawing.Point(6, 232);
            this.dgvCustomerInfor.Name = "dgvCustomerInfor";
            this.dgvCustomerInfor.RowTemplate.Height = 23;
            this.dgvCustomerInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerInfor.Size = new System.Drawing.Size(347, 206);
            this.dgvCustomerInfor.TabIndex = 4;
            this.dgvCustomerInfor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerInfor_CellContentClick);
            this.dgvCustomerInfor.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCustomerInfor_RowPostPaint);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "分组中的客户";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(24, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 56);
            this.panel5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "客户姓名查询：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtTelephone);
            this.panel2.Controls.Add(this.btnSaveCustomerInfo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCustomerInfo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(24, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 117);
            this.panel2.TabIndex = 1;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(78, 52);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(211, 21);
            this.txtTelephone.TabIndex = 5;
            // 
            // btnSaveCustomerInfo
            // 
            this.btnSaveCustomerInfo.Location = new System.Drawing.Point(233, 87);
            this.btnSaveCustomerInfo.Name = "btnSaveCustomerInfo";
            this.btnSaveCustomerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCustomerInfo.TabIndex = 4;
            this.btnSaveCustomerInfo.Text = "保存";
            this.btnSaveCustomerInfo.UseVisualStyleBackColor = true;
            this.btnSaveCustomerInfo.Click += new System.EventHandler(this.btnSaveCustomerInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系电话:";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(78, 13);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(211, 21);
            this.txtCustomerInfo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "联系人:";
            // 
            // 编辑
            // 
            this.编辑.FillWeight = 50F;
            this.编辑.HeaderText = "";
            this.编辑.Name = "编辑";
            this.编辑.ReadOnly = true;
            this.编辑.Text = "编辑";
            this.编辑.UseColumnTextForLinkValue = true;
            this.编辑.Width = 50;
            // 
            // 删除
            // 
            this.删除.FillWeight = 50F;
            this.删除.HeaderText = "";
            this.删除.Name = "删除";
            this.删除.ReadOnly = true;
            this.删除.Text = "删除";
            this.删除.UseColumnTextForLinkValue = true;
            this.删除.Width = 50;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "Id";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "UserName";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 联系电话
            // 
            this.联系电话.DataPropertyName = "Telephone";
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.Name = "联系电话";
            this.联系电话.ReadOnly = true;
            // 
            // UpdateRequirment
            // 
            this.UpdateRequirment.HeaderText = "";
            this.UpdateRequirment.Name = "UpdateRequirment";
            this.UpdateRequirment.ReadOnly = true;
            this.UpdateRequirment.Text = "编辑";
            this.UpdateRequirment.UseColumnTextForLinkValue = true;
            this.UpdateRequirment.Width = 50;
            // 
            // DeleteRequirment
            // 
            this.DeleteRequirment.HeaderText = "";
            this.DeleteRequirment.Name = "DeleteRequirment";
            this.DeleteRequirment.ReadOnly = true;
            this.DeleteRequirment.Text = "删除";
            this.DeleteRequirment.UseColumnTextForLinkValue = true;
            this.DeleteRequirment.Width = 50;
            // 
            // RequirmentId
            // 
            this.RequirmentId.DataPropertyName = "Id";
            this.RequirmentId.HeaderText = "Id";
            this.RequirmentId.Name = "RequirmentId";
            this.RequirmentId.ReadOnly = true;
            this.RequirmentId.Visible = false;
            // 
            // CarYaoqiu
            // 
            this.CarYaoqiu.DataPropertyName = "CarYaoqiu";
            this.CarYaoqiu.HeaderText = "车辆需求";
            this.CarYaoqiu.Name = "CarYaoqiu";
            // 
            // CarYongtu
            // 
            this.CarYongtu.DataPropertyName = "CarYongtu";
            this.CarYongtu.HeaderText = "车辆用途";
            this.CarYongtu.Name = "CarYongtu";
            this.CarYongtu.ReadOnly = true;
            // 
            // Other
            // 
            this.Other.DataPropertyName = "Other";
            this.Other.HeaderText = "其他";
            this.Other.Name = "Other";
            this.Other.ReadOnly = true;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 472);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequrement)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfor)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGroupSelect;
        private System.Windows.Forms.TextBox txtGroupNameSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.ComboBox cmbGroupType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveCarRequment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCarRequirement;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveCustomerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.DataGridView dgvCustomerInfor;
        private System.Windows.Forms.TextBox txtCarPurpose;
        private System.Windows.Forms.DataGridView dgvUserRequrement;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.DataGridViewLinkColumn btnEditGroup;
        private System.Windows.Forms.DataGridViewLinkColumn btnDeleteGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分组名称;
        private System.Windows.Forms.DataGridViewLinkColumn 编辑;
        private System.Windows.Forms.DataGridViewLinkColumn 删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewLinkColumn UpdateRequirment;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteRequirment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYaoqiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYongtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
    }
}