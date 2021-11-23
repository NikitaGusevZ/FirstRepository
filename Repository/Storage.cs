
namespace FirstRepository.Repository
{
    public class Storage
    {
        public static Connection_Payment_SoftwareStorage Connection_Payment_SoftwareStorage { get; } = new Connection_Payment_SoftwareStorage();
        public static CustomerStorage CustomerStorage { get; } = new CustomerStorage();
        public static DeveloperStorage DeveloperStorage { get; } = new DeveloperStorage();
        public static DistributorStorage DistributorStorage { get; } = new DistributorStorage();
        public static OrganizationStorage OrganizationStorage { get; } = new OrganizationStorage();
        public static PaymentReportStorage PaymentReportStorage { get; } = new PaymentReportStorage();
        public static PaymentStorage PaymentStorage { get; } = new PaymentStorage();
        public static SoftwareStorage SoftwareStorage { get; } = new SoftwareStorage();
        public static SoftwareTypeStorage SoftwareTypeStorage { get; }  = new SoftwareTypeStorage();
    }
}
