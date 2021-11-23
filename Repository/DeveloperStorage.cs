using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class DeveloperStorage
    {
        private Dictionary<int, DeveloperDomain> Developers { get; } = new Dictionary<int, DeveloperDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(DeveloperDomain developer)
        {
            Developers.Add(developer.developerId, developer);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DeveloperDomain Read(int developerId)
        {
            return Developers[developerId];
        }

        public DeveloperDomain Update(int developerId, DeveloperDomain newDistributor)
        {
            Developers[developerId] = newDistributor;
            return Developers[developerId];
        }

        public bool Delete(int developerId)
        {
            return Developers.Remove(developerId);
        }
    }
}