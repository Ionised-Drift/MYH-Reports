using MYH_Reports.Interfaces;


namespace MYH_Reports.Models
{
    public class EstimatesModel : IFinancials
    {
        public int JobId { get; set; }

        public DateTime Date { get; set; }

        public List<int>? Quantity { get; set; }

        public List<string>? Description { get; set; }

        public List<int>? Total { get; set; }

        public int SubTotal { get; set; }

        public int TotalDue { get; set; }

        public AddressesModel? Address { get; set; }

        public ContactsModel? Contact { get; set; }
    }
}
