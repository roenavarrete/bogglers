using System.Data.SqlClient;

namespace Boggle_CSCE_361.Models.DatabaseInfo
{
    public class DatabaseUtilsModel
    {
        public static bool CheckIfInDatabase(string word)
        {
            string connString = DatabaseConnectionInfoModel.ConnectionString();
            string query = "SELECT COUNT(*) FROM words WHERE word = @InputString";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, conn);
            {
                command.Parameters.AddWithValue("@InputString", word);
                conn.Open();

                int count = (int)command.ExecuteScalar();
                conn.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void InsertWord(string word)
        {
            // Set up connection string
            string connectionString = DatabaseConnectionInfoModel.ConnectionString();

            // Create SQL query
            string query = "INSERT INTO Words (Word) VALUES (@Word)";

            // Set up connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters to command
                command.Parameters.AddWithValue("@Word", word);

                // Open connection, execute command, and close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}