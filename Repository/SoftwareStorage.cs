using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class SoftwareStorage
    {
        private Dictionary<int, SoftwareDomain> Softwares { get; } = new Dictionary<int, SoftwareDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(SoftwareDomain software)
        {
            Softwares.Add(software.softwareId, software);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SoftwareDomain Read(int softwareId)
        {
            return Softwares[softwareId];
        }

        public SoftwareDomain Update(int softwareId, SoftwareDomain newSoftware)
        {
            Softwares[softwareId] = newSoftware;
            return Softwares[softwareId];
        }

        public bool Delete(int softwareId)
        {
            return Softwares.Remove(softwareId);
        }
    }
}