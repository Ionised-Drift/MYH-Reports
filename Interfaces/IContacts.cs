using MYH_Reports.Models;


namespace MYH_Reports.Interfaces
{
    public interface IContacts
    {
        int ContactId { get; set; }

        string? Title { get; set; }

        string? FirstName { get; set; }

        string? LastName { get; set; }

        string? Email { get; set; }

        string? Telephone { get; set; }

        AddressesModel? Address { get; set; }

        AccountsModel? Account { get; set; }

        DateTime DateCreated { get; set; }

        DateTime DateUpdated { get; set; }
    }
}
