namespace MYH_Reports.Interfaces
{
    public interface IAccounts
    {
        int AccountId { get; set; }

        string? AccountName { get; set; }

        DateTime DateCreated { get; set; }

        DateTime DateUpdated { get; set; }
    }
}
