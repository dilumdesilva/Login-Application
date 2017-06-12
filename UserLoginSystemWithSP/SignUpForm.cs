using ObjectLibrary;
using BLLayer;
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
    public partial class SignUpForm : Form
    {
       

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxValidator();
                getDataFromTxt();
                MessageBox.Show("A account has been creaeted");
            }
            catch (ApplicationException ax)
            {
                MessageBox.Show(ax.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void resetSF_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            try
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control ctrl in controls)
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }

                        else if (ctrl is ComboBox)
                        {
                            (ctrl as ComboBox).SelectedValue = -1;
                        }
                        else
                            func(ctrl.Controls);
                };

                func(Controls);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            getDeptDetailToCmb();
        }

        public void getDataFromTxt()
        {
            try
            {
                Employee objEmployee1 = objEmployee1 = new Employee(); //Creating a new object from the Employee class

                objEmployee1.EmpName = txtUserNameSF.Text.ToString();
                objEmployee1.EmpID = Convert.ToInt32(txtEmpIDSF.Text);
                objEmployee1.DeptID = Convert.ToInt32(cmbDeptSF.SelectedValue);
                objEmployee1.Designation = txtEmpDesignationSF.Text;
                bool xx = (1<2) ? true : false;
               


                if (passwordValidation() == true)
                {
                    objEmployee1.Password = txtPasswordConSF.Text.ToString();
                }

                else
                {
                    MessageBox.Show("Please renter your password","Password confirmation failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtPasswordSF.Focus();
                    txtPasswordConSF.Focus();
                }

                EmpManger objDataHandler = new EmpManger();
                objDataHandler.insertEmployee(objEmployee1);

            }
            catch (Exception)
            {
                throw;

            }
        }


        public bool passwordValidation()
        {

            bool validatedPassword = false;

            if (txtPasswordSF.Text == txtPasswordConSF.Text)
            {
                validatedPassword = true;
            }

            return validatedPassword;

        }

        public void getDeptDetailToCmb()
        {
            try
            {
                EmpManger objDataHandler = new EmpManger();

                cmbDeptSF.DataSource = objDataHandler.GetDepartment();
                cmbDeptSF.DisplayMember = "DepartmentName";
                cmbDeptSF.ValueMember = "DeptID";
                cmbDeptSF.SelectedIndex = -1;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void textBoxValidator()
        {
            if (txtEmpIDSF.Text=="")
            {
                throw new ApplicationException("Employee ID couldn't be empty");
            }
            if (txtUserNameSF.Text=="")
            {
                throw new ApplicationException("please enter the name of employee");
            }
            if (cmbDeptSF.SelectedValue == null)//selectedIndex !=-1
            {
                throw new ApplicationException("please select the department");
            }
            if (txtEmpDesignationSF.Text == "")
            {
                throw new ApplicationException("Pleae enter the designation of the employee");
            }
            if (txtPasswordSF.Text == "")
            {
                throw new ApplicationException("paassword feild could not be empty");
            }
            if (txtPasswordConSF.Text == "")
            {
                throw new ApplicationException("Please re-enter your password");
            }


        }

        private void cmbDeptSF_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (true)
            {
                MessageBox.Show("You change something..");
            }
        }

        private void cmbDeptSF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("You change something..");
            }
        }
    }
}
