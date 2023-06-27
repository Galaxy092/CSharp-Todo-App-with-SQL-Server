using System.Data.SqlClient;
using System.Data;

namespace C__Todo_App_with_SQL_Server.DB
{
    public static class DBConnection
    {
        public static DataSet GetConnection(string sql)
        {
            DataSet ds = new DataSet();
            // String Connection
            SqlConnection sqlConnection = new SqlConnection("Data Source=ACER-ASPIRE-7;Initial Catalog=TodoList;Integrated Security=True");
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter dsAdapter = new SqlDataAdapter(command);
            dsAdapter.Fill(ds);
            return ds;
        }
    }
}
