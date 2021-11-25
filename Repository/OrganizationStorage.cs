using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class OrganizationStorage
    {
        private readonly Dictionary<int, OrganizationDomain> _organizations = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public OrganizationDomain Create(OrganizationDomain organization)
        {
            var organizationId = _organizations.Keys.Max() + 1;
            organization.organizationId = organizationId;
            _organizations.Add(organization.organizationId, organization);
            return organization;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public OrganizationDomain Read(int organizationId)
        {
            return _organizations[organizationId];
        }

        public OrganizationDomain Update(int organizationId, OrganizationDomain newOrgz)
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