using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        
        [AllowNull]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthday { get; set; }

    }
}
