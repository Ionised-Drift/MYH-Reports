namespace MYH_Reports.Interfaces
{
    public interface IAddresses
    {
        int AddressId { get; set; }

        string? AddressLine1 { get; set; }

        string? AddressLine2 { get; set; }

        string? TownCity { get; set; }

        string? County { get; set; }

        string? Postcode { get; set; }

        DateTime DateCreated { get; set; }

        DateTime DateUpdated { get; set; }
    }
}
