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
        public PaymentReport Read(int Id)
        {
            return Storage.PaymentReportStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public PaymentReport Update(int Id, PaymentReport newPaymentReport)
        {
            return Storage.PaymentReportStorage.Update(Id, newPaymentReport);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.PaymentReportStorage.Delete(Id);
        }
    }
}
