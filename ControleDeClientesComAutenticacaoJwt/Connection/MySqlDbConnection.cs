using MySql.Data.MySqlClient;
using System.Data;

namespace ControleDeClientes.Connection
{
    public class MySqlDbConnection : IDisposable
    {
        public IDbConnection Connection { get; }

        public MySqlDbConnection()
        {
            try
            {
                string Host = "localhost";
                string DatabaseName = "SYSTEM_CRM";
                string DatabaseUser = "root";
                string DatabasePass = "Admin@1234";
                string connectionString = $"server={Host};database={DatabaseName};uid={DatabaseUser};pwd={DatabasePass};";
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
