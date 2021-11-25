using System;

namespace FirstRepository.Domain
{
    public class ConnectionPaymentSoftware
    {
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public int SoftwareId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
