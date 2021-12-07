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
    [Route("/Software")]
    public class SoftwareController : ControllerBase
    {

        [HttpPut("Create")]
        public Software Create(Software software)
        {
            Storage.SoftwareStorage.Create(software);
            return Storage.SoftwareStorage.Read(software.Id);
        }

        [HttpGet("Read")]
        public Software Read(int Id)
        {
            return Storage.SoftwareStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Software Update(int Id, Software newSoftware)
        {
            return Storage.SoftwareStorage.Update(Id,newSoftware);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.SoftwareStorage.Delete(Id);
        }
    }
}
