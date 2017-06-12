using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLibrary;
using System.Data.SqlClient;
using System.Data;

namespace DALayer
{
    public class DataAccessWorkplace
    {
        String query=null;
        private SqlConnection con;
        private SqlCommand com;

        public void insertEmployee(Employee objEmployee1)
        {
            try
            {
                con = SqlConnectionBuilder.OpenSqlConnectiion();

                query = "StoreInDatabase2";
                com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;

                //adding paramerters to  SqlCommand below 
                com.Parameters.AddWithValue("@EmpID", objEmployee1.EmpID);
                com.Parameters.AddWithValue("@EmpName", objEmployee1.EmpName);
                com.Parameters.AddWithValue("@DepID", objEmployee1.DeptID);
                com.Parameters.AddWithValue("@Designation", objEmployee1.Designation);
                com.Parameters.AddWithValue("@EmpPW", objEmployee1.Password);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataTable getDataToDeptCmb() {
            try
            {
                con = SqlConnectionBuilder.OpenSqlConnectiion();

                query = "getDAtaToCmb";

                com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = com;

                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool GetUserlogin(userLogin objuserLogin)
        {
            try
            {

                con = SqlConnectionBuilder.OpenSqlConnectiion();
                query = "[dbo].[giveLoginAccess]";

                `
                com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@password", objuserLogin.Password);
                com.Parameters.AddWithValue("@userName", objuserLogin.userName);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = com;

                DataTable loginDT = new DataTable();
                adp.Fill(loginDT);
                userLogin ObjUserlogin = new userLogin();

                if (loginDT != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getDataToDataGrid()
        {
            try
            {
                con = SqlConnectionBuilder.OpenSqlConnectiion();

                query = "getDataToGrid"; //name of the sp

                com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = com;

                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}

//code by Dilum De silva