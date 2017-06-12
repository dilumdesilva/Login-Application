using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLayer;
using ObjectLibrary;

namespace UserLoginSystemWithSP
{
    public partial class addToGridForm : Form
    {
        public addToGridForm()
        {
            InitializeComponent();
        }

        private void addToGridForm_Load(object sender, EventArgs e)
        {
            try
            {
                getDeptDetailToCmb();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void getDeptDetailToCmb()
        {
                EmpManger objDataHandler = new EmpManger();

                cmbDeptSF.DataSource = objDataHandler.GetDepartment();

                cmbDeptSF.DisplayMember = "DepartmentName";
                cmbDeptSF.ValueMember = "DeptID";
                cmbDeptSF.SelectedIndex = -1;
        }

        private void btnAddToGrid_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxValidator();
                getDataFromTxt();
                MessageBox.Show("User has been added");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void textBoxValidator()
        {
            if (txtEmpIDSF.Text == "")
            {
                throw new ApplicationException("Employee ID couldn't be empty");
            }
            if (txtUserNameSF.Text == "")
            {
                throw new ApplicationException("please enter the name of employee");
            }
            if (cmbDeptSF.SelectedValue == null)
            {
                throw new ApplicationException("please select the department");
            }
            if (txtEmpDesignationSF.Text == "")
            {
                throw new ApplicationException("Pleae enter the designation of the employee");
            }
        }

        public void getDataFromTxt()
        {   
                string defaultPassword = "123user";
                Employee objEmployee1 = objEmployee1 = new Employee(); //Creating a new object from the Employee class

                objEmployee1.EmpName = txtUserNameSF.Text.ToString();
                objEmployee1.EmpID = Convert.ToInt32(txtEmpIDSF.Text);
                objEmployee1.DeptID = Convert.ToInt32(cmbDeptSF.SelectedValue.ToString());
                objEmployee1.Designation = txtEmpDesignationSF.Text.ToString();
                objEmployee1.Password = defaultPassword.ToString();

            EmpManger objDataHandler = new EmpManger();
                objDataHandler.insertEmployee(objEmployee1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearTextBoxes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }

                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedValue = -1;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);

            //another way of clearing the feilds 
            //txtEmpDesignation.Text = "";
            //cmbDept.SelectedIndex = -1;
        }

    }
}
