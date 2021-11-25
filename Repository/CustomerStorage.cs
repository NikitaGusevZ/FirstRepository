using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class CustomerStorage
    {
        private readonly Dictionary<int, Customer > _customers  = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Customer Create(Customer customer)
        {
            var customerId = _customers.Keys.Max() + 1;
            customer.Id = customerId;
            _customers.Add(customer.Id, customer);
            return customer;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Customer Read(int customerId)
        {
            return _customers[customerId];
        }

        public Customer Update(int customerId, Customer newCustomer)
        {
            _customers[customerId] = newCustomer;
            return _customers[customerId];
        }

        public bool Delete(int customerId)
        {
            return _customers.Remove(customerId);
        }
    }
}