using MYH_Reports.Interfaces;
using System.ComponentModel.Design;


namespace MYH_Reports.Models
{
    public class ContactsModel : IContacts
    {
        public int ContactId { get; set; }

        public string? Title { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Telephone { get; set; }

        public AccountsModel? Account { get; set; }

        public AddressesModel? Address { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
