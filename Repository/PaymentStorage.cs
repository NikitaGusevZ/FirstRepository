using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class PaymentStorage
    {
        private readonly Dictionary<int, PaymentDomain> _payments = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public PaymentDomain Create(PaymentDomain payment)
        {
            var paymentId = _payments.Keys.Max() + 1;
            payment.paymentId = paymentId;
            _payments.Add(payment.paymentId, payment);
            return payment;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PaymentDomain Read(int paymentId)
        {
            return _payments[paymentId];
        }

        public PaymentDomain Update(int paymentId, PaymentDomain newPayment)
        {
            _payments[paymentId] = newPayment;
            return _payments[paymentId];
        }

        public bool Delete(int paymentId)
        {
            return _payments.Remove(paymentId);
        }
    }
}