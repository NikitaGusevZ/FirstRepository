using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class DistributorStorage
    {
        private Dictionary<int, DistributorDomain> Distributors { get; } = new Dictionary<int, DistributorDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(DistributorDomain distributor)
        {
            Distributors.Add(distributor.distributorId, distributor);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DistributorDomain Read(int distributorId)
        {
            return Distributors[distributorId];
        }

        public DistributorDomain Update(int distributorId, DistributorDomain newDistributor)
        {
            Distributors[distributorId] = newDistributor;
            return Distributors[distributorId];
        }

        public bool Delete(int distributorId)
        {
            return Distributors.Remove(distributorId);
        }
    }
}