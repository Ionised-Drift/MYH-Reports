using MYH_Reports.Interfaces;


namespace MYH_Reports.Models
{
    public class JobDetailsModel : IJobDetails
    {
        public int JobDetailId { get; set; }

        public string? JobType { get; set; }

        public string? Description { get; set; }

        public int? UnitPrice { get; set; }

        public int? Total { get; set; }

        public int? PaymentReceived { get; set; }

        public DateTime PaymentReceivedDate { get; set; }
    }
}
