using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class PaymentReport
    {
        public int payreportId { get; set; }
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
    }
}
