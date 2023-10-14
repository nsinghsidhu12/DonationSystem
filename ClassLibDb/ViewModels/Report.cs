using ClassLibDb.Models;

namespace ClassLibDb.ViewModels
{
    public class Report
    {
        public string? Title { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Donation>? Donations { get; set; }
        public string? ContactFullName { get; set; }
        public DateTime DonationDate { get; set; }
        public int Year { get; set; }

    }
}
