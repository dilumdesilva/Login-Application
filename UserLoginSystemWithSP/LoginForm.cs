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
    public partial class LoginForm : Form
    {
        public int userid { get; set; }
        public string userName { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        //public void giveLoginAccess()
        //{
        //    DataHandler objDataHandler = new DataHandler();
        //    //DataTable loginTable = new DataTable();

        //    List<Employee> lstEmployee = new List<Employee>();
        //    lstEmployee = objDataHandler.GetLoginDetails();

        //    List<Employee> lstEmployeeFiltered = new List<Employee>();


        //    lstEmployeeFiltered = (from lstt in lstEmployee
        //                           where lstt.EmpName.Equals(textBoxUserNameLF.ToString().Trim()) && lstt.Password.Equals(textBoxPasswordLF.Text.Trim().ToString())
        //                           select lstt).ToList();


        //    if(lstEmployeeFiltered.Count()> 0)
        //    {
        //        MessageBox.Show("Done");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed");
        //    }

        //}


        public void login()
        {
            bool x;
            userLogin objuserLogin = new userLogin();
            objuserLogin.userName = txtuserName.Text.ToString();
            objuserLogin.Password = txtPassword.Text.ToString();

            EmpManger obj = new EmpManger();
            x = obj.Login(objuserLogin);

            if (x==true)
            {
                MessageBox.Show("login succesful !");
                userName = txtuserName.Text.ToString();
                SystemForm objSystemForm = new SystemForm(userName);
                objSystemForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("login fail !");
            }
        }

        private void btnLoginToSystem_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
//code by Dilum De silva