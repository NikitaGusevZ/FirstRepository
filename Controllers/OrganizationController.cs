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
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;
        }
    }
}