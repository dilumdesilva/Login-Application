using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLibrary;
using DALayer;
using System.Data;

namespace BLLayer
{
    public class EmpManger
    {

        public void insertEmployee(Employee object1)
        {
            DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
            objDataAccessWorkplace.insertEmployee(object1);
           
        }

        public List<Department> GetDepartment()
        {
            try
            {
                DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
                DataTable dt = new DataTable();

                List<Department> lstDepartment = new List<Department>();

                dt = objDataAccessWorkplace.getDataToDeptCmb();

                foreach (DataRow dr in dt.Rows)
                {
                    Department ObjDepartment = new Department
                    {
                        DeptId = Convert.ToInt32(dr["DeptID"]),
                        DepartmentName = dr["DeptName"].ToString()
                    };
                    lstDepartment.Add(ObjDepartment);
                }
                return lstDepartment;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool Login(userLogin objuserLogin)
        {
            DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
            return objDataAccessWorkplace.GetUserlogin(objuserLogin);

        }

        //public DataTable getDataToFilGrid()
        //{
        //    DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
        //    objDataAccessWorkplace.getDataToDataGrid();

        //    return objDataAccessWorkplace.getDataToDataGrid(); 
        //}

        public List<Employee> GetEmployee()
        {
            DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
            DataTable dt = new DataTable();
            dt = objDataAccessWorkplace.getDataToDataGrid();

            List<Employee> lstEmployee = new List<Employee>();

            foreach (DataRow dr in dt.Rows)
            {
                Employee ObjEmployee = new Employee
                {
                    EmpID = Convert.ToInt32(dr["EmpID"]),
                    EmpName = dr["EmpName"].ToString(),
                    Designation = dr["Designation"].ToString(),
                    objDepartment = new Department()
                    {
                        DeptId = Convert.ToInt32(dr["DeptID"]),
                        DepartmentName = dr["DeptName"].ToString()
                    },
                };
                lstEmployee.Add(ObjEmployee);
            }

            return lstEmployee;
        }


        //public List<Employee> GetEmployeeList()
        //{
        //    DataAccessWorkplace objDataAccessWorkplace = new DataAccessWorkplace();
        //    DataTable dt =  objDataAccessWorkplace.getDataToDataGrid();

        //    List<Employee> lstEmployee = new List<Employee>();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        Employee ObjEmployee = new Employee
        //        {
        //            EmpID = (dr[]);
        //        };
        //    }
    }

    }

//code by Dilum De silva