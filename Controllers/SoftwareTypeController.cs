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
    [Route("/softwaretype")]
    public class SoftwareTypeController : ControllerBase
    {

        [HttpPut("Create")]
        public SoftwareType Create(SoftwareType softwareType)
        {
            Storage.SoftwareTypeStorage.Create(softwareType);
            return Storage.SoftwareTypeStorage.Read(softwareType.Id);
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