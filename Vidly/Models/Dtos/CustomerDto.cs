using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Models.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }

        [Required]
        public byte? MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

    }
}
