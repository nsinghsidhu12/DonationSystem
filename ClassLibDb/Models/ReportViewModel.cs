namespace ClassLibDb.Models
{
    public class ReportViewModel
    {
        public string Title { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Donation> Donations { get; set; }
    }
}
