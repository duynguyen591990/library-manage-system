using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace librarysystem
{
    class Connect
    {
        SqlConnection conn;
        public static SqlConnection getConnection()
        {
            SqlConnection conn = null;
            String strCon = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            try
            {
                conn = new SqlConnection(strCon);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
        public static System.Data.DataTable getDataTable(SqlConnection conn, String tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Permission FROM " + tableName, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, tableName);
            return ds.Tables[0];
        }
    }
}
