using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class DataAccess
    {

        static string connStr = "Server=SANTOS-PC;integrated security=true;database=StudentU";

        public static object GetSingleAnswer(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connStr); 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }

        public static int InsertUpdateDelete(string sql,List<DbParameter>PList)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in PList)
                    cmd.Parameters.Add(p);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }

        public static DataTable GetManyRowsCols(string sql, List<DbParameter> PList)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in PList)
                    cmd.Parameters.Add(p);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        internal static int InsertUpdateDelete(string sql2, List<Student> STList)
        {
            throw new NotImplementedException();
        }
    }
}
