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
    [Route("/payment")]
    public class PaymentController : ControllerBase
    {

        [HttpPut("Create")]
        public Payment Create(Payment payment)
        {
            Storage.PaymentStorage.Create(payment);
            return Storage.PaymentStorage.Read(payment.Id);
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
