using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class Connection_Payment_SoftwareStorage
    {
        private Dictionary<int, Connection_Payment_Software> Connections { get; } = new Dictionary<int, Connection_Payment_Software>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(Connection_Payment_Software connection)
        {
            Connections.Add(connection.connectionId, connection);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Connection_Payment_Software Read(int connectionId)
        {
            return Connections[connectionId];
        }

        public Connection_Payment_Software Update(int connectionId, Connection_Payment_Software newConnetion)
        {
            Connections[connectionId] = newConnetion;
            return Connections[connectionId];
        }

        public bool Delete(int connectionId)
        {
            return Connections.Remove(connectionId);
        }
    }
}