using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class SoftwareDomain
    {
        public int softwareId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int SoftwareTypeId { get; set; }
        public int Rating{ get; set; }
        public int DeveloperId { get; set; }
    }
}
