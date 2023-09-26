namespace ClassLibDb.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public List<Donation>? Donations { get; set; }
    }
}