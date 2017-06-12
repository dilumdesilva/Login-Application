using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginSystemWithSP
{
    public partial class MainSelectionForm : Form
    {
        public MainSelectionForm()
        {
            InitializeComponent();
        }

        private void btnLoginMF_Click(object sender, EventArgs e)
        {
            try
            {
                getLoginForm(); //to get the login screen with login button press
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignUpMF_Click(object sender, EventArgs e)
        {
            try
            {
                getSignupForm();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void getLoginForm()
        {
            try
            {
                LoginForm objLoginForm = new LoginForm();
                objLoginForm.Show();
                Hide();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void getSignupForm()
        {
            try
            {
                SignUpForm objSignUpForm = new SignUpForm();
                objSignUpForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void MainSelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
