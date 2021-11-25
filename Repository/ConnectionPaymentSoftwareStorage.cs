using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ConnectionPaymentSoftwareStorage
    {
        private readonly Dictionary<int, ConnectionPaymentSoftware> _connections = new();

        public ConnectionPaymentSoftware Create(ConnectionPaymentSoftware connection)
        {
            // var connectionId = _connections.Keys.Last() + 1;
            var connectionId = _connections.Keys.Max() + 1;
            connection.Id = connectionId;
            _connections.Add(connection.Id, connection);
            return connection;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public ConnectionPaymentSoftware Read(int connectionId)
        {
            return _connections[connectionId];
        }

        public ConnectionPaymentSoftware Update(int connectionId, ConnectionPaymentSoftware newConnetion)
        {
            _connections[connectionId] = newConnetion;
            return _connections[connectionId];
        }

        public bool Delete(int connectionId)
        {
            return _connections.Remove(connectionId);
        }
    }
}