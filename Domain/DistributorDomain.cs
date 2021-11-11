using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRepository.Domain
{
    public class DistributorDomain
    {
        public int Id { get; set; }
        public OrganizationDomain Organization { get; set; }
    }
}
