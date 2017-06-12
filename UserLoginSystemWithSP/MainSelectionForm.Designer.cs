namespace UserLoginSystemWithSP
{
    partial class MainSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelectionForm));
            this.btnSignUpMF = new System.Windows.Forms.Button();
            this.btnLoginMF = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picBoxTitle1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUpMF
            // 
            this.btnSignUpMF.BackColor = System.Drawing.Color.Lime;
            this.btnSignUpMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpMF.Location = new System.Drawing.Point(76, 262);
            this.btnSignUpMF.Name = "btnSignUpMF";
            this.btnSignUpMF.Size = new System.Drawing.Size(105, 33);
            this.btnSignUpMF.TabIndex = 42;
            this.btnSignUpMF.Text = "Sign up";
            this.btnSignUpMF.UseVisualStyleBackColor = false;
            this.btnSignUpMF.Click += new System.EventHandler(this.btnSignUpMF_Click);
            // 
            // btnLoginMF
            // 
            this.btnLoginMF.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginMF.Location = new System.Drawing.Point(76, 208);
            this.btnLoginMF.Name = "btnLoginMF";
            this.btnLoginMF.Size = new System.Drawing.Size(105, 35);
            this.btnLoginMF.TabIndex = 41;
            this.btnLoginMF.Text = "Log in";
            this.btnLoginMF.UseVisualStyleBackColor = false;
            this.btnLoginMF.Click += new System.EventHandler(this.btnLoginMF_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(106, -19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(155, 16);
            this.title.TabIndex = 40;
            this.title.Text = "DMS - Login Systems";
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(56, 70);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(134, 120);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 39;
            this.picBoxUser.TabStop = false;
            // 
            // picBoxTitle1
            // 
            this.picBoxTitle1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTitle1.Image")));
            this.picBoxTitle1.Location = new System.Drawing.Point(69, 22);
            this.picBoxTitle1.Name = "picBoxTitle1";
            this.picBoxTitle1.Size = new System.Drawing.Size(112, 24);
            this.picBoxTitle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTitle1.TabIndex = 43;
            this.picBoxTitle1.TabStop = false;
            // 
            // MainSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 317);
            this.Controls.Add(this.picBoxTitle1);
            this.Controls.Add(this.btnSignUpMF);
            this.Controls.Add(this.btnLoginMF);
            this.Controls.Add(this.title);
            this.Controls.Add(this.picBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSelectionForm";
            this.Text = "MainSelectionForm";
            this.Load += new System.EventHandler(this.MainSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUpMF;
        private System.Windows.Forms.Button btnLoginMF;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxTitle1;
    }
}