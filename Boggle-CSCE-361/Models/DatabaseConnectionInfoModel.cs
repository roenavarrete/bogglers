﻿namespace Boggle_CSCE_361.Models
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
