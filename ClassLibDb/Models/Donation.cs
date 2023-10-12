using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibDb.Models
{
    public class Donation
    {
        [Key]
        [Display(Name = "Transaction ID")]
        public int TransId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Contact")]
        public int AccountNo { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Transaction Type")]
        public int TransactionTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Payment Method")]
        public int PaymentMethodId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(256), MinLength(2)]
        public string? Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }

        [ForeignKey("AccountNo")]
        public Contact? Contact { get; set; }

        [ForeignKey("TransactionTypeId")]
        public TransactionType? TransactionType { get; set; }

        [ForeignKey("PaymentMethodId")]
        public PaymentMethod? PaymentMethod { get; set; }
    }
}