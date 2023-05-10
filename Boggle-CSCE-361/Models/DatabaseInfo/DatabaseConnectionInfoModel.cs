namespace Boggle_CSCE_361.Models.DatabaseInfo
{
    public class DatabaseConnectionInfoModel
    {
        public static string ConnectionString()
        {
            string conn = "Data Source=localhost\\SQLEXPRESS;Database=master;Integrated Security=SSPI";
            return conn;
        }
    }
}
