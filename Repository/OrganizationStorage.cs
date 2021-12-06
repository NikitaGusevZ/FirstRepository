using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class OrganizationStorage
    {
        private readonly Dictionary<int, Organization> _organizations = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Organization Create(Organization organization)
        {
            var organizationId = _organizations.Keys.Max() + 1;
            organization.Id = organizationId;
            _organizations.Add(organization.Id, organization);
            return organization;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Organization Read(int organizationId)
        {
            return _organizations[organizationId];
        }

        public Organization Update(int organizationId, Organization newOrgz)
        {
            _organizations[organizationId] = newOrgz;
            return _organizations[organizationId];
        }

        public bool Delete(int organizationId)
        {
            return _organizations.Remove(organizationId);
        }
    }
}