using MYH_Reports.Interfaces;


namespace MYH_Reports.Models
{
    public class EstimatesModel : IFinancials
    {
        public int JobId { get; set; }

        public DateTime Date { get; set; }

        public ContactsModel? Contact { get; set; }

        public AddressesModel? Address { get; set; }

        public List<JobDetailsModel> JobDetails { get; set; } = new List<JobDetailsModel>();

        public int LabourCost { get; set; }

        public int MaterialCost { get; set; }

        public int JobTotal { get; set; }
    }
}
