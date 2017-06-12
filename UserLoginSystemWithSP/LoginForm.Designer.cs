namespace UserLoginSystemWithSP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblUNameLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.btnLoginToSystem = new System.Windows.Forms.Button();
            this.picBoxTitle2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 128);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(186, 156);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordLogin.TabIndex = 21;
            this.lblPasswordLogin.Text = "Password";
            // 
            // lblUNameLogin
            // 
            this.lblUNameLogin.AutoSize = true;
            this.lblUNameLogin.Location = new System.Drawing.Point(186, 120);
            this.lblUNameLogin.Name = "lblUNameLogin";
            this.lblUNameLogin.Size = new System.Drawing.Size(58, 13);
            this.lblUNameLogin.TabIndex = 20;
            this.lblUNameLogin.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please enter your user credentials to login.      ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(259, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(259, 117);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(181, 20);
            this.txtuserName.TabIndex = 17;
            // 
            // btnLoginToSystem
            // 
            this.btnLoginToSystem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginToSystem.Location = new System.Drawing.Point(184, 190);
            this.btnLoginToSystem.Name = "btnLoginToSystem";
            this.btnLoginToSystem.Size = new System.Drawing.Size(92, 25);
            this.btnLoginToSystem.TabIndex = 16;
            this.btnLoginToSystem.Text = "Login";
            this.btnLoginToSystem.UseVisualStyleBackColor = false;
            this.btnLoginToSystem.Click += new System.EventHandler(this.btnLoginToSystem_Click);
            // 
            // picBoxTitle2
            // 
            this.picBoxTitle2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle2.Image")));
            this.picBoxTitle2.Location = new System.Drawing.Point(136, 21);
            this.picBoxTitle2.Name = "picBoxTitle2";
            this.picBoxTitle2.Size = new System.Drawing.Size(174, 35);
            this.picBoxTitle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle2.TabIndex = 44;
            this.picBoxTitle2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 232);
            this.Controls.Add(this.picBoxTitle2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUNameLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.btnLoginToSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblUNameLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Button btnLoginToSystem;
        private System.Windows.Forms.PictureBox picBoxTitle2;
    }
}