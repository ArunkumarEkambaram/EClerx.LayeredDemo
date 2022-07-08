using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EClerx.LayeredDemo.DAL
{
    public class Employee
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private DataTable dt = null;

        public DataTable GetEmployees(string state)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_GetEmployeeDepartmentByCity", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@State", SqlDbType.VarChar, 50));
                    cmd.Parameters["@State"].Value = state;

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        dt = new DataTable();
                        dt.Load(reader);
                    }
                    reader.Close();
                }
            }
            return dt;
        }        
    }
}
