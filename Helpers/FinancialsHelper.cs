using Microsoft.Data.SqlClient;
using MYH_Reports.Data;
using MYH_Reports.Models;

namespace MYH_Reports.Helpers
{
    public class FinancialsHelper
    {
        private readonly MyhContext _context;

        public FinancialsHelper(MyhContext context)
        {
            _context = context;
        }

        //public InvoicesModel GetInvoicesByJobId(int jobId)
        //{
        //    InvoicesModel invoice = new InvoicesModel();
        //    var sql = $"SELECT * FROM [Invoices] WHERE [JobId] = {jobId}";
        //    var connString = _context;

        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        conn.Open();
        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();
        //            invoice = reader[];
        //        }
        //        conn.Close();
        //    }

        //    return invoice;
        //}


    }
}
