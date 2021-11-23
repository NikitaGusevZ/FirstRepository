using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class CustomerStorage
    {
        private Dictionary<int, CustomerDomain > Customers { get; } = new Dictionary<int, CustomerDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(CustomerDomain customer)
        {
            Customers.Add(customer.customerId, customer);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public CustomerDomain Read(int customerId)
        {
            return Customers[customerId];
        }

        public CustomerDomain Update(int customerId, CustomerDomain newCustomer)
        {
            Customers[customerId] = newCustomer;
            return Customers[customerId];
        }

        public bool Delete(int customerId)
        {
            return Customers.Remove(customerId);
        }
    }
}