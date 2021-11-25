using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class SoftwareStorage
    {
        private readonly Dictionary<int, SoftwareDomain> _softwares = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public SoftwareDomain Create(SoftwareDomain software)
        {
            var softwareId = _softwares.Keys.Max() + 1;
            software.softwareId = softwareId;
            _softwares.Add(software.softwareId, software);
            return software;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SoftwareDomain Read(int softwareId)
        {
            return _softwares[softwareId];
        }

        public SoftwareDomain Update(int softwareId, SoftwareDomain newSoftware)
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