using System.ComponentModel.DataAnnotations;

namespace ClassLibDb.Models
{
    public class Contact
    {
        [Key]
        [Display(Name = "Account Number")]
        public int AccountNo { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }

        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
        public List<Donation>? Donations { get; set; }
    }
}