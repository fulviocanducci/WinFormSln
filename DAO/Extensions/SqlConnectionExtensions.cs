using System.Data.SqlClient;
namespace DAO.Extensions
{
    public static class SqlConnectionExtensions
    {
        public static void OpenIsClose(this SqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConnection.Open(); 
            }
        }
        public static void CloseIsOpen(this SqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}