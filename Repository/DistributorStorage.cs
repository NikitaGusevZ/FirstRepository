using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class DistributorStorage
    {
        private readonly Dictionary<int, DistributorDomain> _distributors  = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public DistributorDomain Create(DistributorDomain distributor)
        {
            var distributorId = _distributors.Keys.Max() + 1;
            distributor.distributorId = distributorId;
            _distributors.Add(distributor.distributorId, distributor);
            return distributor;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DistributorDomain Read(int distributorId)
        {
            return _distributors[distributorId];
        }

        public DistributorDomain Update(int distributorId, DistributorDomain newDistributor)
        {
            _distributors[distributorId] = newDistributor;
            return _distributors[distributorId];
        }

        public bool Delete(int distributorId)
        {
            return _distributors.Remove(distributorId);
        }
    }
}