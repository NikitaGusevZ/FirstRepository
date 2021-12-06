using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class SoftwareTypeStorage
    {
        private readonly Dictionary<int, SoftwareType> _softTypes = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public SoftwareType Create(SoftwareType softtype)
        {
            var softtypeId = _softTypes.Keys.Max() + 1;
            softtype.Id = softtypeId;
            _softTypes.Add(softtype.Id, softtype);
            return softtype;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SoftwareType Read(int softtypeId)
        {
            return _softTypes[softtypeId];
        }

        public SoftwareType Update(int softtypeId, SoftwareType newSoftType)
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