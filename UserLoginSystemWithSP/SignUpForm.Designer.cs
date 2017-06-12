namespace UserLoginSystemWithSP
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.userName = new System.Windows.Forms.Label();
            this.txtUserNameSF = new System.Windows.Forms.TextBox();
            this.empId = new System.Windows.Forms.Label();
            this.txtEmpIDSF = new System.Windows.Forms.TextBox();
            this.picBoxSF = new System.Windows.Forms.PictureBox();
            this.password2 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.Label();
            this.command = new System.Windows.Forms.Label();
            this.txtPasswordConSF = new System.Windows.Forms.TextBox();
            this.txtPasswordSF = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.picBoxTitle3 = new System.Windows.Forms.PictureBox();
            this.resetSF = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDeptSF = new System.Windows.Forms.ComboBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmpDesignationSF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle3)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(196, 133);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(58, 13);
            this.userName.TabIndex = 52;
            this.userName.Text = "User name";
            // 
            // txtUserNameSF
            // 
            this.txtUserNameSF.Location = new System.Drawing.Point(304, 130);
            this.txtUserNameSF.Name = "txtUserNameSF";
            this.txtUserNameSF.Size = new System.Drawing.Size(181, 20);
            this.txtUserNameSF.TabIndex = 51;
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Location = new System.Drawing.Point(196, 105);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(61, 13);
            this.empId.TabIndex = 50;
            this.empId.Text = "Employe ID";
            // 
            // txtEmpIDSF
            // 
            this.txtEmpIDSF.Location = new System.Drawing.Point(304, 102);
            this.txtEmpIDSF.Name = "txtEmpIDSF";
            this.txtEmpIDSF.Size = new System.Drawing.Size(181, 20);
            this.txtEmpIDSF.TabIndex = 49;
            // 
            // picBoxSF
            // 
            this.picBoxSF.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSF.Image")));
            this.picBoxSF.Location = new System.Drawing.Point(12, 102);
            this.picBoxSF.Name = "picBoxSF";
            this.picBoxSF.Size = new System.Drawing.Size(159, 162);
            this.picBoxSF.TabIndex = 48;
            this.picBoxSF.TabStop = false;
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Location = new System.Drawing.Point(196, 251);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(90, 13);
            this.password2.TabIndex = 47;
            this.password2.Text = "Confirm password";
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Location = new System.Drawing.Point(196, 225);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(53, 13);
            this.password1.TabIndex = 46;
            this.password1.Text = "Password";
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(196, 73);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(107, 13);
            this.command.TabIndex = 45;
            this.command.Text = "Please fill your details";
            // 
            // txtPasswordConSF
            // 
            this.txtPasswordConSF.Location = new System.Drawing.Point(304, 248);
            this.txtPasswordConSF.Name = "txtPasswordConSF";
            this.txtPasswordConSF.PasswordChar = '*';
            this.txtPasswordConSF.Size = new System.Drawing.Size(181, 20);
            this.txtPasswordConSF.TabIndex = 44;
            // 
            // txtPasswordSF
            // 
            this.txtPasswordSF.Location = new System.Drawing.Point(304, 222);
            this.txtPasswordSF.Name = "txtPasswordSF";
            this.txtPasswordSF.Size = new System.Drawing.Size(181, 20);
            this.txtPasswordSF.TabIndex = 43;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateAccount.Location = new System.Drawing.Point(199, 289);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(104, 30);
            this.btnCreateAccount.TabIndex = 42;
            this.btnCreateAccount.Text = "Create my account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // picBoxTitle3
            // 
            this.picBoxTitle3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle3.Image")));
            this.picBoxTitle3.Location = new System.Drawing.Point(157, 22);
            this.picBoxTitle3.Name = "picBoxTitle3";
            this.picBoxTitle3.Size = new System.Drawing.Size(174, 35);
            this.picBoxTitle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle3.TabIndex = 55;
            this.picBoxTitle3.TabStop = false;
            // 
            // resetSF
            // 
            this.resetSF.Location = new System.Drawing.Point(309, 289);
            this.resetSF.Name = "resetSF";
            this.resetSF.Size = new System.Drawing.Size(104, 30);
            this.resetSF.TabIndex = 56;
            this.resetSF.Text = "Reset";
            this.resetSF.UseVisualStyleBackColor = true;
            this.resetSF.Click += new System.EventHandler(this.resetSF_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(196, 165);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 57;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDeptSF
            // 
            this.cmbDeptSF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDeptSF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDeptSF.FormattingEnabled = true;
            this.cmbDeptSF.Location = new System.Drawing.Point(304, 162);
            this.cmbDeptSF.Name = "cmbDeptSF";
            this.cmbDeptSF.Size = new System.Drawing.Size(137, 21);
            this.cmbDeptSF.TabIndex = 58;
            this.cmbDeptSF.SelectedIndexChanged += new System.EventHandler(this.cmbDeptSF_SelectedIndexChanged);
            this.cmbDeptSF.SelectionChangeCommitted += new System.EventHandler(this.cmbDeptSF_SelectionChangeCommitted);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(196, 197);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 59;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmpDesignationSF
            // 
            this.txtEmpDesignationSF.Location = new System.Drawing.Point(304, 194);
            this.txtEmpDesignationSF.Name = "txtEmpDesignationSF";
            this.txtEmpDesignationSF.Size = new System.Drawing.Size(181, 20);
            this.txtEmpDesignationSF.TabIndex = 60;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 329);
            this.Controls.Add(this.txtEmpDesignationSF);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.cmbDeptSF);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.resetSF);
            this.Controls.Add(this.picBoxTitle3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.txtUserNameSF);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.txtEmpIDSF);
            this.Controls.Add(this.picBoxSF);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.command);
            this.Controls.Add(this.txtPasswordConSF);
            this.Controls.Add(this.txtPasswordSF);
            this.Controls.Add(this.btnCreateAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtUserNameSF;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.TextBox txtEmpIDSF;
        private System.Windows.Forms.PictureBox picBoxSF;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.TextBox txtPasswordConSF;
        private System.Windows.Forms.TextBox txtPasswordSF;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.PictureBox picBoxTitle3;
        private System.Windows.Forms.Button resetSF;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDeptSF;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmpDesignationSF;
    }
}