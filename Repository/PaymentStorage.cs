using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class PaymentStorage
    {
        private readonly Dictionary<int, Payment> _payments = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Payment Create(Payment payment)
        {
            var paymentId = _payments.Keys.Max() + 1;
            payment.Id = paymentId;
            _payments.Add(payment.Id, payment);
            return payment;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Payment Read(int paymentId)
        {
            return _payments[paymentId];
        }

        public Payment Update(int paymentId, Payment newPayment)
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