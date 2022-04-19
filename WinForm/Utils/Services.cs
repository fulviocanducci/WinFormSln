using System.Configuration;

namespace WinForm.Utils
{
    public static class Services
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        }
    }
}
