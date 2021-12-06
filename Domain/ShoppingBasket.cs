using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class ShoppingBasket
    {
        public int Id { get; set; }
        public int PaymentId {get; set; }
        public int SoftwareId { get; set; }
        public DateTime RegPuchaseDate { get; set; }
        public int quantity { get; set; }
        public decimal AmountMoney { get; set; }
    }
}
