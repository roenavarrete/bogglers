using System.Data.SqlClient;

namespace Boggle_CSCE_361.Models
{
    public class DatabaseUtils
    {
        public static Boolean CheckIfInDatabase(string word)
        {
            string connString = "Data Source=localhost\\SQLEXPRESS;Database=master;Integrated Security=SSPI";
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
            string connString = "Data Source=localhost\\SQLEXPRESS;Database=master;Integrated Security=SSPI";
            string query = "INSERT INTO words @InputString";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, conn);
            {
                command.Parameters.AddWithValue("@InputString", word);
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();


            }
        }
    }
}