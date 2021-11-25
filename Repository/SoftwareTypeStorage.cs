using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class SoftwareTypeStorage
    {
        private readonly Dictionary<int, SoftwareTypeDomain> _softTypes = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public SoftwareTypeDomain Create(SoftwareTypeDomain softtype)
        {
            var softtypeId = _softTypes.Keys.Max() + 1;
            softtype.softtypeId = softtypeId;
            _softTypes.Add(softtype.softtypeId, softtype);
            return softtype;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SoftwareTypeDomain Read(int softtypeId)
        {
            return _softTypes[softtypeId];
        }

        public SoftwareTypeDomain Update(int softtypeId, SoftwareTypeDomain newSoftType)
        {
            _softTypes[softtypeId] = newSoftType;
            return _softTypes[softtypeId];
        }

        public bool Delete(int softtypeId)
        {
            return _softTypes.Remove(softtypeId);
        }
    }
}