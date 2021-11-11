using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class PaymentDomain
    {
        public int CusotmerId { get; set; }
        public int DistributorId { get; set; }
        public string PurchaseDate { get; set; }
    }
}
