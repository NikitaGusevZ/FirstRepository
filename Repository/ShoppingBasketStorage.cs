using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ShoppingBasketStorage
    {
        private readonly Dictionary<int, ShoppingBasket> _connections = new();

        public ShoppingBasket Create(ShoppingBasket connection)
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

        public ShoppingBasket Read(int connectionId)
        {
            return _connections[connectionId];
        }

        public ShoppingBasket Update(int connectionId, ShoppingBasket newConnetion)
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