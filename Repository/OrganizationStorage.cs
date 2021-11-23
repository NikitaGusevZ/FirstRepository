using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class OrganizationStorage
    {
        private Dictionary<int, OrganizationDomain> Organizations { get; } = new Dictionary<int, OrganizationDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(OrganizationDomain organization)
        {
            Organizations.Add(organization.organizationId, organization);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public OrganizationDomain Read(int organizationId)
        {
            return Organizations[organizationId];
        }

        public OrganizationDomain Update(int organizationId, OrganizationDomain newOrgz)
        {
            Organizations[organizationId] = newOrgz;
            return Organizations[organizationId];
        }

        public bool Delete(int organizationId)
        {
            return Organizations.Remove(organizationId);
        }
    }
}