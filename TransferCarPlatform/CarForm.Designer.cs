namespace TransferCarPlatform
{
    partial class CarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadFiles = new System.Windows.Forms.Button();
            this.tbnAddNewCar = new System.Windows.Forms.Button();
            this.btnUploadCarFile = new System.Windows.Forms.Button();
            this.btnSelecetCarFile = new System.Windows.Forms.Button();
            this.txtCarLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarResource = new System.Windows.Forms.TextBox();
            this.txtUseYear = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotorcyleType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotorcyleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUploadFiles);
            this.panel1.Controls.Add(this.tbnAddNewCar);
            this.panel1.Controls.Add(this.btnUploadCarFile);
            this.panel1.Controls.Add(this.btnSelecetCarFile);
            this.panel1.Controls.Add(this.txtCarLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 97);
            this.panel1.TabIndex = 0;
            // 
            // btnUploadFiles
            // 
            this.btnUploadFiles.Location = new System.Drawing.Point(899, 69);
            this.btnUploadFiles.Name = "btnUploadFiles";
            this.btnUploadFiles.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFiles.TabIndex = 5;
            this.btnUploadFiles.Text = "批量上传图片";
            this.btnUploadFiles.UseVisualStyleBackColor = true;
            this.btnUploadFiles.Click += new System.EventHandler(this.btnUploadFiles_Click);
            // 
            // tbnAddNewCar
            // 
            this.tbnAddNewCar.Location = new System.Drawing.Point(758, 69);
            this.tbnAddNewCar.Name = "tbnAddNewCar";
            this.tbnAddNewCar.Size = new System.Drawing.Size(75, 23);
            this.tbnAddNewCar.TabIndex = 4;
            this.tbnAddNewCar.Text = "新增";
            this.tbnAddNewCar.UseVisualStyleBackColor = true;
            this.tbnAddNewCar.Click += new System.EventHandler(this.tbnAddNewCar_Click);
            // 
            // btnUploadCarFile
            // 
            this.btnUploadCarFile.Location = new System.Drawing.Point(899, 16);
            this.btnUploadCarFile.Name = "btnUploadCarFile";
            this.btnUploadCarFile.Size = new System.Drawing.Size(75, 23);
            this.btnUploadCarFile.TabIndex = 3;
            this.btnUploadCarFile.Text = "上传文件";
            this.btnUploadCarFile.UseVisualStyleBackColor = true;
            this.btnUploadCarFile.Click += new System.EventHandler(this.btnUploadCarFile_Click);
            // 
            // btnSelecetCarFile
            // 
            this.btnSelecetCarFile.Location = new System.Drawing.Point(758, 16);
            this.btnSelecetCarFile.Name = "btnSelecetCarFile";
            this.btnSelecetCarFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelecetCarFile.TabIndex = 2;
            this.btnSelecetCarFile.Text = "选择文件";
            this.btnSelecetCarFile.UseVisualStyleBackColor = true;
            this.btnSelecetCarFile.Click += new System.EventHandler(this.btnSelecetCarFile_Click);
            // 
            // txtCarLog
            // 
            this.txtCarLog.Location = new System.Drawing.Point(102, 16);
            this.txtCarLog.Multiline = true;
            this.txtCarLog.Name = "txtCarLog";
            this.txtCarLog.Size = new System.Drawing.Size(601, 78);
            this.txtCarLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆文件:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCarResource);
            this.panel2.Controls.Add(this.txtUseYear);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMotorcyleType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBrand);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 49);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "车辆来源:";
            // 
            // txtCarResource
            // 
            this.txtCarResource.Location = new System.Drawing.Point(874, 15);
            this.txtCarResource.Name = "txtCarResource";
            this.txtCarResource.Size = new System.Drawing.Size(100, 21);
            this.txtCarResource.TabIndex = 9;
            // 
            // txtUseYear
            // 
            this.txtUseYear.Location = new System.Drawing.Point(667, 11);
            this.txtUseYear.Name = "txtUseYear";
            this.txtUseYear.Size = new System.Drawing.Size(100, 21);
            this.txtUseYear.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1010, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "年份:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(484, 10);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 21);
            this.txtColor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "颜色:";
            // 
            // txtMotorcyleType
            // 
            this.txtMotorcyleType.Location = new System.Drawing.Point(304, 10);
            this.txtMotorcyleType.Name = "txtMotorcyleType";
            this.txtMotorcyleType.Size = new System.Drawing.Size(100, 21);
            this.txtMotorcyleType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "车型:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(81, 11);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 21);
            this.txtBrand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "品牌:";
            // 
            // dgvCarList
            // 
            this.dgvCarList.AllowUserToAddRows = false;
            this.dgvCarList.AllowUserToDeleteRows = false;
            this.dgvCarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdit,
            this.btnDelete,
            this.Id,
            this.PlateNumber,
            this.Color,
            this.Brand,
            this.UseYear,
            this.MotorcyleType,
            this.CarResource});
            this.dgvCarList.Location = new System.Drawing.Point(13, 173);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.RowTemplate.Height = 23;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(1123, 241);
            this.dgvCarList.TabIndex = 2;
            this.dgvCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarList_CellContentClick);
            this.dgvCarList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCarList_RowPostPaint);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseColumnTextForLinkValue = true;
            this.btnEdit.Width = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseColumnTextForLinkValue = true;
            this.btnDelete.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PlateNumber
            // 
            this.PlateNumber.DataPropertyName = "PlateNumber";
            this.PlateNumber.HeaderText = "车牌号";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "品牌";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // UseYear
            // 
            this.UseYear.DataPropertyName = "UseYear";
            this.UseYear.HeaderText = "使用年份";
            this.UseYear.Name = "UseYear";
            this.UseYear.ReadOnly = true;
            // 
            // MotorcyleType
            // 
            this.MotorcyleType.DataPropertyName = "MotorcyleType";
            this.MotorcyleType.HeaderText = "车型";
            this.MotorcyleType.Name = "MotorcyleType";
            this.MotorcyleType.ReadOnly = true;
            // 
            // CarResource
            // 
            this.CarResource.DataPropertyName = "CarResource";
            this.CarResource.HeaderText = "车辆来源";
            this.CarResource.Name = "CarResource";
            this.CarResource.ReadOnly = true;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 426);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUploadCarFile;
        private System.Windows.Forms.Button btnSelecetCarFile;
        private System.Windows.Forms.TextBox txtCarLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMotorcyleType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUseYear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarResource;
        private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotorcyleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarResource;
        private System.Windows.Forms.Button tbnAddNewCar;
        private System.Windows.Forms.Button btnUploadFiles;

    }
}