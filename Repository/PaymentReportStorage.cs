using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class PaymentReportStorage
    {
        private readonly Dictionary<int, PaymentReport> _payReports  = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public PaymentReport Create(PaymentReport payreport)
        {
            var payreportId = _payReports.Keys.Max() + 1;
            payreport.payreportId = payreportId;
            _payReports.Add(payreport.payreportId, payreport);
            return payreport;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PaymentReport Read(int payreportId)
        {
            return _payReports[payreportId];
        }

        public PaymentReport Update(int payreportId, PaymentReport newPayreport)
        {
            _payReports[payreportId] = newPayreport;
            return _payReports[payreportId];
        }

        public bool Delete(int payreportId)
        {
            return _payReports.Remove(payreportId);
        }
    }
}