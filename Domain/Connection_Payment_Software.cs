using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class Connection_Payment_Software
    {
        public int connectionId { get; set; }
        public int PaymentId { get; set; }
        public int SoftwareId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
