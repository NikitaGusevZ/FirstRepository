using FirstRepository.Repository;

namespace FirstRepository.Domain
{
    public class Developer
    {
        public int Id { get; set; }
        public Organization Organization { get; set; }

        public Software PlacementPO(int softwareId, string Name)
        {
            var dev = Storage.DeveloperStorage.Read(softwareId);
            var connection = new Software
            {

                Name = Name
            };
            return Storage.SoftwareStorage.Create(connection);
        }
    }
}
