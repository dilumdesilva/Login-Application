namespace UserLoginSystemWithSP
{
    partial class addToGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addToGridForm));
            this.btnAddToGrid = new System.Windows.Forms.Button();
            this.txtEmpDesignationSF = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.cmbDeptSF = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.picBoxTitle3 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.txtUserNameSF = new System.Windows.Forms.TextBox();
            this.empId = new System.Windows.Forms.Label();
            this.txtEmpIDSF = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToGrid
            // 
            this.btnAddToGrid.Location = new System.Drawing.Point(14, 256);
            this.btnAddToGrid.Name = "btnAddToGrid";
            this.btnAddToGrid.Size = new System.Drawing.Size(84, 28);
            this.btnAddToGrid.TabIndex = 19;
            this.btnAddToGrid.Text = "Add ";
            this.btnAddToGrid.UseVisualStyleBackColor = true;
            this.btnAddToGrid.Click += new System.EventHandler(this.btnAddToGrid_Click);
            // 
            // txtEmpDesignationSF
            // 
            this.txtEmpDesignationSF.Location = new System.Drawing.Point(119, 210);
            this.txtEmpDesignationSF.Name = "txtEmpDesignationSF";
            this.txtEmpDesignationSF.Size = new System.Drawing.Size(181, 20);
            this.txtEmpDesignationSF.TabIndex = 74;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(11, 213);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 73;
            this.lblDesignation.Text = "Designation";
            // 
            // cmbDeptSF
            // 
            this.cmbDeptSF.FormattingEnabled = true;
            this.cmbDeptSF.Location = new System.Drawing.Point(119, 178);
            this.cmbDeptSF.Name = "cmbDeptSF";
            this.cmbDeptSF.Size = new System.Drawing.Size(137, 21);
            this.cmbDeptSF.TabIndex = 72;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(11, 181);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 71;
            this.lblDepartment.Text = "Department";
            // 
            // picBoxTitle3
            // 
            this.picBoxTitle3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle3.Image")));
            this.picBoxTitle3.Location = new System.Drawing.Point(69, 30);
            this.picBoxTitle3.Name = "picBoxTitle3";
            this.picBoxTitle3.Size = new System.Drawing.Size(174, 35);
            this.picBoxTitle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle3.TabIndex = 70;
            this.picBoxTitle3.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(11, 149);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(58, 13);
            this.userName.TabIndex = 69;
            this.userName.Text = "User name";
            // 
            // txtUserNameSF
            // 
            this.txtUserNameSF.Location = new System.Drawing.Point(119, 146);
            this.txtUserNameSF.Name = "txtUserNameSF";
            this.txtUserNameSF.Size = new System.Drawing.Size(181, 20);
            this.txtUserNameSF.TabIndex = 68;
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Location = new System.Drawing.Point(11, 121);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(61, 13);
            this.empId.TabIndex = 67;
            this.empId.Text = "Employe ID";
            // 
            // txtEmpIDSF
            // 
            this.txtEmpIDSF.Location = new System.Drawing.Point(119, 118);
            this.txtEmpIDSF.Name = "txtEmpIDSF";
            this.txtEmpIDSF.Size = new System.Drawing.Size(181, 20);
            this.txtEmpIDSF.TabIndex = 66;
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(11, 89);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(107, 13);
            this.command.TabIndex = 63;
            this.command.Text = "Please fill your details";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 28);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // addToGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 296);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEmpDesignationSF);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.cmbDeptSF);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.picBoxTitle3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.txtUserNameSF);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.txtEmpIDSF);
            this.Controls.Add(this.command);
            this.Controls.Add(this.btnAddToGrid);
            this.Name = "addToGridForm";
            this.Text = "addToGridForm";
            this.Load += new System.EventHandler(this.addToGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToGrid;
        private System.Windows.Forms.TextBox txtEmpDesignationSF;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ComboBox cmbDeptSF;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.PictureBox picBoxTitle3;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtUserNameSF;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.TextBox txtEmpIDSF;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.Button btnReset;
    }
}