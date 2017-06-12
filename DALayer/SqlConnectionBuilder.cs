using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALayer
{
    class SqlConnectionBuilder
    {
        public static SqlConnection OpenSqlConnectiion()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=nghq-it-023;Initial Catalog=dbtest;User ID=sa");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                else
                    con.Close();
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
