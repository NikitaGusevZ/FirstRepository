using FirstRepository.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstRepository.Repository
{
    public class PaymentReportStorage
    {
        private Dictionary<int, PaymentReport> PayReports { get; } = new Dictionary<int, PaymentReport>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(PaymentReport payreport)
        {
            PayReports.Add(payreport.payreportId, payreport);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PaymentReport Read(int payreportId)
        {
            return PayReports[payreportId];
        }

        public PaymentReport Update(int payreportId, PaymentReport newPayreport)
        {
            PayReports[payreportId] = newPayreport;
            return PayReports[payreportId];
        }

        public bool Delete(int payreportId)
        {
            return PayReports.Remove(payreportId);
        }
    }
}