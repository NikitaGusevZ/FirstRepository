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
    [Route("/paymentReport")]
    public class PaymentReportController : ControllerBase
    {

        [HttpPut("Create")]
        public PaymentReport Create(PaymentReport paymentReport)
        {
            Storage.PaymentReportStorage.Create(paymentReport);
            return Storage.PaymentReportStorage.Read(paymentReport.Id);
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
