using FirstRepository.Domain;
using System.Collections.Generic;

namespace FirstRepository.Repository
{
    public class CustomerStorage
    {
        private Dictionary<int, Customer > Customers { get; } = new Dictionary<int, Customer>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(Customer customer)
        {
            Customers.Add(customer.Id, customer);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Customer Read(int customerId)
        {
            return Customers[customerId];
        }

        public Customer Update(int customerId, Customer newCustomer)
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