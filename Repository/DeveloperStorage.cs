using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class DeveloperStorage
    {
        private readonly Dictionary<int, Developer> _developers  = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Developer Create(Developer developer)
        {
            var developerId = _developers.Keys.Max() + 1;
            developer.Id = developerId;
            _developers.Add(developer.Id, developer);
            return developer;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Developer Read(int developerId)
        {
            return _developers[developerId];
        }

        public Developer Update(int developerId, Developer newDistributor)
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