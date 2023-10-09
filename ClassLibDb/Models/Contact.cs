using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibDb.Models
{
    public class Contact
    {
        [Key]
        [Display(Name = "Account Number")]
        public int AccountNo { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? Street { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? City { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(64), MinLength(2)]
        public string? Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
        public List<Donation>? Donations { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [NotMapped]
        public string SelectText
        {
            get
            {
                return $"{AccountNo}. {FullName}";
            }
        }
    }
}