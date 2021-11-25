using FirstRepository.Repository;

namespace FirstRepository.Domain
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ConnectionPaymentSoftware BuySoftware(int softwareId, int quantity)
        {
            var soft = Storage.SoftwareStorage.Read(softwareId);
            var connection = new ConnectionPaymentSoftware
            {
                SoftwareId = soft.softwareId,
                Price = soft.Price,
                Quantity = quantity
            };
            return Storage.ConnectionPaymentSoftwareStorage.Create(connection);
        }
    }
}
