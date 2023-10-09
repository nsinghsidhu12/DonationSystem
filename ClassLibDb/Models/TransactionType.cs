using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibDb.Models
{
    public class TransactionType
    {
        [Display(Name = "Transaction Type ID")]
        public int TransactionTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(256), MinLength(2)]
        public string? Description { get; set; }
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
                return $"{TransactionTypeId}. {Name}";
            }
        }
    }
}