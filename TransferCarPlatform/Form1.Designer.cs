namespace TransferCarPlatform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabContro1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBlackList = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BlackListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWriterData = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtBlackList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDriverWriteListSJ = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnComareObject = new System.Windows.Forms.Button();
            this.btnGetDriverListSJ = new System.Windows.Forms.Button();
            this.dgvDriverListSJ = new System.Windows.Forms.DataGridView();
            this.btnEditDriver = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDeleteDriver = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.中文名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.英文名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位中文名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位英文名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职务 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证件类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证件号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工作单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDriverAbnormalSJ = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetBlackListSJ = new System.Windows.Forms.Button();
            this.dgvBlackNameLsitSJ = new System.Windows.Forms.DataGridView();
            this.BlackNameId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectByDepartment = new System.Windows.Forms.Button();
            this.txtSelectByDepartment = new System.Windows.Forms.TextBox();
            this.labSelectByDepartment = new System.Windows.Forms.Label();
            this.btnUploadPics = new System.Windows.Forms.Button();
            this.btnUploadDriverList = new System.Windows.Forms.Button();
            this.btnSelectDriverList = new System.Windows.Forms.Button();
            this.txtDriverListFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.carPannel = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cusomterInfoPannel = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.carRequirementMamageFormpanel = new System.Windows.Forms.Panel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabContro1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlackList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverWriteListSJ)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverListSJ)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverAbnormalSJ)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlackNameLsitSJ)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContro1
            // 
            this.tabContro1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContro1.Controls.Add(this.tabPage1);
            this.tabContro1.Controls.Add(this.tabPage2);
            this.tabContro1.Controls.Add(this.tabPage3);
            this.tabContro1.Controls.Add(this.tabPage4);
            this.tabContro1.Controls.Add(this.tabPage5);
            this.tabContro1.Controls.Add(this.tabPage7);
            this.tabContro1.Location = new System.Drawing.Point(12, 12);
            this.tabContro1.Name = "tabContro1";
            this.tabContro1.SelectedIndex = 0;
            this.tabContro1.Size = new System.Drawing.Size(1179, 595);
            this.tabContro1.TabIndex = 1;
            this.tabContro1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabContro1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvBlackList);
            this.tabPage1.Controls.Add(this.btnWriterData);
            this.tabPage1.Controls.Add(this.btnSelectFile);
            this.tabPage1.Controls.Add(this.txtBlackList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "黑名单管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBlackList
            // 
            this.dgvBlackList.AllowUserToAddRows = false;
            this.dgvBlackList.AllowUserToDeleteRows = false;
            this.dgvBlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBlackList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonEdit,
            this.btnDelete,
            this.BlackListId});
            this.dgvBlackList.Location = new System.Drawing.Point(21, 59);
            this.dgvBlackList.Name = "dgvBlackList";
            this.dgvBlackList.RowTemplate.Height = 23;
            this.dgvBlackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlackList.Size = new System.Drawing.Size(1144, 504);
            this.dgvBlackList.TabIndex = 4;
            this.dgvBlackList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlackList_CellContentClick);
            this.dgvBlackList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlackList_CellDoubleClick);
            this.dgvBlackList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBlackList_RowPostPaint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.HeaderText = "";
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Text = "编辑";
            this.buttonEdit.UseColumnTextForLinkValue = true;
            this.buttonEdit.Width = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "编辑";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.UseColumnTextForLinkValue = true;
            this.btnDelete.Width = 50;
            // 
            // BlackListId
            // 
            this.BlackListId.DataPropertyName = "Id";
            this.BlackListId.HeaderText = "BlackListId";
            this.BlackListId.Name = "BlackListId";
            this.BlackListId.ReadOnly = true;
            this.BlackListId.Visible = false;
            // 
            // btnWriterData
            // 
            this.btnWriterData.Location = new System.Drawing.Point(632, 16);
            this.btnWriterData.Name = "btnWriterData";
            this.btnWriterData.Size = new System.Drawing.Size(155, 23);
            this.btnWriterData.TabIndex = 3;
            this.btnWriterData.Text = "读取并保存黑名单文件";
            this.btnWriterData.UseVisualStyleBackColor = true;
            this.btnWriterData.Click += new System.EventHandler(this.btnWriterData_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(532, 16);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtBlackList
            // 
            this.txtBlackList.Location = new System.Drawing.Point(96, 18);
            this.txtBlackList.Name = "txtBlackList";
            this.txtBlackList.Size = new System.Drawing.Size(393, 21);
            this.txtBlackList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "黑名单文件:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1171, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "司机管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvDriverWriteListSJ);
            this.groupBox4.Location = new System.Drawing.Point(821, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 449);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "白名单";
            // 
            // dgvDriverWriteListSJ
            // 
            this.dgvDriverWriteListSJ.AllowUserToAddRows = false;
            this.dgvDriverWriteListSJ.AllowUserToDeleteRows = false;
            this.dgvDriverWriteListSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDriverWriteListSJ.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriverWriteListSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverWriteListSJ.Location = new System.Drawing.Point(7, 21);
            this.dgvDriverWriteListSJ.Name = "dgvDriverWriteListSJ";
            this.dgvDriverWriteListSJ.RowTemplate.Height = 23;
            this.dgvDriverWriteListSJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriverWriteListSJ.Size = new System.Drawing.Size(331, 422);
            this.dgvDriverWriteListSJ.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btnAddDriver);
            this.groupBox3.Controls.Add(this.btnComareObject);
            this.groupBox3.Controls.Add(this.btnGetDriverListSJ);
            this.groupBox3.Controls.Add(this.dgvDriverListSJ);
            this.groupBox3.Location = new System.Drawing.Point(388, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 450);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "司机名单";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(241, 20);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 4;
            this.btnAddDriver.Text = "新增司机";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnComareObject
            // 
            this.btnComareObject.Location = new System.Drawing.Point(129, 20);
            this.btnComareObject.Name = "btnComareObject";
            this.btnComareObject.Size = new System.Drawing.Size(75, 23);
            this.btnComareObject.TabIndex = 3;
            this.btnComareObject.Text = "比对数据";
            this.btnComareObject.UseVisualStyleBackColor = true;
            this.btnComareObject.Click += new System.EventHandler(this.btnComareObject_Click);
            // 
            // btnGetDriverListSJ
            // 
            this.btnGetDriverListSJ.Location = new System.Drawing.Point(28, 20);
            this.btnGetDriverListSJ.Name = "btnGetDriverListSJ";
            this.btnGetDriverListSJ.Size = new System.Drawing.Size(75, 23);
            this.btnGetDriverListSJ.TabIndex = 1;
            this.btnGetDriverListSJ.Text = "读取司机数据";
            this.btnGetDriverListSJ.UseVisualStyleBackColor = true;
            this.btnGetDriverListSJ.Click += new System.EventHandler(this.btnGetDriverListSJ_Click);
            // 
            // dgvDriverListSJ
            // 
            this.dgvDriverListSJ.AllowUserToAddRows = false;
            this.dgvDriverListSJ.AllowUserToDeleteRows = false;
            this.dgvDriverListSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDriverListSJ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDriverListSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverListSJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditDriver,
            this.btnDeleteDriver,
            this.Id,
            this.中文名称,
            this.英文名称,
            this.单位中文名称,
            this.单位英文名称,
            this.职务,
            this.性别,
            this.出生日期,
            this.身份证件类型,
            this.身份证件号码,
            this.工作单位,
            this.联系方式});
            this.dgvDriverListSJ.Location = new System.Drawing.Point(6, 49);
            this.dgvDriverListSJ.Name = "dgvDriverListSJ";
            this.dgvDriverListSJ.ReadOnly = true;
            this.dgvDriverListSJ.RowTemplate.Height = 23;
            this.dgvDriverListSJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriverListSJ.Size = new System.Drawing.Size(413, 395);
            this.dgvDriverListSJ.TabIndex = 0;
            this.dgvDriverListSJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriverListSJ_CellContentClick);
            this.dgvDriverListSJ.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDriverListSJ_RowPostPaint);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.DataPropertyName = "Id";
            this.btnEditDriver.HeaderText = "";
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.ReadOnly = true;
            this.btnEditDriver.Text = "编辑";
            this.btnEditDriver.UseColumnTextForLinkValue = true;
            this.btnEditDriver.Width = 50;
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.HeaderText = "";
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.ReadOnly = true;
            this.btnDeleteDriver.Text = "删除";
            this.btnDeleteDriver.UseColumnTextForLinkValue = true;
            this.btnDeleteDriver.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // 中文名称
            // 
            this.中文名称.DataPropertyName = "User_ChineseName";
            this.中文名称.HeaderText = "中文名称";
            this.中文名称.Name = "中文名称";
            this.中文名称.ReadOnly = true;
            // 
            // 英文名称
            // 
            this.英文名称.DataPropertyName = "User_EnglishName";
            this.英文名称.HeaderText = "英文名称";
            this.英文名称.Name = "英文名称";
            this.英文名称.ReadOnly = true;
            // 
            // 单位中文名称
            // 
            this.单位中文名称.DataPropertyName = "Department_ChineseName";
            this.单位中文名称.HeaderText = "单位中文名称";
            this.单位中文名称.Name = "单位中文名称";
            this.单位中文名称.ReadOnly = true;
            // 
            // 单位英文名称
            // 
            this.单位英文名称.DataPropertyName = "Department_EnglishName";
            this.单位英文名称.HeaderText = "单位英文名称";
            this.单位英文名称.Name = "单位英文名称";
            this.单位英文名称.ReadOnly = true;
            // 
            // 职务
            // 
            this.职务.DataPropertyName = "Job";
            this.职务.HeaderText = "职务";
            this.职务.Name = "职务";
            this.职务.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "Sex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 出生日期
            // 
            this.出生日期.DataPropertyName = "Birthdy";
            this.出生日期.HeaderText = "出生日期";
            this.出生日期.Name = "出生日期";
            this.出生日期.ReadOnly = true;
            // 
            // 身份证件类型
            // 
            this.身份证件类型.DataPropertyName = "Identification_Type";
            this.身份证件类型.HeaderText = "身份证件类型";
            this.身份证件类型.Name = "身份证件类型";
            this.身份证件类型.ReadOnly = true;
            // 
            // 身份证件号码
            // 
            this.身份证件号码.DataPropertyName = "Identification_Number";
            this.身份证件号码.HeaderText = "身份证件号码";
            this.身份证件号码.Name = "身份证件号码";
            this.身份证件号码.ReadOnly = true;
            // 
            // 工作单位
            // 
            this.工作单位.DataPropertyName = "Employer";
            this.工作单位.HeaderText = "工作单位";
            this.工作单位.Name = "工作单位";
            this.工作单位.ReadOnly = true;
            // 
            // 联系方式
            // 
            this.联系方式.DataPropertyName = "TELEPHONE";
            this.联系方式.HeaderText = "联系方式";
            this.联系方式.Name = "联系方式";
            this.联系方式.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvDriverAbnormalSJ);
            this.groupBox2.Location = new System.Drawing.Point(7, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "异常名单";
            // 
            // dgvDriverAbnormalSJ
            // 
            this.dgvDriverAbnormalSJ.AllowUserToAddRows = false;
            this.dgvDriverAbnormalSJ.AllowUserToDeleteRows = false;
            this.dgvDriverAbnormalSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDriverAbnormalSJ.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriverAbnormalSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverAbnormalSJ.Location = new System.Drawing.Point(7, 21);
            this.dgvDriverAbnormalSJ.Name = "dgvDriverAbnormalSJ";
            this.dgvDriverAbnormalSJ.RowTemplate.Height = 23;
            this.dgvDriverAbnormalSJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriverAbnormalSJ.Size = new System.Drawing.Size(361, 201);
            this.dgvDriverAbnormalSJ.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnGetBlackListSJ);
            this.groupBox1.Controls.Add(this.dgvBlackNameLsitSJ);
            this.groupBox1.Location = new System.Drawing.Point(7, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "黑名单管理";
            // 
            // btnGetBlackListSJ
            // 
            this.btnGetBlackListSJ.Location = new System.Drawing.Point(16, 12);
            this.btnGetBlackListSJ.Name = "btnGetBlackListSJ";
            this.btnGetBlackListSJ.Size = new System.Drawing.Size(75, 23);
            this.btnGetBlackListSJ.TabIndex = 1;
            this.btnGetBlackListSJ.Text = "读取黑名单数据";
            this.btnGetBlackListSJ.UseVisualStyleBackColor = true;
            this.btnGetBlackListSJ.Click += new System.EventHandler(this.btnGetBlackListSJ_Click);
            // 
            // dgvBlackNameLsitSJ
            // 
            this.dgvBlackNameLsitSJ.AllowUserToAddRows = false;
            this.dgvBlackNameLsitSJ.AllowUserToDeleteRows = false;
            this.dgvBlackNameLsitSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBlackNameLsitSJ.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlackNameLsitSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlackNameLsitSJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlackNameId2});
            this.dgvBlackNameLsitSJ.Location = new System.Drawing.Point(16, 41);
            this.dgvBlackNameLsitSJ.Name = "dgvBlackNameLsitSJ";
            this.dgvBlackNameLsitSJ.RowTemplate.Height = 23;
            this.dgvBlackNameLsitSJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlackNameLsitSJ.Size = new System.Drawing.Size(341, 159);
            this.dgvBlackNameLsitSJ.TabIndex = 0;
            this.dgvBlackNameLsitSJ.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBlackNameLsitSJ_RowPostPaint);
            // 
            // BlackNameId2
            // 
            this.BlackNameId2.DataPropertyName = "Id";
            this.BlackNameId2.HeaderText = "BlackNameId2";
            this.BlackNameId2.Name = "BlackNameId2";
            this.BlackNameId2.ReadOnly = true;
            this.BlackNameId2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSelectByDepartment);
            this.panel1.Controls.Add(this.txtSelectByDepartment);
            this.panel1.Controls.Add(this.labSelectByDepartment);
            this.panel1.Controls.Add(this.btnUploadPics);
            this.panel1.Controls.Add(this.btnUploadDriverList);
            this.panel1.Controls.Add(this.btnSelectDriverList);
            this.panel1.Controls.Add(this.txtDriverListFileName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 96);
            this.panel1.TabIndex = 0;
            // 
            // btnSelectByDepartment
            // 
            this.btnSelectByDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectByDepartment.Location = new System.Drawing.Point(907, 63);
            this.btnSelectByDepartment.Name = "btnSelectByDepartment";
            this.btnSelectByDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnSelectByDepartment.TabIndex = 7;
            this.btnSelectByDepartment.Text = "查询";
            this.btnSelectByDepartment.UseVisualStyleBackColor = true;
            this.btnSelectByDepartment.Click += new System.EventHandler(this.btnSelectByDepartment_Click);
            // 
            // txtSelectByDepartment
            // 
            this.txtSelectByDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSelectByDepartment.Location = new System.Drawing.Point(751, 63);
            this.txtSelectByDepartment.Name = "txtSelectByDepartment";
            this.txtSelectByDepartment.Size = new System.Drawing.Size(136, 21);
            this.txtSelectByDepartment.TabIndex = 6;
            // 
            // labSelectByDepartment
            // 
            this.labSelectByDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labSelectByDepartment.AutoSize = true;
            this.labSelectByDepartment.Location = new System.Drawing.Point(661, 63);
            this.labSelectByDepartment.Name = "labSelectByDepartment";
            this.labSelectByDepartment.Size = new System.Drawing.Size(83, 12);
            this.labSelectByDepartment.TabIndex = 5;
            this.labSelectByDepartment.Text = "司机单位查询:";
            // 
            // btnUploadPics
            // 
            this.btnUploadPics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPics.Location = new System.Drawing.Point(897, 23);
            this.btnUploadPics.Name = "btnUploadPics";
            this.btnUploadPics.Size = new System.Drawing.Size(85, 23);
            this.btnUploadPics.TabIndex = 4;
            this.btnUploadPics.Text = "批量导入图片";
            this.btnUploadPics.UseVisualStyleBackColor = true;
            this.btnUploadPics.Click += new System.EventHandler(this.btnUploadPics_Click);
            // 
            // btnUploadDriverList
            // 
            this.btnUploadDriverList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUploadDriverList.Location = new System.Drawing.Point(788, 23);
            this.btnUploadDriverList.Name = "btnUploadDriverList";
            this.btnUploadDriverList.Size = new System.Drawing.Size(75, 23);
            this.btnUploadDriverList.TabIndex = 3;
            this.btnUploadDriverList.Text = "上传文件";
            this.btnUploadDriverList.UseVisualStyleBackColor = true;
            this.btnUploadDriverList.Click += new System.EventHandler(this.btnUploadDriverList_Click);
            // 
            // btnSelectDriverList
            // 
            this.btnSelectDriverList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectDriverList.Location = new System.Drawing.Point(663, 23);
            this.btnSelectDriverList.Name = "btnSelectDriverList";
            this.btnSelectDriverList.Size = new System.Drawing.Size(88, 23);
            this.btnSelectDriverList.TabIndex = 2;
            this.btnSelectDriverList.Text = "选择文件";
            this.btnSelectDriverList.UseVisualStyleBackColor = true;
            this.btnSelectDriverList.Click += new System.EventHandler(this.btnSelectDriverList_Click);
            // 
            // txtDriverListFileName
            // 
            this.txtDriverListFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDriverListFileName.Location = new System.Drawing.Point(70, 3);
            this.txtDriverListFileName.Multiline = true;
            this.txtDriverListFileName.Name = "txtDriverListFileName";
            this.txtDriverListFileName.Size = new System.Drawing.Size(568, 90);
            this.txtDriverListFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "司机数据:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.carPannel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1171, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "车辆管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // carPannel
            // 
            this.carPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carPannel.BackColor = System.Drawing.Color.White;
            this.carPannel.Location = new System.Drawing.Point(4, 3);
            this.carPannel.Name = "carPannel";
            this.carPannel.Size = new System.Drawing.Size(1164, 555);
            this.carPannel.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cusomterInfoPannel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1171, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "客户管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cusomterInfoPannel
            // 
            this.cusomterInfoPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cusomterInfoPannel.BackColor = System.Drawing.Color.White;
            this.cusomterInfoPannel.Location = new System.Drawing.Point(3, 3);
            this.cusomterInfoPannel.Name = "cusomterInfoPannel";
            this.cusomterInfoPannel.Size = new System.Drawing.Size(1165, 563);
            this.cusomterInfoPannel.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.carRequirementMamageFormpanel);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1171, 569);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "用户需求管理";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // carRequirementMamageFormpanel
            // 
            this.carRequirementMamageFormpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carRequirementMamageFormpanel.BackColor = System.Drawing.Color.Transparent;
            this.carRequirementMamageFormpanel.Location = new System.Drawing.Point(4, 4);
            this.carRequirementMamageFormpanel.Name = "carRequirementMamageFormpanel";
            this.carRequirementMamageFormpanel.Size = new System.Drawing.Size(1164, 562);
            this.carRequirementMamageFormpanel.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1171, 569);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "总表管理";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 562);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 611);
            this.Controls.Add(this.tabContro1);
            this.Name = "Form1";
            this.Text = "专车调用平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabContro1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlackList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverWriteListSJ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverListSJ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverAbnormalSJ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlackNameLsitSJ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContro1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dgvBlackList;
        private System.Windows.Forms.Button btnWriterData;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtBlackList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUploadDriverList;
        private System.Windows.Forms.Button btnSelectDriverList;
        private System.Windows.Forms.TextBox txtDriverListFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBlackNameLsitSJ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDriverWriteListSJ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDriverListSJ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDriverAbnormalSJ;
        private System.Windows.Forms.Button btnGetBlackListSJ;
        private System.Windows.Forms.Button btnComareObject;
        private System.Windows.Forms.Button btnGetDriverListSJ;
        private System.Windows.Forms.Panel carPannel;
        private System.Windows.Forms.Panel cusomterInfoPannel;
        private System.Windows.Forms.Panel carRequirementMamageFormpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.DataGridViewLinkColumn btnEditDriver;
        private System.Windows.Forms.DataGridViewLinkColumn btnDeleteDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 中文名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 英文名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位中文名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位英文名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职务;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证件类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证件号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工作单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式;
        private System.Windows.Forms.Button btnUploadPics;
        private System.Windows.Forms.Button btnSelectByDepartment;
        private System.Windows.Forms.TextBox txtSelectByDepartment;
        private System.Windows.Forms.Label labSelectByDepartment;
        private System.Windows.Forms.DataGridViewLinkColumn buttonEdit;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackNameId2;
    }
}

