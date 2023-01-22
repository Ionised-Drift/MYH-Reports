namespace MYH_Reports.Interfaces
{
    public interface IJobDetails
    {
        int JobDetailId { get; set; }

        string? JobType { get; set; }

        string? Description { get; set; }

        int? UnitPrice { get; set; }

        int? Total { get; set; }

        int? PaymentReceived { get; set; }

        DateTime PaymentReceivedDate { get;set; }
    }
}