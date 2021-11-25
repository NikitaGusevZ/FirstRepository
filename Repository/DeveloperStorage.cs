using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class DeveloperStorage
    {
        private readonly Dictionary<int, DeveloperDomain> _developers  = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public DeveloperDomain Create(DeveloperDomain developer)
        {
            var developerId = _developers.Keys.Max() + 1;
            developer.developerId = developerId;
            _developers.Add(developer.developerId, developer);
            return developer;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DeveloperDomain Read(int developerId)
        {
            return _developers[developerId];
        }

        public DeveloperDomain Update(int developerId, DeveloperDomain newDistributor)
        {
            _developers[developerId] = newDistributor;
            return _developers[developerId];
        }

        public bool Delete(int developerId)
        {
            return _developers.Remove(developerId);
        }
    }
}