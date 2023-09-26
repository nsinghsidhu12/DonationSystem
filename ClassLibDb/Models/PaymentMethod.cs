namespace ClassLibDb.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string? Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public List<Donation>? Donations { get; set; }
    }
}