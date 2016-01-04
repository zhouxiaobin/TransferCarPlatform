namespace TransferCarPlatform.CustomerFolder
{
    partial class GroupRequirement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarYaoqiu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarYongtu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用车要求:";
            // 
            // txtCarYaoqiu
            // 
            this.txtCarYaoqiu.Location = new System.Drawing.Point(80, 24);
            this.txtCarYaoqiu.Name = "txtCarYaoqiu";
            this.txtCarYaoqiu.Size = new System.Drawing.Size(158, 21);
            this.txtCarYaoqiu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "车辆用途:";
            // 
            // txtCarYongtu
            // 
            this.txtCarYongtu.Location = new System.Drawing.Point(80, 72);
            this.txtCarYongtu.Name = "txtCarYongtu";
            this.txtCarYongtu.Size = new System.Drawing.Size(158, 21);
            this.txtCarYongtu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "其他:";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(78, 118);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(194, 99);
            this.txtOther.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GroupRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCarYongtu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarYaoqiu);
            this.Controls.Add(this.label1);
            this.Name = "GroupRequirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupRequirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarYaoqiu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarYongtu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnSave;
    }
}