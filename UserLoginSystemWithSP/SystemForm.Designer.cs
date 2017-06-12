namespace UserLoginSystemWithSP
{
    partial class SystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemForm));
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picBoxTitle4 = new System.Windows.Forms.PictureBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.clmEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.Location = new System.Drawing.Point(23, 314);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(78, 29);
            this.btnAddToDB.TabIndex = 10;
            this.btnAddToDB.Text = "Add";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(89, 88);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(60, 13);
            this.lblCurrentUser.TabIndex = 9;
            this.lblCurrentUser.Text = "User Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Current user - ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(487, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnUpadate_Click);
            // 
            // picBoxTitle4
            // 
            this.picBoxTitle4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle4.Image")));
            this.picBoxTitle4.Location = new System.Drawing.Point(191, 26);
            this.picBoxTitle4.Name = "picBoxTitle4";
            this.picBoxTitle4.Size = new System.Drawing.Size(174, 35);
            this.picBoxTitle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle4.TabIndex = 57;
            this.picBoxTitle4.TabStop = false;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmpID,
            this.clmEmpName,
            this.clmDeptId,
            this.clmDepartmentName,
            this.clmDesignation});
            this.dgvEmployee.Location = new System.Drawing.Point(23, 116);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(542, 179);
            this.dgvEmployee.TabIndex = 58;
            // 
            // clmEmpID
            // 
            this.clmEmpID.DataPropertyName = "EmpID";
            this.clmEmpID.HeaderText = "EmpID";
            this.clmEmpID.Name = "clmEmpID";
            // 
            // clmEmpName
            // 
            this.clmEmpName.DataPropertyName = "EmpName";
            this.clmEmpName.HeaderText = "EmpName";
            this.clmEmpName.Name = "clmEmpName";
            // 
            // clmDeptId
            // 
            this.clmDeptId.DataPropertyName = "DeptId";
            this.clmDeptId.HeaderText = "DeptId";
            this.clmDeptId.Name = "clmDeptId";
            // 
            // clmDepartmentName
            // 
            this.clmDepartmentName.DataPropertyName = "DepartmentName";
            this.clmDepartmentName.HeaderText = "DepartmentName";
            this.clmDepartmentName.Name = "clmDepartmentName";
            // 
            // clmDesignation
            // 
            this.clmDesignation.DataPropertyName = "Designation";
            this.clmDesignation.HeaderText = "Designation";
            this.clmDesignation.Name = "clmDesignation";
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.picBoxTitle4);
            this.Controls.Add(this.btnAddToDB);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemForm";
            this.Text = "SystemForm";
            this.Load += new System.EventHandler(this.SystemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picBoxTitle4;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesignation;
    }
}