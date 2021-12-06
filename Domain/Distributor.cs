using FirstRepository.Repository;

namespace FirstRepository.Domain
{
    public class Distributor
    {
        public int Id { get; set; }
        public Organization Organization { get; set; }
    }
}
