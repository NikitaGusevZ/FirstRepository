using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class SoftwareStorage
    {
        private readonly Dictionary<int, Software> _softwares = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Software Create(Software software)
        {
            var softwareId = _softwares.Keys.Max() + 1;
            software.Id = softwareId;
            _softwares.Add(software.Id, software);
            return software;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Software Read(int softwareId)
        {
            return _softwares[softwareId];
        }

        public Software Update(int softwareId, Software newSoftware)
        {
            _softwares[softwareId] = newSoftware;
            return _softwares[softwareId];
        }

        public bool Delete(int softwareId)
        {
            return _softwares.Remove(softwareId);
        }
    }
}