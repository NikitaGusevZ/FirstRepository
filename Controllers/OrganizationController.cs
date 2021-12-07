using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstRepository.Domain;
using FirstRepository.Repository;

namespace FirstRepository.Controllers
{
    [ApiController]
    [Route("/organization")]
    public class OrganizationController : ControllerBase
    {

        [HttpPut("Create")]
        public Organization Create(Organization organization)
        {
            Storage.OrganizationStorage.Create(organization);
            return Storage.OrganizationStorage.Read(organization.Id);
        }

        [HttpGet("Read")]
        public Organization Read(int Id)
        {
            return Storage.OrganizationStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Organization Update(int Id, Organization newOrganization)
        {
            return Storage.OrganizationStorage.Update(Id,newOrganization);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.OrganizationStorage.Delete(Id);
        }
    }
}