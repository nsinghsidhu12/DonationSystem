using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibDb.Models
{
    public class PaymentMethod
    {
        [Display(Name = "Payment Method ID")]
        public int PaymentMethodId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
        public List<Donation>? Donations { get; set; }

        [NotMapped]
        public string SelectText
        {
            get
            {
                return $"{PaymentMethodId}. {Name}";
            }
        }
    }
}