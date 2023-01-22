using MYH_Reports.Models;


namespace MYH_Reports.Interfaces
{
    public interface IFinancials
    {
        int JobId { get; set; }

        DateTime Date { get; set; }

        ContactsModel? Contact { get; set; }

        AddressesModel? Address { get; set; }

        List<JobDetailsModel> JobDetails { get; set; }

        int LabourCost { get; set; }

        int MaterialCost { get; set; }

        int JobTotal { get; set; }
    }
}
