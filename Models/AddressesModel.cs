using MYH_Reports.Interfaces;


namespace MYH_Reports.Models
{
    public class AddressesModel : IAddresses
    {
        public int AddressId { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? TownCity { get; set; }

        public string? County { get; set; }

        public string? Postcode { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
