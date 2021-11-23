using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class PaymentStorage
    {
        private Dictionary<int, PaymentDomain> Payments { get; } = new Dictionary<int, PaymentDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(PaymentDomain payment)
        {
            Payments.Add(payment.paymentId, payment);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PaymentDomain Read(int paymentId)
        {
            return Payments[paymentId];
        }

        public PaymentDomain Update(int paymentId, PaymentDomain newPayment)
        {
            Payments[paymentId] = newPayment;
            return Payments[paymentId];
        }

        public bool Delete(int paymentId)
        {
            return Payments.Remove(paymentId);
        }
    }
}