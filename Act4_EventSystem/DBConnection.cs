using MySql.Data.MySqlClient;

namespace Act4_EventSystem
{
    public class DBConnection
    {
        private static string connectionString =
            "server=localhost;database=event_information_system;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}