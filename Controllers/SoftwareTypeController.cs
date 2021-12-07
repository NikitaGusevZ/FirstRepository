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
        public SoftwareType Read(int Id)
        {
            return Storage.SoftwareTypeStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public SoftwareType Update(int Id, SoftwareType newSoftwareType)
        {
            return Storage.SoftwareTypeStorage.Update(Id, newSoftwareType);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.SoftwareTypeStorage.Delete(Id);
        }
    }
}