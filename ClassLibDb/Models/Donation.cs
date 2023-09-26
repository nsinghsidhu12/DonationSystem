using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibDb.Models
{
    public class Donation
    {
        [Key]
        public int TransId { get; set; }
        public DateTime Date { get; set; }
        public int AccountNo { get; set; }
        public int TransactionTypeId { get; set; }
        public float Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public string? Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        [ForeignKey("AccountNo")]
        public Contact? Contact { get; set; }

        [ForeignKey("TransactionTypeId")]
        public TransactionType? TransactionType { get; set; }

        [ForeignKey("PaymentMethodId")]
        public PaymentMethod? PaymentMethod { get; set; }
    }
}