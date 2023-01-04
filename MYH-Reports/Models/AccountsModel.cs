using MYH_Reports.Interfaces;


namespace MYH_Reports.Models
{
    public class AccountsModel : IAccounts
    {
        public int AccountId { get; set; }

        public string? AccountName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
