using MYH_Reports.Models;


namespace MYH_Reports.Interfaces
{
    public interface IFinancials
    {
        int JobId { get; set; }

        DateTime Date { get; set; }

        List<int>? Quantity { get; set; }

        List<string>? Description { get; set; }

        List<int>? Total { get; set; }

        int SubTotal { get; set; }

        int TotalDue { get; set; }

        AddressesModel? Address { get; set; }

        ContactsModel? Contact { get; set; }
    }
}
