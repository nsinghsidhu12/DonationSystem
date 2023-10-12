namespace ClassLibDb.Models
{
public class ReportViewModel
{
    public string Title { get; set; }
    public decimal TotalAmount { get; set; }
    public string DonorName { get; set; }
    public int DonationYear { get; set; }
    public List<Donation> Donations { get; set; }
}
}
