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
    public partial class SystemForm : Form
    {

        public string us { get; set; }
        public SystemForm()
        {
            InitializeComponent();

        }
        public SystemForm(string userName)
        {
            InitializeComponent();
            us = userName;

        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            try
            {
                //userLogin objuserLogin = new userLogin();
                //objuserLogin.userName = currentUser;
                if (us!=null)
                {
                    lblCurrentUser.Text = us.ToString();
                }

                setDataToGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void setDataToGrid()
        {
            dgvEmployee.DataSource = GetEmployeeviewModel();
            dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.Columns["clmDeptId"].Visible = false;
        }

        private void dgvDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                throw ;
            }
        }

        public List<EmployeeVewModel> GetEmployeeviewModel()
        {
            EmpManger em = new EmpManger();
            List<Employee> lstEmoployee = new List<Employee>();
            lstEmoployee = em.GetEmployee();

            List<EmployeeVewModel> lstEmpoloyeeViewModel = new List<EmployeeVewModel>();
            EmployeeVewModel ObjEmployeeVewModel = null;

            foreach (var item in lstEmoployee)
            {
                ObjEmployeeVewModel = new EmployeeVewModel();
                ObjEmployeeVewModel.EmpID = item.EmpID;
                ObjEmployeeVewModel.EmpName = item.EmpName;
                ObjEmployeeVewModel.Designation = item.Designation;
                ObjEmployeeVewModel.DeptID = item.objDepartment.DeptId;
                ObjEmployeeVewModel.DepartmentName = item.objDepartment.DepartmentName;
                lstEmpoloyeeViewModel.Add(ObjEmployeeVewModel);
            }
            return lstEmpoloyeeViewModel;
         }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            addToGridForm objaddToGridForm = new addToGridForm();
            objaddToGridForm.Show();
        }
    }
}
public class EmployeeVewModel
{

    public int EmpID { get; set; }
    public string EmpName { get; set; }  
    public string DepartmentName { get; set; }
    public string Designation { get; set; }   
    public int DeptID { get; set; }

}
//code by Dilum De silva