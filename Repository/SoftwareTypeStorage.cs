using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class SoftwareTypeStorage
    {
        private Dictionary<int, SoftwareTypeDomain> SoftTypes { get; } = new Dictionary<int, SoftwareTypeDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(SoftwareTypeDomain softtype)
        {
            SoftTypes.Add(softtype.softtypeId, softtype);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SoftwareTypeDomain Read(int softtypeId)
        {
            return SoftTypes[softtypeId];
        }

        public SoftwareTypeDomain Update(int softtypeId, SoftwareTypeDomain newSoftType)
        {
            SoftTypes[softtypeId] = newSoftType;
            return SoftTypes[softtypeId];
        }

        public bool Delete(int softtypeId)
        {
            return SoftTypes.Remove(softtypeId);
        }
    }
}